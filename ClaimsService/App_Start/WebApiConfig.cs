using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ClaimsService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{action}/{claimNumber}",
                defaults: new { controller = "claims", action = "get" }
            );
            config.Routes.MapHttpRoute(
                name: "ListApi",
                routeTemplate: "{controller}/{action}/{startDate}/{endDate}",
                defaults: new { controller = "claims", action = "list" }
            );
            config.Routes.MapHttpRoute(
                name: "PostApi",
                routeTemplate: "{controller}/{action}",
                defaults: new { controller = "claims", action = "create" }
            );
        }
    }
}
