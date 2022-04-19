namespace Ossmmasoft.UseCasesPorts.Local.PreTitulo
{
    public interface IUpdatePreTituloOutputPort
    {
        Task Handle(PreTitulosDTO preTitulo);
    }
}
