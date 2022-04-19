namespace Ossmmasoft.UseCases.Local.PRE.PreTitulos
{
    public class DeletePreTituloInteractor : IDeletePreTituloInputPort
    {
        readonly IPreTituloRepository _repository;
        readonly IUnitOfWork _unitOfWork;
        readonly IDeletePreTituloOutputPort _outputPort;

        public DeletePreTituloInteractor(IPreTituloRepository repository,
            IUnitOfWork unitOfWork,
            IDeletePreTituloOutputPort outputPort) =>
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
            await _repository.DeletePreTitulo(filter.Id);
            await _unitOfWork.SaveChangesAsync();
            await _outputPort.Handle(newPreTituloDto);


        }
    }
}
