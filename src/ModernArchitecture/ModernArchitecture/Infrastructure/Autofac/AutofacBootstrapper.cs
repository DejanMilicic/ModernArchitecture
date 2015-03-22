
namespace ModernArchitecture.Infrastructure.Autofac
{
	using System.Reflection;
	using System.Web.Mvc;

	using global::Autofac;
	using global::Autofac.Integration.Mvc;

	public static class AutofacBootstrapper
	{
		public static void Configure()
		{
			var builder = new ContainerBuilder();

			builder.RegisterModule(new MvcModule());
			builder.RegisterModule(new MediatrModule());

			// register all other classes that are implementing interfaces
			builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsImplementedInterfaces();

			// Set the dependency resolver to be Autofac.
			IContainer container = builder.Build();
			DependencyResolver.SetResolver(new AutofacDependencyResolver(container));			
		}
	}
}