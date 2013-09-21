using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using System.Web;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.WebApi;
using GearCommons.API.Controllers;
using Newtonsoft.Json;

namespace GearCommons.API {
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class WebApiApplication : System.Web.HttpApplication {
		protected void Application_Start() {
			AreaRegistration.RegisterAllAreas();

			WebApiConfig.Register(GlobalConfiguration.Configuration);			
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
			HandlerConfig.RegisterHandlers(GlobalConfiguration.Configuration.MessageHandlers);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

			var builder = new ContainerBuilder();			
			builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
			builder.RegisterGeneric(typeof (Repository<>)).As(typeof (IRepository<>));
			builder.Register(c => new DatabaseFactory(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString)).As<IDatabaseFactory>();
			builder.RegisterType<LocationSearcher>().As<ILocationSeracher>();
			
			var container = builder.Build();

			var resolver = new AutofacWebApiDependencyResolver(container);
			GlobalConfiguration.Configuration.DependencyResolver = resolver;
		}
	}
}