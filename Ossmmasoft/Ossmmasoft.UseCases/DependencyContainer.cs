using Microsoft.Extensions.DependencyInjection;
using Ossmmasoft.UseCases.Local.PRE.PreDescriptivas;
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
            services.AddTransient<IDeletePreTituloInputPort, DeletePreTituloInteractor>();
            services.AddTransient<IImportPreTitulosInputPort, ImportPreTituloInteractor>();

            services.AddTransient<ICreatePreDescriptivaInputPort, CreatePreDescriptivaInteractor>();
            services.AddTransient<IGetAllPreDescriptivasInputPort, GetAllPreDescriptivasInteractor>();
            services.AddTransient<IGetPreDescriptivaInputPort, GetPreDescriptivaInteractor>();
            services.AddTransient<IUpdatePreDescriptivaInputPort, UpdatePreDescriptivaInteractor>();
            services.AddTransient<IDeletePreDescriptivaInputPort, DeletePreDescriptivaInteractor>();
            services.AddTransient<IImportPreDescriptivasInputPort, ImportPreDescriptivaInteractor>();



            return services;


        }
    }
}
