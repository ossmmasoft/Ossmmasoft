namespace Ossmmasoft.Controllers.Local.PreTitulos
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreatePreDescriptivaController
    {
        readonly ICreatePreDescriptivaInputPort _inputPort;
        readonly ICreatePreDescriptivaOutputPort _outputPort;
        public CreatePreDescriptivaController(ICreatePreDescriptivaInputPort inputPort,
                ICreatePreDescriptivaOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpPost]
        public async Task<PreDescriptivaDto> CreatePreDescriptiva(CreatePreDescriptivaDto preTitulo)
        {
            await _inputPort.Handle(preTitulo);

            return ((IPresenter<PreDescriptivaDto>)_outputPort).Content;
        }


    }
}
