namespace Ossmmasoft.UseCasesPorts.Local.PreTitulo
{
    public interface IDeletePreTituloOutputPort
    {
        Task Handle(PreTitulosDTO preTitulo);
    }
}
