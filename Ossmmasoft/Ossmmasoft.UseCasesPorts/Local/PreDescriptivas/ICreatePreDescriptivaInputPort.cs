namespace Ossmmasoft.UseCasesPorts.Local.PreDescriptivas
{
    public interface ICreatePreDescriptivaInputPort
    {
        Task Handle(CreatePreDescriptivaDto createPreDescriptivaDto);
    }
}
