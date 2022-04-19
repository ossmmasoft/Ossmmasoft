

namespace Ossmmasoft.UseCasesPorts.Local.PreDescriptivas
{
    public interface ICreatePreDescriptivaOutputPort
    {
        Task Handle(PreDescriptivaDto preDescriptivaDto);
    }
}
