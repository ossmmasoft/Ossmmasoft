namespace Ossmmasoft.UseCasesPorts.Local.PreDescriptivas
{
    public interface IDeletePreDescriptivaOutputPort
    {
        Task Handle(PreDescriptivaDto preTitulo);
    }
}
