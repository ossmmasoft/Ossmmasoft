using Microsoft.Extensions.DependencyInjection;
using Ossmmasoft.UseCases.Local.PRE.PreTitulos;

namespace Ossmmasoft.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(
            this IServiceCollection services)
        {
            services.AddTransient<ICreatePreTituloInputPort, CreatePreTituloInteractor>();
            services.AddTransient<IGetAllPreTitulosInputPort, GetAllPreTitulosInteractor>();
            services.AddTransient<IGetPreTituloInputPort, GetPreTituloInteractor>();
            services.AddTransient<IUpdatePreTituloInputPort, UpdatePreTituloInteractor>();
            return services;


        }
    }
}
