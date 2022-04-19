namespace Ossmmasoft.UseCasesPorts.Local.PreDescriptivas
{
    public interface IGetPreDescriptivaOutputPort
    {
        Task Handle(PreDescriptivaDto preDescriptivaDto);
    }
}
