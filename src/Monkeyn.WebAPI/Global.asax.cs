using SC.Sunset.Application.AutoMapper;
using System.Linq;
using System.Web.Http;

namespace Monkeyn.WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutoMapperConfiguration.RegisterMappings();
        }

        protected void Application_BeginRequest()
        {
            if (Request.Headers.AllKeys.Contains("Origin") && Request.HttpMethod == "OPTIONS")
                Response.Flush();
        }
    }
}
