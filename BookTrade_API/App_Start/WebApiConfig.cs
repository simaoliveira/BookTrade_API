using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BookTrade_API {
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {
            #region Formatação JSON e XML

            // Desligar o formatador do XML.
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            // Pretty-print do JSON
            config.Formatters.JsonFormatter.SerializerSettings.Formatting =
                Newtonsoft.Json.Formatting.Indented;


            #endregion

            #region Routing
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            #endregion
        }
    }
}
