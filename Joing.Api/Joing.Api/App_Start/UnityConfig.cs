using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Joing.Data;
using Joing.Data.UnitOfWork;
using Microsoft.AspNet.Identity;
using Joing.Api.Models;
using System.Data.Entity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.DataHandler;
using Joing.Api.Controllers;
using Joing.ApiService;

namespace Joing.Api.App_Start
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterTypes(
              AllClasses.FromLoadedAssemblies(),
              WithMappings.FromMatchingInterface,
              WithName.TypeName,
              WithLifetime.ContainerControlled);
            container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>();
            container.RegisterType<AccountController>(new InjectionConstructor());
            container.RegisterType<IEventRepository, EventRepository>();
            container.RegisterType<IEventUnitOfWork, EventUnitOfWork>();
            container.RegisterType<IEventApiService, EventApiService>();

           

        }
    }
}
