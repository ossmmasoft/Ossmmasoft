namespace Ossmmasoft.UseCasesPorts.Local.PreDescriptivas
{
    public interface IUpdatePreDescriptivaOutputPort
    {
        Task Handle(PreDescriptivaDto preDescriptivaDto);
    }
}
