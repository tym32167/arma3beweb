using System.Web.Http;
using System.Web.Http.Dispatcher;
using Owin;

namespace Arma3BEWeb.WebApi
{
    public class Startup
    {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder)
        {
            // Configure Web API for self-host. 
            HttpConfiguration config = new HttpConfiguration();
            var r = config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            r.DataTokens["Namespaces"] = new [] { "Arma3BEWeb.WebApi.Controllers" };

            config.Services.Replace(typeof(IAssembliesResolver), new CustomAssemblyResolver());

            appBuilder.UseWebApi(config);
        }
    }
}