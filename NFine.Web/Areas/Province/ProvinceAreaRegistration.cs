using System.Web.Mvc;

namespace NFine.Web.Areas.Province
{
    public class ProvinceAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Province";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Province_default",
                "Province/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
