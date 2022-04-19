namespace Ossmmasoft.UseCases.Local.PRE.PreTitulos
{
    public class GetPreTituloInteractor : IGetPreTituloInputPort
    {
        readonly IPreTituloRepository _repository;
        readonly IUnitOfWork _unitOfWork;
        readonly IGetPreTituloOutputPort _outputPort;

        public GetPreTituloInteractor(IPreTituloRepository repository,
            IUnitOfWork unitOfWork,
            IGetPreTituloOutputPort outputPort) =>
            (_repository, _unitOfWork, _outputPort) =
            (repository, unitOfWork, outputPort);

        public async Task Handle(FilterPreTituloDto filter)
        {

            var preTitulo = await _repository.GetById(filter.Id);
            if (preTitulo == null) return;


            PreTitulosDTO newPreTituloDto = new PreTitulosDTO
            {
                Id = preTitulo.Id,
                TituloPadreId = preTitulo.TituloPadreId,
                Codigo = preTitulo.Codigo,
                CodigoEmpresa = preTitulo.CodigoEmpresa,
                Complemento1 = preTitulo.Complemento1,
                Complemento2 = preTitulo.Complemento2,
                Complemento3 = preTitulo.Complemento3,
                Titulo = preTitulo.Titulo,

            };

            await _outputPort.Handle(newPreTituloDto);


        }
    }
}
