
namespace Ossmmasoft.UseCases.Local.PRE.PreDescriptivas
{
    public class ImportPreDescriptivaInteractor : IImportPreDescriptivasInputPort
    {
        readonly IPRE_DESCRIPTIVARepository _repository;
        readonly IPreDescriptivaRepository _preDescriptivaRepository;
        readonly IPreTituloRepository _preTituloRepository;
        readonly IUnitOfWork _unitOfWork;
        readonly IImportPreDescriptivasOutputPort _outputPort;

        public ImportPreDescriptivaInteractor(IPRE_DESCRIPTIVARepository repository, IPreDescriptivaRepository preDescriptivaRepository,
            IPreTituloRepository preTituloRepository,
            IUnitOfWork unitOfWork,
            IImportPreDescriptivasOutputPort outputPort) =>
            (_repository, _preDescriptivaRepository, _preTituloRepository, _unitOfWork, _outputPort) =
            (repository, preDescriptivaRepository, preTituloRepository, unitOfWork, outputPort);

        public async Task Handle()
        {
            List<PreTitulo> createPreTitulos = new();
            try
            {
                var preDescriptivas = _repository.GetAllPreDescriptivas().ToList();

                foreach (var preDescriptiva in preDescriptivas)
                {

                    var findpreDescriptiva = await _preDescriptivaRepository.GetById(preDescriptiva.DESCRIPCION_ID);
                    if (findpreDescriptiva == null)
                    {
                        var preTitulo = await _preTituloRepository.GetById(preDescriptiva.TITULO_ID);
                        if (preTitulo != null)
                        {
                            PreDescriptiva newPreDescriptiva = new PreDescriptiva
                            {
                                Id = preDescriptiva.DESCRIPCION_ID,
                                Codigo = preDescriptiva.CODIGO ?? "",
                                Descripcion = preDescriptiva.DESCRIPCION ?? "",
                                DescripcionPadreId = preDescriptiva.DESCRIPCION_FK_ID,
                                PreTituloId = preDescriptiva.TITULO_ID,
                                CodigoEmpresa = preDescriptiva.CODIGO_EMPRESA,
                                Complemento1 = preDescriptiva.EXTRA1 ?? "",
                                Complemento2 = preDescriptiva.EXTRA2 ?? "",
                                Complemento3 = preDescriptiva.EXTRA3 ?? "",
                                Complemento4 = "",
                                Complemento5 = "",
                                FechaCreacion = preDescriptiva.FECHA_INS ?? DateTime.MinValue,
                                FechaActualizacion = preDescriptiva.FECHA_UPD ?? DateTime.MinValue,
                                UsuarioActualizacion = preDescriptiva.USUARIO_UPD,
                                UsuarioCreacion = preDescriptiva.USUARIO_INS
                            };
                            _preDescriptivaRepository.CreatePreDescriptiva(newPreDescriptiva);
                            await _unitOfWork.SaveChangesAsync();

                        }

                    }
                    else
                    {
                        findpreDescriptiva.Id = preDescriptiva.DESCRIPCION_ID;
                        findpreDescriptiva.Codigo = preDescriptiva.CODIGO ?? "";
                        findpreDescriptiva.Descripcion = preDescriptiva.DESCRIPCION ?? "";
                        findpreDescriptiva.DescripcionPadreId = preDescriptiva.DESCRIPCION_FK_ID;
                        findpreDescriptiva.PreTituloId = preDescriptiva.TITULO_ID;
                        findpreDescriptiva.CodigoEmpresa = preDescriptiva.CODIGO_EMPRESA;
                        findpreDescriptiva.Complemento1 = preDescriptiva.EXTRA1 ?? "";
                        findpreDescriptiva.Complemento2 = preDescriptiva.EXTRA2 ?? "";
                        findpreDescriptiva.Complemento3 = preDescriptiva.EXTRA3 ?? "";
                        findpreDescriptiva.Complemento4 = "";
                        findpreDescriptiva.Complemento5 = "";
                        findpreDescriptiva.FechaCreacion = preDescriptiva.FECHA_INS ?? DateTime.MinValue;
                        findpreDescriptiva.FechaActualizacion = preDescriptiva.FECHA_UPD ?? DateTime.MinValue;
                        findpreDescriptiva.UsuarioActualizacion = preDescriptiva.USUARIO_UPD;
                        findpreDescriptiva.UsuarioCreacion = preDescriptiva.USUARIO_INS;
                        _preDescriptivaRepository.UpdatePreDescriptiva(findpreDescriptiva);
                        await _unitOfWork.SaveChangesAsync();
                    }



                }


                var preDescriptivasDto = _preDescriptivaRepository.GetAllPreDescriptivas().Select(p =>
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

                await _outputPort.Handle(preDescriptivasDto);


            }
            catch (Exception ex)
            {
                var message = ex.InnerException.Message;
                throw;
            }


        }
    }
}
