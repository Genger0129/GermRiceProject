using NFine.Code;
using NFine.Data;
using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Routing;
using NFine.Data.Migrations;
using Newtonsoft.Json;
using System.Web.Http;
using NFine.Web.App_Start;

namespace NFine.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// 启动应用程序
        /// </summary>
        protected void Application_Start()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            };
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<NFineDbContext, Configuration>());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();//设置返回值统一为json  
        }
    }
}