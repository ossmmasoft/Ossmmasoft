namespace Ossmmasoft.UseCases.Local.PRE.PreDescriptivas
{
    public class CreatePreDescriptivaInteractor : ICreatePreDescriptivaInputPort
    {
        readonly IPreDescriptivaRepository _repository;
        readonly IUnitOfWork _unitOfWork;
        readonly ICreatePreDescriptivaOutputPort _outputPort;

        public CreatePreDescriptivaInteractor(IPreDescriptivaRepository repository,
            IUnitOfWork unitOfWork,
            ICreatePreDescriptivaOutputPort outputPort) =>
            (_repository, _unitOfWork, _outputPort) =
            (repository, unitOfWork, outputPort);

        public async Task Handle(CreatePreDescriptivaDto createPreDescriptivaDto)
        {


            if (createPreDescriptivaDto.Id == 0)
            {
                createPreDescriptivaDto.Id = await _repository.NextId();

            }


            PreDescriptiva newPreDescriptiva = new PreDescriptiva
            {
                Id = createPreDescriptivaDto.Id,
                Codigo = createPreDescriptivaDto.Codigo,
                Descripcion = createPreDescriptivaDto.Descripcion,
                DescripcionPadreId = createPreDescriptivaDto.DescripcionPadreId,
                PreTituloId = createPreDescriptivaDto.PreTituloId,
                CodigoEmpresa = createPreDescriptivaDto.CodigoEmpresa,
                Complemento1 = createPreDescriptivaDto.Complemento1,
                Complemento2 = createPreDescriptivaDto.Complemento2,
                Complemento3 = createPreDescriptivaDto.Complemento3,
                Complemento4 = createPreDescriptivaDto.Complemento4,
                Complemento5 = createPreDescriptivaDto.Complemento5,
                FechaCreacion = createPreDescriptivaDto.FechaCreacion,
                FechaActualizacion = createPreDescriptivaDto.FechaActualizacion,
                UsuarioActualizacion = createPreDescriptivaDto.UsuarioActualizacion,
                UsuarioCreacion = createPreDescriptivaDto.UsuarioCreacion
            };
            _repository.CreatePreDescriptiva(newPreDescriptiva);
            await _unitOfWork.SaveChangesAsync();

            PreDescriptivaDto newPreDescriptivaDto = new PreDescriptivaDto
            {
                Id = newPreDescriptiva.Id,
                DescripcionPadreId = newPreDescriptiva.DescripcionPadreId,
                Codigo = newPreDescriptiva.Codigo,
                PreTituloId = newPreDescriptiva.PreTituloId,
                CodigoEmpresa = newPreDescriptiva.CodigoEmpresa,
                Descripcion = newPreDescriptiva.Descripcion,
                Complemento1 = newPreDescriptiva.Complemento1,
                Complemento2 = newPreDescriptiva.Complemento2,
                Complemento3 = newPreDescriptiva.Complemento3,
                Complemento4 = newPreDescriptiva.Complemento4,
                Complemento5 = newPreDescriptiva.Complemento5,
            };

            await _outputPort.Handle(newPreDescriptivaDto);


        }
    }
}
