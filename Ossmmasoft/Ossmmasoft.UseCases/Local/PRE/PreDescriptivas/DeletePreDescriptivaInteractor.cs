namespace Ossmmasoft.UseCases.Local.PRE.PreDescriptivas
{
    public class DeletePreDescriptivaInteractor : IDeletePreDescriptivaInputPort
    {
        readonly IPreDescriptivaRepository _repository;
        readonly IUnitOfWork _unitOfWork;
        readonly IDeletePreDescriptivaOutputPort _outputPort;

        public DeletePreDescriptivaInteractor(IPreDescriptivaRepository repository,
            IUnitOfWork unitOfWork,
            IDeletePreDescriptivaOutputPort outputPort) =>
            (_repository, _unitOfWork, _outputPort) =
            (repository, unitOfWork, outputPort);

        public async Task Handle(FilterPreDescriptivaDto filter)
        {

            var preDescriptiva = await _repository.GetById(filter.Id);
            if (preDescriptiva == null) return;


            PreDescriptivaDto preDescriptivaDto = new PreDescriptivaDto
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
            await _repository.DeletePreDescriptiva(filter.Id);
            await _unitOfWork.SaveChangesAsync();
            await _outputPort.Handle(preDescriptivaDto);


        }
    }
}
