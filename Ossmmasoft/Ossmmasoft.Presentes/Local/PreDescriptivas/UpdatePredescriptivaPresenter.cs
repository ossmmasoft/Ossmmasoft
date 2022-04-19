namespace Ossmmasoft.Presenter.Local.PreDescriptivas
{
    public class UpdatePreDescriptivaPresenter : IUpdatePreDescriptivaOutputPort, IPresenter<PreDescriptivaDto>
    {
        public PreDescriptivaDto? Content { get; set; }

        public Task Handle(PreDescriptivaDto preDescriptiva)
        {

            Content = preDescriptiva;
            return Task.CompletedTask;

        }
    }
}
