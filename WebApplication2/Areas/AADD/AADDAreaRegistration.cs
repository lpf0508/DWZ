using System.Web.Mvc;

namespace WebApplication2.Areas.AADD
{
    public class AADDAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "AADD";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "AADD_default1",
                "AADD/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}