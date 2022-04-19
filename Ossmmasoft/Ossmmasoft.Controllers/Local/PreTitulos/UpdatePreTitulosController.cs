

namespace Ossmmasoft.Controllers.Local.PreTitulos
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdatePreTitulosController
    {
        readonly IUpdatePreTituloInputPort _inputPort;
        readonly IUpdatePreTituloOutputPort _outputPort;
        public UpdatePreTitulosController(IUpdatePreTituloInputPort inputPort,
                IUpdatePreTituloOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpPost]
        public async Task<PreTitulosDTO> UpdatePreTitulo(UpdatePreTituloDTO preTitulo)
        {
            await _inputPort.Handle(preTitulo);

            return ((IPresenter<PreTitulosDTO>)_outputPort).Content;
        }


    }
}
