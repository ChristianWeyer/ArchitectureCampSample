using Microsoft.Owin.Cors;
using Owin;
using System.Web.Http;

namespace Hosting
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);

            var config = new HttpConfiguration();
            WebApiConfig.Register(config);

            app.UseWebApi(config);

            app.MapSignalR();
        }
    }
}