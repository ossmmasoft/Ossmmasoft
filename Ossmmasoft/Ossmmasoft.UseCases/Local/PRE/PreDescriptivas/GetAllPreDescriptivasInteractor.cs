namespace Ossmmasoft.UseCases.Local.PRE.PreDescriptivas
{
    public class GetAllPreDescriptivasInteractor : IGetAllPreDescriptivasInputPort
    {
        readonly IPreDescriptivaRepository _repository;
        readonly IGetAllPreDescriptivasOutputPort _outputPort;

        public GetAllPreDescriptivasInteractor(IPreDescriptivaRepository repository,
            IGetAllPreDescriptivasOutputPort outputPort) =>
            (_repository, _outputPort) = (repository, outputPort);


        public Task Handle()
        {
            var preDescriptivas = _repository.GetAllPreDescriptivas().Select(p =>
             new PreDescriptivaDto
             {
                 Id = p.Id,
                 DescripcionPadreId = p.DescripcionPadreId,
                 Descripcion = p.Descripcion,
                 Codigo = p.Codigo,
                 CodigoEmpresa = p.CodigoEmpresa,
                 Complemento1 = p.Complemento1,
                 Complemento2 = p.Complemento2,
                 Complemento3 = p.Complemento3,
                 Complemento4 = p.Complemento4,
                 Complemento5 = p.Complemento5,
                 PreTituloId = p.PreTituloId,

             });

            _outputPort.Handle(preDescriptivas);
            return Task.CompletedTask;
        }
    }
}
