
namespace ModernArchitecture.Infrastructure.Autofac
{
	using global::Autofac;
	using global::Autofac.Extras.CommonServiceLocator;
	using global::Autofac.Features.Variance;

	using MediatR;

	public class MediatrModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterSource(new ContravariantRegistrationSource());
			builder.RegisterAssemblyTypes(typeof(IMediator).Assembly).AsImplementedInterfaces();
			builder.RegisterType<AutofacServiceLocator>().AsImplementedInterfaces();
		}
	}
}