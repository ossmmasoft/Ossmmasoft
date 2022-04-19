namespace Ossmmasoft.Presenter.Local.PreDescriptivas
{
    public class CreatePreDescriptivaPresenter : ICreatePreDescriptivaOutputPort, IPresenter<PreDescriptivaDto>
    {
        public PreDescriptivaDto? Content { get; set; }

        public Task Handle(PreDescriptivaDto preDescriptivaDto)
        {

            Content = preDescriptivaDto;
            return Task.CompletedTask;

        }
    }
}
