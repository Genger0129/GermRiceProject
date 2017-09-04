using NFine.Code.WeChat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Security;
using System.Xml;

namespace NFine.Web.Controllers
{
    public class InterfaceEventRecvController : ApiController
    {
        public void Valid()
        {
            var context = HttpContext.Current;
            if (CheckSignature(context))
            {
                string echoStr = context.Request.QueryString["echoStr"].ToString();
                if (!string.IsNullOrEmpty(echoStr))
                {
                    context.Response.Write(echoStr);
                    context.Response.End();
                }
            }
            else
            {
                context.Response.Write(AnalyzeXmlFromWeiXin(context));
                context.Response.End();
            }
        }
        private bool CheckSignature(HttpContext context)
        {
            if (context.Request.QueryString["signature"] == null)
                return false;
            string signature = context.Request.QueryString["signature"].ToString();
            string timestamp = context.Request.QueryString["timestamp"].ToString();
            string nonce = context.Request.QueryString["nonce"].ToString();
            var Token = "Clinicalsoft1";
            string[] ArrTmp = { Token, timestamp, nonce };
            Array.Sort(ArrTmp);     //字典排序  
            string tmpStr = string.Join("", ArrTmp);
            tmpStr = FormsAuthentication.HashPasswordForStoringInConfigFile(tmpStr, "SHA1");
            tmpStr = tmpStr.ToLower();
            if (tmpStr == signature)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 分析微信POST到本服务器的XML数据
        /// </summary>
        /// <param name="xmlStream"></param>
        /// <returns></returns>
        private string AnalyzeXmlFromWeiXin(HttpContext context)
        {
            try
            {
                var xmlMsg = RequestMessageFactory.GetRequestEntity(context.Request.InputStream);
                switch (xmlMsg.MsgType)
                {
                    case RequestMsgType.Event://如果是事件
                        return OnAttention((RequestMessageEventBase)xmlMsg);
                    default:
                        return "";
                }
            }
            catch (Exception ex)
            {
                return "分析微信POST到本服务器的XML数据 出错";
            }
        }
        private string OnAttention(RequestMessageEventBase xmlMsg)
        {
            try
            {
                var content = "";
                ResponseMessageBase responseMessage = null;
                //如果是关注，则发送欢迎消息
                switch (xmlMsg.Event)
                {
                    case Event.subscribe:
                        var res = (ResponseMessageText)ResponseMessageBase.CreateFromRequestMessage(xmlMsg, ResponseMsgType.Text);
                        res.Content = "用户关注";
                        responseMessage = res;
                        break;
                    case Event.unsubscribe:
                        content = "取消关注";
                        break;
                    case Event.scan:
                        content = "扫码";
                        break;
                    case Event.TEMPLATESENDJOBFINISH:
                        content = "模板消息";
                        break;
                    default:
                        //不处理的消息
                        break;
                }
                return EntityHelper.ConvertEntityToXmlString(responseMessage);
            }
            catch (Exception ex)
            {
                return "";
            }
        }

    }
}