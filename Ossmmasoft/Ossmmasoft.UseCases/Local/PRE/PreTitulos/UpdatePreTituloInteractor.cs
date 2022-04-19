namespace Ossmmasoft.UseCases.Local.PRE.PreTitulos
{
    public class UpdatePreTituloInteractor : IUpdatePreTituloInputPort
    {
        readonly IPreTituloRepository _repository;
        readonly IUnitOfWork _unitOfWork;
        readonly IUpdatePreTituloOutputPort _outputPort;

        public UpdatePreTituloInteractor(IPreTituloRepository repository,
            IUnitOfWork unitOfWork,
            IUpdatePreTituloOutputPort outputPort) =>
            (_repository, _unitOfWork, _outputPort) =
            (repository, unitOfWork, outputPort);


        public async Task Handle(UpdatePreTituloDTO preTituloDTO)
        {
            var preTitulo = await _repository.GetById(preTituloDTO.Id);
            if (preTitulo == null) return;

            preTitulo.TituloPadreId = preTituloDTO.TituloPadreId;
            preTitulo.Codigo = preTituloDTO.Codigo;
            preTitulo.CodigoEmpresa = preTituloDTO.CodigoEmpresa;
            preTitulo.Complemento1 = preTituloDTO.Complemento1;
            preTitulo.Complemento2 = preTituloDTO.Complemento2;
            preTitulo.Complemento3 = preTituloDTO.Complemento3;
            preTitulo.Titulo = preTituloDTO.Titulo;
            preTitulo.FechaActualizacion = preTituloDTO.FechaActualizacion;
            preTitulo.UsuarioActualizacion = preTituloDTO.UsuarioActualizacion;


            _repository.UpdatePreTitulo(preTitulo);
            await _unitOfWork.SaveChangesAsync();

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
