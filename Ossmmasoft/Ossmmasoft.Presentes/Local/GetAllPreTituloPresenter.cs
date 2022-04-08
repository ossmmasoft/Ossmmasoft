namespace Ossmmasoft.Presenter.Local
{
    public class GetAllPreTituloPresenter : IGetAllPreTitulosOutputPort, IPresenter<IEnumerable<PreTituloDTO>>
    {
        public IEnumerable<PreTituloDTO>? Content { get; set; }

        public Task Handle(IEnumerable<PreTituloDTO> preTitulos)
        {
            Content = preTitulos;
            return Task.CompletedTask;

        }
    }
}
