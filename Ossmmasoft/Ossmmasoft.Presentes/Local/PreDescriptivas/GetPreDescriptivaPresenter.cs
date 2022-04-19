namespace Ossmmasoft.Presenter.Local.PreDescriptivas
{
    public class GetPreDescriptivaPresenter : IGetPreDescriptivaOutputPort, IPresenter<PreDescriptivaDto>
    {
        public PreDescriptivaDto? Content { get; set; }

        public Task Handle(PreDescriptivaDto predescriptiva)
        {

            Content = predescriptiva;
            return Task.CompletedTask;

        }
    }
}
