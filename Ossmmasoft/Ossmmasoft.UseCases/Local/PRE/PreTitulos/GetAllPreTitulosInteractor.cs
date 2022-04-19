namespace Ossmmasoft.UseCases.Local.PRE.PreTitulos
{
    public class GetAllPreTitulosInteractor : IGetAllPreTitulosInputPort
    {
        readonly IPreTituloRepository _repository;
        readonly IGetAllPreTitulosOutputPort _outputPort;

        public GetAllPreTitulosInteractor(IPreTituloRepository repository,
            IGetAllPreTitulosOutputPort outputPort) =>
            (_repository, _outputPort) = (repository, outputPort);


        public Task Handle()
        {
            var preTitulos = _repository.GetAllPreTitulos().Select(p =>
             new PreTitulosDTO
             {
                 Id = p.Id,
                 TituloPadreId = p.TituloPadreId,
                 Codigo = p.Codigo,
                 CodigoEmpresa = p.CodigoEmpresa,
                 Complemento1 = p.Complemento1,
                 Complemento2 = p.Complemento2,
                 Complemento3 = p.Complemento3,
                 Titulo = p.Titulo,

             });

            _outputPort.Handle(preTitulos);
            return Task.CompletedTask;
        }
    }
}
