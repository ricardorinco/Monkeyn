using Monkeyn.Data.CrossCutting;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System.Web.Http;

[assembly: WebActivator.PostApplicationStartMethod(typeof(Monkeyn.WebAPI.App_Start.SimpleInjectorWebApiInitializer), "Initialize")]
namespace Monkeyn.WebAPI.App_Start
{
    public static class SimpleInjectorWebApiInitializer
    {
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();
            
            InitializeContainer(container);
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
            container.Verify();
            
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }
     
        private static void InitializeContainer(Container container)
        {
            BootStrapper.Register(container);
        }
    }
}