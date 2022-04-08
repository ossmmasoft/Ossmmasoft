

namespace Ossmmasoft.Presenter.Local
{
    public class GetPreTituloPresenter : IGetPreTituloOutputPort, IPresenter<PreTituloDTO>
    {
        public PreTituloDTO? Content { get; set; }

        public Task Handle(PreTituloDTO preTitulo)
        {

            Content = preTitulo;
            return Task.CompletedTask;

        }
    }
}
