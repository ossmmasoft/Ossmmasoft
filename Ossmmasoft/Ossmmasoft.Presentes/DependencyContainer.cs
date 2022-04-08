
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

            return service;
        }
    }
}
