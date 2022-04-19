namespace Ossmmasoft.Presenter.Local.PreTitulo
{
    public class ImportPreTituloPresenter : IImportPreTitulosOutputPort, IPresenter<IEnumerable<PreTitulosDTO>>
    {
        public IEnumerable<PreTitulosDTO>? Content { get; set; }

        public Task Handle(IEnumerable<PreTitulosDTO> preTitulos)
        {
            Content = preTitulos;
            return Task.CompletedTask;

        }
    }
}
