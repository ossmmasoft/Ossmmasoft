namespace Ossmmasoft.Controllers.Local.PreTitulos
{

    [Route("api/[controller]")]
    [ApiController]
    public class ImportPreTitulosController
    {

        readonly IImportPreTitulosInputPort _inputPort;
        readonly IImportPreTitulosOutputPort _outputPort;
        public ImportPreTitulosController(IImportPreTitulosInputPort inputPort,
                IImportPreTitulosOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpGet]
        public async Task<IEnumerable<PreTitulosDTO>> ImportPreTitulos()
        {
            await _inputPort.Handle();
            return ((IPresenter<IEnumerable<PreTitulosDTO>>)_outputPort).Content;

        }
    }
}
