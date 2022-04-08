
namespace Ossmmasoft.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddOssmmasoftDependecies(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRepositories(configuration);
            services.AddUseCasesServices();
            services.AddPresenter();

            return services;
        }
    }
}
