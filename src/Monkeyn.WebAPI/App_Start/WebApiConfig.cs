using System.Web.Http;

namespace Monkeyn.WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration configuration)
        {
            configuration.MapHttpAttributeRoutes();
            configuration.Formatters.Remove(configuration.Formatters.XmlFormatter);
        }
    }
}
