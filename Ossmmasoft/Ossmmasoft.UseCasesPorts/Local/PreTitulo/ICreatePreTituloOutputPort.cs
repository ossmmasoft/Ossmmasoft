namespace Ossmmasoft.UseCasesPorts.Local.PreTitulo
{
    public interface ICreatePreTituloOutputPort
    {
        Task Handle(PreTitulosDTO preTitulo);
    }
}
