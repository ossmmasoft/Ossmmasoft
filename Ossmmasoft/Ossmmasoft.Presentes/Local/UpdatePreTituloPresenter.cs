

namespace Ossmmasoft.Presenter.Local
{
    public class UpdatePreTituloPresenter : IUpdatePreTituloOutputPort, IPresenter<PreTituloDTO>
    {
        public PreTituloDTO? Content { get; set; }

        public Task Handle(PreTituloDTO preTitulo)
        {

            Content = preTitulo;
            return Task.CompletedTask;

        }
    }
}
