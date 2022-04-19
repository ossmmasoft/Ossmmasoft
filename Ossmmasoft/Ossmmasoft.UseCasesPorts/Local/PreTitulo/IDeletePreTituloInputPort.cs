

namespace Ossmmasoft.UseCasesPorts.Local.PreTitulo
{
    public interface IDeletePreTituloInputPort
    {
        Task Handle(FilterPreTituloDto filter);
    }
}
