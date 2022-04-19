namespace Ossmmasoft.Controllers.Local.PreDescriptivas
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdatePreDescriptivaController
    {
        readonly IUpdatePreDescriptivaInputPort _inputPort;
        readonly IUpdatePreDescriptivaOutputPort _outputPort;
        public UpdatePreDescriptivaController(IUpdatePreDescriptivaInputPort inputPort,
                IUpdatePreDescriptivaOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpPost]
        public async Task<PreDescriptivaDto> UpdatePreDescriptiva(UpdatePreDescriptivaDto preDescriptiva)
        {
            await _inputPort.Handle(preDescriptiva);

            return ((IPresenter<PreDescriptivaDto>)_outputPort).Content;
        }


    }
}
