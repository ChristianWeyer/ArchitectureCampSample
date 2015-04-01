using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Hosting
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.EnableCors(new EnableCorsAttribute("*","*","*"));

            var formatter = new JsonMediaTypeFormatter();

            config.Formatters.Clear();
            config.Formatters.Add(formatter);

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;

            config.DependencyResolver = ContainerConfiguration.GetWebApiDependencyResolver();
        }
    }
}
