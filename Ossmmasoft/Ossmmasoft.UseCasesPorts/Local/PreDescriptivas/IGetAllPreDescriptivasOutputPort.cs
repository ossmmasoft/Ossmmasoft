namespace Ossmmasoft.UseCasesPorts.Local.PreDescriptivas
{
    public interface IGetAllPreDescriptivasOutputPort
    {
        Task Handle(IEnumerable<PreDescriptivaDto> preDescriptivaDto);
    }
}
