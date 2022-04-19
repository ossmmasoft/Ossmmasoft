

namespace Ossmmasoft.Controllers.Local.PreDescriptivas
{

    [Route("api/[controller]")]
    [ApiController]
    public class GetAllPreDescriptivasController
    {

        readonly IGetAllPreDescriptivasInputPort _inputPort;
        readonly IGetAllPreDescriptivasOutputPort _outputPort;
        public GetAllPreDescriptivasController(IGetAllPreDescriptivasInputPort inputPort,
                IGetAllPreDescriptivasOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpGet]
        public async Task<IEnumerable<PreDescriptivaDto>> GetAllPreDescriptivas()
        {
            await _inputPort.Handle();
            return ((IPresenter<IEnumerable<PreDescriptivaDto>>)_outputPort).Content;

        }
    }
}
