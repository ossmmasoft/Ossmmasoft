

namespace Ossmmasoft.UseCasesPorts.Local.PreTitulo
{
    public interface ICreatePreTituloInputPort
    {
        Task Handle(CreatePreTituloDTO preTituloDTO);
    }
}
