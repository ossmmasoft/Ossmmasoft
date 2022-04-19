

using Ossmmasoft.Entities.External.Interfaces.PRE;
using Ossmmasoft.RepositoryEFCore.Repositories.External;

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
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            var conexionstring = configuration.GetConnectionString("PreContext");
            services.AddDbContext<ExternalPreContext>(options =>
                options.UseOracle(conexionstring, b => b.UseOracleSQLCompatibility("11")).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

            services.AddScoped<IPreTituloRepository, PreTituloRepository>();
            services.AddScoped<IPRE_TITULOSRepository, PRE_TITULOSRepository>();
            services.AddScoped<IPreDescriptivaRepository, PreDescriptivaRepository>();
            services.AddScoped<IPRE_DESCRIPTIVARepository, PRE_DESCRIPTIVARepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }

    }
}
