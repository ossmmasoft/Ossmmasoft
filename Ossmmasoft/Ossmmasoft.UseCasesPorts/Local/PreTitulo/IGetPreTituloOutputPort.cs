namespace Ossmmasoft.UseCasesPorts.Local.PreTitulo
{
    public interface IGetPreTituloOutputPort
    {
        Task Handle(PreTituloDTO preTitulo);
    }
}
