
namespace ModernArchitecture.Infrastructure.Autofac
{
	using System.Reflection;

	using global::Autofac;
	using global::Autofac.Integration.Mvc;

	using Module = global::Autofac.Module;

	public class MvcModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			// Register your MVC controllers.
			builder.RegisterControllers(typeof(MvcApplication).Assembly);

			// OPTIONAL: Register model binders that require DI.
			builder.RegisterModelBinders(Assembly.GetExecutingAssembly());
			builder.RegisterModelBinderProvider();

			// OPTIONAL: Register web abstractions like HttpContextBase.
			builder.RegisterModule<AutofacWebTypesModule>();

			// OPTIONAL: Enable property injection in view pages.
			builder.RegisterSource(new ViewRegistrationSource());

			// OPTIONAL: Enable property injection into action filters.
			builder.RegisterFilterProvider();
		}
	}
}