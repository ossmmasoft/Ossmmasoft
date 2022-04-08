

namespace Ossmmasoft.UseCasesPorts.Local.PreTitulo
{
    public interface IUpdatePreTituloInputPort
    {
        Task Handle(UpdatePreTituloDTO preTituloDTO);
    }
}
