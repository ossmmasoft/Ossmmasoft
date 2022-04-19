namespace Ossmmasoft.Controllers.Local.PreDescriptivas
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetPreDescriptivaController
    {
        readonly IGetPreDescriptivaInputPort _inputPort;
        readonly IGetPreDescriptivaOutputPort _outputPort;
        public GetPreDescriptivaController(IGetPreDescriptivaInputPort inputPort,
                IGetPreDescriptivaOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpPost]
        public async Task<PreDescriptivaDto> GetPreTitulo(FilterPreDescriptivaDto filter)
        {
            await _inputPort.Handle(filter);

            return ((IPresenter<PreDescriptivaDto>)_outputPort).Content;
        }


    }
}
