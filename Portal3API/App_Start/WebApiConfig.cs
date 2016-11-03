using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Portal3API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            //enable cors
            config.EnableCors();

            // Web API routes
            config.MapHttpAttributeRoutes();

            //default to json
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));
        }
    }
}
