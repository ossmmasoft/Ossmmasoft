

namespace Ossmmasoft.UseCasesPorts.Local.PreTitulo
{
    public interface IGetPreTituloInputPort
    {
        Task Handle(FilterPreTituloDto filter);
    }
}
