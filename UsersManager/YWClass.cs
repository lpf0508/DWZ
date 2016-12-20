using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace UsersManager
{
    public class YWClass : AreaRegistration
    {
        public override string AreaName
        {
            get { return "YW"; }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute("",
                "YW/{controller}/{action}",
                new { controller = "Home", action = "Index" },
                null,
                new string[] { "UsersManager.Controllers" });
        }
    }
}
