

namespace Ossmmasoft.Controllers.Local.PreTitulos
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeletePreTitulosController
    {
        readonly IDeletePreTituloInputPort _inputPort;
        readonly IDeletePreTituloOutputPort _outputPort;
        public DeletePreTitulosController(IDeletePreTituloInputPort inputPort,
                IDeletePreTituloOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpPost]
        public async Task<PreTitulosDTO> DeletePreTitulo(FilterPreTituloDto filter)
        {
            await _inputPort.Handle(filter);

            return ((IPresenter<PreTitulosDTO>)_outputPort).Content;
        }


    }
}
