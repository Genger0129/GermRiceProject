using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace NFine.Web.Controllers
{
    public class InterfaceBaseController : ApiController
    {
        public const string UPLOAD_PATH = "/UploadFile/";
        protected string ToHttpUrl(string url)
        {
            if (string.IsNullOrEmpty(url))
                return "";
            return string.Format("http://" + HttpContext.Current.Request.ServerVariables["HTTP_HOST"] + "{0}", url);
        }
    }
}