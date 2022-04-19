namespace Ossmmasoft.UseCasesPorts.Local.PreDescriptivas
{
    public interface IGetPreDescriptivaInputPort
    {
        Task Handle(FilterPreDescriptivaDto filter);
    }
}
