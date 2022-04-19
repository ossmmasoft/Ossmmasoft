namespace Ossmmasoft.Presenter.Local.PreDescriptivas
{
    public class ImportPreDescriptivaPresenter : IImportPreDescriptivasOutputPort, IPresenter<IEnumerable<PreDescriptivaDto>>
    {
        public IEnumerable<PreDescriptivaDto>? Content { get; set; }

        public Task Handle(IEnumerable<PreDescriptivaDto> predescriptivas)
        {
            Content = predescriptivas;
            return Task.CompletedTask;

        }
    }
}
