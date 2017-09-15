using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Http;

namespace NFine.Web.Controllers
{
    public class BaseApiController : ApiController
    {
        public const string UPLOAD_PATH = "/UploadFile/";
        public int PageSize = int.Parse(System.Configuration.ConfigurationManager.AppSettings["PageSize"]);
        public string FaceApi_key = System.Configuration.ConfigurationManager.AppSettings["FaceApi_key"].ToString();
        public string FaceApi_secret = System.Configuration.ConfigurationManager.AppSettings["FaceApi_secret"].ToString();
        public string FaceApi_FaceSet = System.Configuration.ConfigurationManager.AppSettings["FaceApi_FaceSet"].ToString();
        public float FaceApi_Confidence = float.Parse(System.Configuration.ConfigurationManager.AppSettings["FaceApi_Confidence"]);


        protected string ToHttpUrl(string url)
        {
            if (string.IsNullOrEmpty(url))
                return "";
            return string.Format("http://" + HttpContext.Current.Request.ServerVariables["HTTP_HOST"] + "{0}", url);
        }
        protected string GetOrderNumber()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmssfff") + new Random().Next(1000, 9999).ToString();
        }
        protected string CalcAge(DateTime bday)
        {
            DateTime now = DateTime.Today;

            int age = now.Year - bday.Year;

            if (bday > now.AddYears(-age)) age--;
            return age.ToString();
        }
        protected String ToMd5(String pwd)
        {
            MD5 md5 = MD5.Create();
            Byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(pwd));
            StringBuilder stb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
                stb.Append(data[i].ToString("x2"));
            return stb.ToString();
        }
        public class Result
        {
            public Result()
            {
                code = 200;
                message = "";
                data = new object();
            }
            public Result(String msg)
                : this()
            {
                message = msg;
            }
            public Result(int suc, String msg)
            {
                code = suc;
                message = msg;
                data = new object();
            }
            public static Result Err(String msg)
            {
                return new Result(-1, msg);
            }
            public static Result OK()
            {
                return new Result(200, "操作成功");
            }
            public static Result OK(String msg)
            {
                return new Result(200, msg);
            }
            public int code { get; set; }
            public String message { get; set; }
            public object data { get; set; }

        }
    }
}