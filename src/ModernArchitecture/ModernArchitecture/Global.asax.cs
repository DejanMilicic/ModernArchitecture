
namespace ModernArchitecture
{
	using System.Web.Mvc;
	using System.Web.Routing;
	using ModernArchitecture.Extensions;
	using FluentValidation.Mvc;

	using ModernArchitecture.Infrastructure.Autofac;

	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			GlobalFilters.Filters.Add(new ValidatorActionFilter());
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			FluentValidationModelValidatorProvider.Configure();

			AutofacBootstrapper.Configure();
		}
	}
}
