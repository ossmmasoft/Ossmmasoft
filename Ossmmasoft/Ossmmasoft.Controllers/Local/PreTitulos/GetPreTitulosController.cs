

namespace Ossmmasoft.Controllers.Local.PreTitulos
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetPreTitulosController
    {
        readonly IGetPreTituloInputPort _inputPort;
        readonly IGetPreTituloOutputPort _outputPort;
        public GetPreTitulosController(IGetPreTituloInputPort inputPort,
                IGetPreTituloOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpPost]
        public async Task<PreTituloDTO> GetPreTitulo(FilterPreTituloDto filter)
        {
            await _inputPort.Handle(filter);

            return ((IPresenter<PreTituloDTO>)_outputPort).Content;
        }


    }
}
