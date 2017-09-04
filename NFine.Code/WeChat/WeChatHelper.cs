using Newtonsoft.Json;
using NFine.Code.Redis;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Code.WeChat
{
    public class WeChatHelper
    {
        public WeChatResult GetAccessToken(string WeChatId, string WeChatAppSecret, string testFlag, AccessTokenType TokenType)
        {
            try
            {
                var tokeninfo = "";
                var JsonFileName = System.Web.HttpContext.Current.Request.PhysicalApplicationPath + "\\" + "WeChatToken.json";
                var DateNow = DateTime.Now;
                var IsHasRedis = new RedisHelper().Ping();
                var IsHasTokenJsonFile = false;
                var TokenJsonStr = "";
                #region 1、有Redis服务器，内存读取;2、无Redis服务器，文件流
                if (IsHasRedis)
                    TokenJsonStr = new RedisHelper().getValue(testFlag + "NormalWeChatToken");
                else
                {
                    IsHasTokenJsonFile = FileHelper.IsExistFile(JsonFileName);
                    if (IsHasTokenJsonFile)
                        TokenJsonStr = File.ReadAllText(JsonFileName);
                }
                #endregion
                //1、token服务器不存在，首次创建;2、token服务器存在判断是否过期，过期则重新获取，未过期则直接使用
                var IsNeedUpdateToken = true;
                List<TokenDef> listToken = new List<TokenDef>();
                TokenDef modelToken = null;
                #region 取得已存储Token
                if (!string.IsNullOrEmpty(TokenJsonStr))
                {
                    listToken = JsonConvert.DeserializeObject<List<TokenDef>>(TokenJsonStr);
                    modelToken = listToken.Where(x => x.TokenType == TokenType && x.WeChatId == WeChatId).FirstOrDefault();
                }
                if (modelToken != null)
                {
                    if ((DateNow - modelToken.EndTime).Seconds < 0)
                    {
                        IsNeedUpdateToken = false;
                        tokeninfo = modelToken.AccessToken;
                    }
                }
                #endregion
                if (IsNeedUpdateToken)
                {
                    #region 获取新Token
                    string url = "https://api.weixin.qq.com/cgi-bin/token";
                    string data = "grant_type=client_credential&appid=" + WeChatId + "&secret=" + WeChatAppSecret + "";
                    var token = HttpMethods.HttpPost(url, data);
                    if (string.IsNullOrEmpty(token))
                        return new WeChatResult() { IsSuccess = false, Msg = "Token请求失败" };
                    List<Info> jobInfoList = JsonConvert.DeserializeObject<List<Info>>("[" + token + "]");
                    if (jobInfoList.Count > 0)
                        tokeninfo = jobInfoList[0].access_token;
                    else
                        return new WeChatResult() { IsSuccess = false, Msg = "Token请求失败" };
                    if (modelToken == null)
                    {
                        listToken.Add(new TokenDef()
                        {
                            WeChatId = WeChatId,
                            TokenType = TokenType,
                            AccessToken = tokeninfo,
                            StartTime = DateNow,
                            EndTime = DateNow.AddHours(1)
                        });
                    }
                    else
                    {
                        foreach (var item in listToken)
                        {
                            if (item.WeChatId == WeChatId && TokenType == item.TokenType)
                            {
                                item.StartTime = DateNow;
                                item.EndTime = DateNow.AddHours(1);
                                item.AccessToken = tokeninfo;
                            }
                        }
                    }
                    #endregion
                    #region 存储新Token
                    var newJsonToken = JsonConvert.SerializeObject(listToken);
                    if (IsHasRedis)
                        new RedisHelper().setValue(testFlag + "NormalWeChatToken", newJsonToken);
                    else
                    {
                        if (!IsHasTokenJsonFile)
                            FileHelper.CreateFile(JsonFileName);
                        File.WriteAllText(JsonFileName,newJsonToken);
                    }
                    #endregion
                }
                return new WeChatResult() { IsSuccess = true, Msg = tokeninfo };
            }
            catch (Exception ex)
            {
                return new WeChatResult() { IsSuccess = false, Msg = "Token请求失败" };
            }
        }
    }
    public class WeChatResult
    {
        public bool IsSuccess { get; set; }
        public string Msg { get; set; }
    }
    public enum AccessTokenType
    {
        AccessToken,
        jsapi_ticket
    }
    public class Info
    {
        public string access_token { get; set; }
        public string expires_in { get; set; }
    }
    public class TokenDef
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string WeChatId { get; set; }
        public AccessTokenType TokenType { get; set; }
        public string AccessToken { get; set; }
    }
}
