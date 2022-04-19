namespace Ossmmasoft.Controllers.Local.PreTitulos
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeletePreDescriptivaController
    {
        readonly IDeletePreDescriptivaInputPort _inputPort;
        readonly IDeletePreDescriptivaOutputPort _outputPort;
        public DeletePreDescriptivaController(IDeletePreDescriptivaInputPort inputPort,
                IDeletePreDescriptivaOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpPost]
        public async Task<PreDescriptivaDto> DeletePreDescriptiva(FilterPreDescriptivaDto filter)
        {
            await _inputPort.Handle(filter);

            return ((IPresenter<PreDescriptivaDto>)_outputPort).Content;
        }


    }
}
