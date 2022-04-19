using Ossmmasoft.Entities.External.Interfaces.PRE;

namespace Ossmmasoft.UseCases.Local.PRE.PreTitulos
{
    public class ImportPreTituloInteractor : IImportPreTitulosInputPort
    {
        readonly IPRE_TITULOSRepository _repository;
        readonly IPreTituloRepository _preTituloRepository;
        readonly IUnitOfWork _unitOfWork;
        readonly IImportPreTitulosOutputPort _outputPort;

        public ImportPreTituloInteractor(IPRE_TITULOSRepository repository, IPreTituloRepository preTituloRepository,
        IUnitOfWork unitOfWork,
            IImportPreTitulosOutputPort outputPort) =>
            (_repository, _preTituloRepository, _unitOfWork, _outputPort) =
            (repository, preTituloRepository, unitOfWork, outputPort);

        public async Task Handle()
        {
            List<PreTitulo> createPreTitulos = new();

            var preTitulos = _repository.GetAllPreTitulos().ToList();

            foreach (var preTitulo in preTitulos)
            {

                var findPreTitulo = await _preTituloRepository.GetById(preTitulo.TITULO_ID);
                if (findPreTitulo == null)
                {
                    PreTitulo newPreTitulo = new PreTitulo();

                    newPreTitulo.Id = preTitulo.TITULO_ID;
                    newPreTitulo.TituloPadreId = preTitulo.TITULO_FK_ID;
                    newPreTitulo.Codigo = preTitulo.CODIGO ?? "";
                    newPreTitulo.CodigoEmpresa = preTitulo.CODIGO_EMPRESA ?? 0;
                    newPreTitulo.Complemento1 = preTitulo.EXTRA1 ?? "";
                    newPreTitulo.Complemento2 = preTitulo.EXTRA2 ?? "";
                    newPreTitulo.Complemento3 = preTitulo.EXTRA3 ?? "";
                    newPreTitulo.Titulo = preTitulo.TITULO ?? "";
                    newPreTitulo.FechaActualizacion = preTitulo.FECHA_UPD ?? DateTime.MinValue;
                    newPreTitulo.FechaCreacion = preTitulo.FECHA_INS ?? DateTime.MinValue;
                    newPreTitulo.UsuarioActualizacion = preTitulo.USUARIO_UPD ?? 0;
                    newPreTitulo.UsuarioCreacion = preTitulo.USUARIO_INS ?? 0;
                    _preTituloRepository.CreatePreTitulo(newPreTitulo);
                    await _unitOfWork.SaveChangesAsync();
                }
                else
                {
                    findPreTitulo.TituloPadreId = preTitulo.TITULO_FK_ID;
                    findPreTitulo.Codigo = preTitulo.CODIGO ?? "";
                    findPreTitulo.CodigoEmpresa = preTitulo.CODIGO_EMPRESA ?? 0;
                    findPreTitulo.Complemento1 = preTitulo.EXTRA1 ?? "";
                    findPreTitulo.Complemento2 = preTitulo.EXTRA2 ?? "";
                    findPreTitulo.Complemento3 = preTitulo.EXTRA3 ?? "";
                    findPreTitulo.Titulo = preTitulo.TITULO ?? "";
                    findPreTitulo.FechaActualizacion = preTitulo.FECHA_UPD ?? DateTime.MinValue;
                    findPreTitulo.FechaCreacion = preTitulo.FECHA_INS ?? DateTime.MinValue;
                    findPreTitulo.UsuarioActualizacion = preTitulo.USUARIO_UPD ?? 0;
                    findPreTitulo.UsuarioCreacion = preTitulo.USUARIO_INS ?? 0;
                    _preTituloRepository.UpdatePreTitulo(findPreTitulo);
                    await _unitOfWork.SaveChangesAsync();
                }



                // createPreTitulos.Add(newPreTitulo);

            }







            var pretitulosDto = _preTituloRepository.GetAllPreTitulos().Select(p =>
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

            await _outputPort.Handle(pretitulosDto);


        }
    }
}
