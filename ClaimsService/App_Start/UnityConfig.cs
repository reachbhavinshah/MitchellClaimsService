using Claims.Repository;
using ClaimsService.XML;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace ClaimsService
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);

            //Map ClaimsRepository to a dummy repository. Replace this with actual repository for a prod level code.
            container.RegisterType<IClaimsRepository, DummyClaimsRepository>();
            container.RegisterType<IServerPath, ServerPath>();
        }
    }
}