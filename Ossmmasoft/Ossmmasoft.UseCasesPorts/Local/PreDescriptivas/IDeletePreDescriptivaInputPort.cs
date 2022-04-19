

namespace Ossmmasoft.UseCasesPorts.Local.PreDescriptivas
{
    public interface IDeletePreDescriptivaInputPort
    {
        Task Handle(FilterPreDescriptivaDto filter);
    }
}
