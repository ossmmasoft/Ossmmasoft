namespace Ossmmasoft.UseCasesPorts.Local.PreDescriptivas
{
    public interface IImportPreDescriptivasOutputPort
    {
        Task Handle(IEnumerable<PreDescriptivaDto> preDescriptivaDto);
    }
}
