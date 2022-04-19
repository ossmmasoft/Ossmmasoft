
namespace Ossmmasoft.Presenter.Local.PreDescriptivas
{
    public class GetAllPreDescriptivaPresenter : IGetAllPreDescriptivasOutputPort, IPresenter<IEnumerable<PreDescriptivaDto>>
    {
        public IEnumerable<PreDescriptivaDto>? Content { get; set; }

        public Task Handle(IEnumerable<PreDescriptivaDto> preDescriptivas)
        {
            Content = preDescriptivas;
            return Task.CompletedTask;

        }
    }
}
