namespace Ossmmasoft.UseCasesPorts.Local.PreDescriptivas
{
    public interface IUpdatePreDescriptivaInputPort
    {
        Task Handle(UpdatePreDescriptivaDto ipdatePreDescriptivaDto);
    }
}
