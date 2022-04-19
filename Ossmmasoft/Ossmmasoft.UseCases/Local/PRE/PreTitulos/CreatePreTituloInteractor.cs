namespace Ossmmasoft.UseCases.Local.PRE.PreTitulos
{
    public class CreatePreTituloInteractor : ICreatePreTituloInputPort
    {
        readonly IPreTituloRepository _repository;
        readonly IUnitOfWork _unitOfWork;
        readonly ICreatePreTituloOutputPort _outputPort;

        public CreatePreTituloInteractor(IPreTituloRepository repository,
            IUnitOfWork unitOfWork,
            ICreatePreTituloOutputPort outputPort) =>
            (_repository, _unitOfWork, _outputPort) =
            (repository, unitOfWork, outputPort);

        public async Task Handle(CreatePreTituloDTO preTituloDTO)
        {
            if (preTituloDTO.Id == 0)
            {
                preTituloDTO.Id = await _repository.NextId();

            }

            PreTitulo newPreTitulo = new PreTitulo
            {
                Id = preTituloDTO.Id,
                TituloPadreId = preTituloDTO.TituloPadreId,
                Codigo = preTituloDTO.Codigo,
                CodigoEmpresa = preTituloDTO.CodigoEmpresa,
                Complemento1 = preTituloDTO.Complemento1,
                Complemento2 = preTituloDTO.Complemento2,
                Complemento3 = preTituloDTO.Complemento3,
                Titulo = preTituloDTO.Titulo,
                FechaCreacion = preTituloDTO.FechaCreacion,
                FechaActualizacion = preTituloDTO.FechaActualizacion,
                UsuarioActualizacion = preTituloDTO.UsuarioActualizacion,
                UsuarioCreacion = preTituloDTO.UsuarioCreacion
            };
            _repository.CreatePreTitulo(newPreTitulo);
            await _unitOfWork.SaveChangesAsync();

            PreTitulosDTO newPreTituloDto = new PreTitulosDTO
            {
                Id = newPreTitulo.Id,
                TituloPadreId = newPreTitulo.TituloPadreId,
                Codigo = newPreTitulo.Codigo,
                CodigoEmpresa = newPreTitulo.CodigoEmpresa,
                Complemento1 = newPreTitulo.Complemento1,
                Complemento2 = newPreTitulo.Complemento2,
                Complemento3 = newPreTitulo.Complemento3,
                Titulo = newPreTitulo.Titulo,

            };

            await _outputPort.Handle(newPreTituloDto);


        }
    }
}
