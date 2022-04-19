
namespace Ossmmasoft.Presenter
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenter(this IServiceCollection service)
        {
            service.AddScoped<ICreatePreTituloOutputPort, CreatePreTituloPresenter>();
            service.AddScoped<IGetAllPreTitulosOutputPort, GetAllPreTituloPresenter>();
            service.AddScoped<IGetPreTituloOutputPort, GetPreTituloPresenter>();
            service.AddScoped<IUpdatePreTituloOutputPort, UpdatePreTituloPresenter>();
            service.AddScoped<IDeletePreTituloOutputPort, DeletePreTituloPresenter>();
            service.AddScoped<IImportPreTitulosOutputPort, ImportPreTituloPresenter>();


            service.AddScoped<ICreatePreDescriptivaOutputPort, CreatePreDescriptivaPresenter>();
            service.AddScoped<IGetAllPreDescriptivasOutputPort, GetAllPreDescriptivaPresenter>();
            service.AddScoped<IGetPreDescriptivaOutputPort, GetPreDescriptivaPresenter>();
            service.AddScoped<IUpdatePreDescriptivaOutputPort, UpdatePreDescriptivaPresenter>();
            service.AddScoped<IDeletePreDescriptivaOutputPort, DeletePreDescriptivaPresenter>();
            service.AddScoped<IImportPreDescriptivasOutputPort, ImportPreDescriptivaPresenter>();



            return service;
        }
    }
}
