using Achievement_Data.Repository;
using Achievement_Data.RepositoryInterfaces;
using Achievement_Service.Service;
using Achievement_Service.ServiceInterfaces;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace AchievementDemo
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IAccountService, AccountService>();
            container.RegisterType<IAccountRepository, AccountRepository>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}