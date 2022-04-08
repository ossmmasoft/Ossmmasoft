namespace Ossmmasoft.UseCasesPorts.Local.PreTitulo
{
    public interface IUpdatePreTituloOutputPort
    {
        Task Handle(PreTituloDTO preTitulo);
    }
}
