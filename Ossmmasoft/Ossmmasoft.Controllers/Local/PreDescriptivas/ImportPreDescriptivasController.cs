using Ossmmasoft.DTOs.Local.PreDescriptiva;

namespace Ossmmasoft.Controllers.Local.PreDescriptivas
{

    [Route("api/[controller]")]
    [ApiController]
    public class ImportPreDescriptivasController
    {

        readonly IImportPreDescriptivasInputPort _inputPort;
        readonly IImportPreDescriptivasOutputPort _outputPort;
        public ImportPreDescriptivasController(IImportPreDescriptivasInputPort inputPort,
                IImportPreDescriptivasOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpGet]
        public async Task<IEnumerable<PreDescriptivaDto>> ImportPreDescriptivas()
        {
            await _inputPort.Handle();
            return ((IPresenter<IEnumerable<PreDescriptivaDto>>)_outputPort).Content;

        }
    }
}
