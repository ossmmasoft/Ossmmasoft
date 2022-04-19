namespace Ossmmasoft.UseCasesPorts.Local.PreTitulo
{
    public interface IGetPreTituloOutputPort
    {
        Task Handle(PreTitulosDTO preTitulo);
    }
}
