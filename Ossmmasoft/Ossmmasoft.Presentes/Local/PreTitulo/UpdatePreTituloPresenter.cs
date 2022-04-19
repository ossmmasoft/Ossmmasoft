namespace Ossmmasoft.Presenter.Local.PreTitulo
{
    public class UpdatePreTituloPresenter : IUpdatePreTituloOutputPort, IPresenter<PreTitulosDTO>
    {
        public PreTitulosDTO? Content { get; set; }

        public Task Handle(PreTitulosDTO preTitulo)
        {

            Content = preTitulo;
            return Task.CompletedTask;

        }
    }
}
