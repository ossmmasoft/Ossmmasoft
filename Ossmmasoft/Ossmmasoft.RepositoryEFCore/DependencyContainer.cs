

namespace Ossmmasoft.RepositoryEFCore
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<OssmmasoftContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConecctionPostgres")));
            services.AddScoped<IPreTituloRepository, PreTituloRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }

    }
}
