using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;


namespace WebApplication2
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            string origins = "http://localhost:8082";//这里配置可供外面访问的IP和端口
            string headers = "*";
            string methods = "*";
            config.EnableCors(new EnableCorsAttribute(origins, headers, methods));
            

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional,action = "post" }
            );

            config.Routes.MapHttpRoute(
                name: "ssss",
                routeTemplate: "AADD_default1/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional, action = "post"}
            );

            config.Formatters.Remove(config.Formatters.XmlFormatter);

        }
    }
}
