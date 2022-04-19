namespace Ossmmasoft.Controllers.Local.PreTitulos
{

    [Route("api/[controller]")]
    [ApiController]
    public class GetAllPreTitulosController
    {

        readonly IGetAllPreTitulosInputPort _inputPort;
        readonly IGetAllPreTitulosOutputPort _outputPort;
        public GetAllPreTitulosController(IGetAllPreTitulosInputPort inputPort,
                IGetAllPreTitulosOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpGet]
        public async Task<IEnumerable<PreTitulosDTO>> GetAllPreTirulos()
        {
            await _inputPort.Handle();
            return ((IPresenter<IEnumerable<PreTitulosDTO>>)_outputPort).Content;

        }
    }
}
