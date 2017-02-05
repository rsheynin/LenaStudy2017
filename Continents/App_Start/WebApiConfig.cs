using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Continents
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "LanguageApi",
                routeTemplate: "api/{controller}/{langId}",
                defaults: new { langId = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "ContryApi",
                routeTemplate: "api/{controller}/{contryId}",
                defaults: new { contryId = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "ContinentApi",
                routeTemplate: "api/{controller}/{continentId}",
                defaults: new { continentId = RouteParameter.Optional }
            );
        }
    }
}
