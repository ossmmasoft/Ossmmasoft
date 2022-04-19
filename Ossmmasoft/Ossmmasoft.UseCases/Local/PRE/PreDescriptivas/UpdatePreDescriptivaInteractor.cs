namespace Ossmmasoft.UseCases.Local.PRE.PreDescriptivas
{
    public class UpdatePreDescriptivaInteractor : IUpdatePreDescriptivaInputPort
    {
        readonly IPreDescriptivaRepository _repository;
        readonly IUnitOfWork _unitOfWork;
        readonly IUpdatePreDescriptivaOutputPort _outputPort;

        public UpdatePreDescriptivaInteractor(IPreDescriptivaRepository repository,
            IUnitOfWork unitOfWork,
            IUpdatePreDescriptivaOutputPort outputPort) =>
            (_repository, _unitOfWork, _outputPort) =
            (repository, unitOfWork, outputPort);


        public async Task Handle(UpdatePreDescriptivaDto updatePreDescriptivaDto)
        {
            var preDescriptiva = await _repository.GetById(updatePreDescriptivaDto.Id);
            if (preDescriptiva == null) return;

            preDescriptiva.PreTituloId = updatePreDescriptivaDto.PreTituloId;
            preDescriptiva.DescripcionPadreId = updatePreDescriptivaDto.DescripcionPadreId;
            preDescriptiva.Descripcion = updatePreDescriptivaDto.Descripcion;
            preDescriptiva.Codigo = updatePreDescriptivaDto.Codigo;
            preDescriptiva.PreTituloId = updatePreDescriptivaDto.PreTituloId;
            preDescriptiva.CodigoEmpresa = updatePreDescriptivaDto.CodigoEmpresa;
            preDescriptiva.Complemento1 = updatePreDescriptivaDto.Complemento1;
            preDescriptiva.Complemento2 = updatePreDescriptivaDto.Complemento2;
            preDescriptiva.Complemento3 = updatePreDescriptivaDto.Complemento3;
            preDescriptiva.Complemento4 = updatePreDescriptivaDto.Complemento4;
            preDescriptiva.Complemento5 = updatePreDescriptivaDto.Complemento5;
            preDescriptiva.FechaActualizacion = updatePreDescriptivaDto.FechaActualizacion;
            preDescriptiva.FechaCreacion = updatePreDescriptivaDto.FechaCreacion;
            preDescriptiva.UsuarioActualizacion = updatePreDescriptivaDto.UsuarioActualizacion;
            preDescriptiva.UsuarioCreacion = updatePreDescriptivaDto.UsuarioCreacion;

            _repository.UpdatePreDescriptiva(preDescriptiva);
            await _unitOfWork.SaveChangesAsync();

            PreDescriptivaDto newPreTituloDto = new PreDescriptivaDto
            {
                Id = preDescriptiva.Id,
                DescripcionPadreId = preDescriptiva.DescripcionPadreId,
                Descripcion = preDescriptiva.Descripcion,
                Codigo = preDescriptiva.Codigo,
                CodigoEmpresa = preDescriptiva.CodigoEmpresa,
                Complemento1 = preDescriptiva.Complemento1,
                Complemento2 = preDescriptiva.Complemento2,
                Complemento3 = preDescriptiva.Complemento3,
                Complemento4 = preDescriptiva.Complemento4,
                Complemento5 = preDescriptiva.Complemento5,
                PreTituloId = preDescriptiva.PreTituloId,


            };

            await _outputPort.Handle(newPreTituloDto);


        }
    }
}
