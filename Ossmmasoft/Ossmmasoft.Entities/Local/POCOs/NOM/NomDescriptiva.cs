namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomDescriptiva
    {
        public NomDescriptiva()
        {
            CargaArchivoControls = new HashSet<CargaArchivoControl>();
            NomAcumulados = new HashSet<NomAcumulado>();
            NomAdministrativoBancos = new HashSet<NomAdministrativo>();
            NomAdministrativoCargos = new HashSet<NomAdministrativo>();
            NomAdministrativoTipoCuenta = new HashSet<NomAdministrativo>();
            NomAnticipoPrestaciones = new HashSet<NomAnticipoPrestaciones>();
            NomCajaAhorros = new HashSet<NomCajaAhorro>();
            NomComunicaciones = new HashSet<NomComunicaciones>();
            NomConceptoFrecuencia = new HashSet<NomConcepto>();
            NomConceptoModulos = new HashSet<NomConcepto>();
            NomDescuentoLeyCodigoDescuentoLeys = new HashSet<NomDescuentoLey>();
            NomDescuentoLeyLeys = new HashSet<NomDescuentoLey>();
            NomDireccioneCiudads = new HashSet<NomDirecciones>();
            NomDireccioneDireccions = new HashSet<NomDirecciones>();
            NomDireccioneEstados = new HashSet<NomDirecciones>();
            NomDireccioneManzanas = new HashSet<NomDirecciones>();
            NomDireccioneMunicipios = new HashSet<NomDirecciones>();
            NomDireccionePais = new HashSet<NomDirecciones>();
            NomDireccioneParcelas = new HashSet<NomDirecciones>();
            NomDireccioneParroquia = new HashSet<NomDirecciones>();
            NomDireccioneSectors = new HashSet<NomDirecciones>();
            NomDireccioneTenencia = new HashSet<NomDirecciones>();
            NomDireccioneTipoNivels = new HashSet<NomDirecciones>();
            NomDireccioneTipoVivienda = new HashSet<NomDirecciones>();
            NomDireccioneUrbanizacions = new HashSet<NomDirecciones>();
            NomDireccioneVialidadNavigations = new HashSet<NomDirecciones>();
            NomDireccioneViviendaNavigations = new HashSet<NomDirecciones>();
            NomDocumentoGrados = new HashSet<NomDocumento>();
            NomDocumentoTipoDocumentos = new HashSet<NomDocumento>();
            NomDocumentoTipoGrados = new HashSet<NomDocumento>();
            NomEducacionMencionEspecialidads = new HashSet<NomEducacion>();
            NomEducacionNivels = new HashSet<NomEducacion>();
            NomEducacionProfesions = new HashSet<NomEducacion>();
            NomEducacionTitulos = new HashSet<NomEducacion>();
            NomEgresos = new HashSet<NomEgreso>();
            NomEntradaSalida = new HashSet<NomEntradaSalida>();
            NomEscalaHcmAseguradoras = new HashSet<NomEscalaHcm>();
            NomEscalaHcmParientes = new HashSet<NomEscalaHcm>();
            NomEscalaJuguetes = new HashSet<NomEscalaJuguete>();
            NomEscalaUtilEscolars = new HashSet<NomEscalaUtilEscolar>();
            NomExperienciaLaborals = new HashSet<NomExperienciaLaboral>();
            NomFamiliares = new HashSet<NomFamiliares>();
            NomHcms = new HashSet<NomHcm>();
            NomHistoricoNominas = new HashSet<NomHistoricoNomina>();
            NomMovCajaAhorros = new HashSet<NomMovCajaAhorro>();
            NomMovMasivos = new HashSet<NomMovMasivo>();
            NomMovPrestaciones = new HashSet<NomMovPrestaciones>();
            NomMovimientoNominas = new HashSet<NomMovimientoNomina>();
            NomPersonaEstadoCivils = new HashSet<NomPersona>();
            NomPersonaEstadoNacimientos = new HashSet<NomPersona>();
            NomPersonaIdentificacions = new HashSet<NomPersona>();
            NomPersonaPaisNacimientos = new HashSet<NomPersona>();
            NomPrestamosCajaAhorroCodigoPeriodo1erPagoNavigations = new HashSet<NomPrestamosCajaAhorro>();
            NomPrestamosCajaAhorroCodigoPeriodoUltPagoNavigations = new HashSet<NomPrestamosCajaAhorro>();
            NomPrestamosCajaAhorroTipoPrestamos = new HashSet<NomPrestamosCajaAhorro>();
            NomPrestamosPrestacioneFrecuenciaPagos = new HashSet<NomPrestamosPrestaciones>();
            NomPrestamosPrestacioneTipoInteres = new HashSet<NomPrestamosPrestaciones>();
            NomPrestamosPrestacioneTipoPrestamos = new HashSet<NomPrestamosPrestaciones>();
            NomRegistroPermisos = new HashSet<NomRegistroPermiso>();
            NomTasasInteres = new HashSet<NomTasasInteres>();
            NomTemporalNominas = new HashSet<NomTemporalNomina>();
            NomTiposNominas = new HashSet<NomTiposNomina>();
            NomVacaciones = new HashSet<NomVacaciones>();
            NomVacacionesContratos = new HashSet<NomVacacionesContrato>();
        }

        public int Id { get; set; }
        public int DescripcionPadreId { get; set; }
        public int NomTituloId { get; set; }
        public string Descripcion { get; set; } = String.Empty;
        public string Codigo { get; set; } = String.Empty;
        public string Complemento1 { get; set; } = String.Empty;
        public string Complemento2 { get; set; } = String.Empty;
        public string Complemento3 { get; set; } = String.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int CodigoEmpresa { get; set; }

        public virtual NomTitulo NomTitulo { get; set; }
        public virtual ICollection<CargaArchivoControl> CargaArchivoControls { get; set; }
        public virtual ICollection<NomAcumulado> NomAcumulados { get; set; }
        public virtual ICollection<NomAdministrativo> NomAdministrativoBancos { get; set; }
        public virtual ICollection<NomAdministrativo> NomAdministrativoCargos { get; set; }
        public virtual ICollection<NomAdministrativo> NomAdministrativoTipoCuenta { get; set; }
        public virtual ICollection<NomAnticipoPrestaciones> NomAnticipoPrestaciones { get; set; }
        public virtual ICollection<NomCajaAhorro> NomCajaAhorros { get; set; }
        public virtual ICollection<NomComunicaciones> NomComunicaciones { get; set; }
        public virtual ICollection<NomConcepto> NomConceptoFrecuencia { get; set; }
        public virtual ICollection<NomConcepto> NomConceptoModulos { get; set; }
        public virtual ICollection<NomDescuentoLey> NomDescuentoLeyCodigoDescuentoLeys { get; set; }
        public virtual ICollection<NomDescuentoLey> NomDescuentoLeyLeys { get; set; }
        public virtual ICollection<NomDirecciones> NomDireccioneCiudads { get; set; }
        public virtual ICollection<NomDirecciones> NomDireccioneDireccions { get; set; }
        public virtual ICollection<NomDirecciones> NomDireccioneEstados { get; set; }
        public virtual ICollection<NomDirecciones> NomDireccioneManzanas { get; set; }
        public virtual ICollection<NomDirecciones> NomDireccioneMunicipios { get; set; }
        public virtual ICollection<NomDirecciones> NomDireccionePais { get; set; }
        public virtual ICollection<NomDirecciones> NomDireccioneParcelas { get; set; }
        public virtual ICollection<NomDirecciones> NomDireccioneParroquia { get; set; }
        public virtual ICollection<NomDirecciones> NomDireccioneSectors { get; set; }
        public virtual ICollection<NomDirecciones> NomDireccioneTenencia { get; set; }
        public virtual ICollection<NomDirecciones> NomDireccioneTipoNivels { get; set; }
        public virtual ICollection<NomDirecciones> NomDireccioneTipoVivienda { get; set; }
        public virtual ICollection<NomDirecciones> NomDireccioneUrbanizacions { get; set; }
        public virtual ICollection<NomDirecciones> NomDireccioneVialidadNavigations { get; set; }
        public virtual ICollection<NomDirecciones> NomDireccioneViviendaNavigations { get; set; }
        public virtual ICollection<NomDocumento> NomDocumentoGrados { get; set; }
        public virtual ICollection<NomDocumento> NomDocumentoTipoDocumentos { get; set; }
        public virtual ICollection<NomDocumento> NomDocumentoTipoGrados { get; set; }
        public virtual ICollection<NomEducacion> NomEducacionMencionEspecialidads { get; set; }
        public virtual ICollection<NomEducacion> NomEducacionNivels { get; set; }
        public virtual ICollection<NomEducacion> NomEducacionProfesions { get; set; }
        public virtual ICollection<NomEducacion> NomEducacionTitulos { get; set; }
        public virtual ICollection<NomEgreso> NomEgresos { get; set; }
        public virtual ICollection<NomEntradaSalida> NomEntradaSalida { get; set; }
        public virtual ICollection<NomEscalaHcm> NomEscalaHcmAseguradoras { get; set; }
        public virtual ICollection<NomEscalaHcm> NomEscalaHcmParientes { get; set; }
        public virtual ICollection<NomEscalaJuguete> NomEscalaJuguetes { get; set; }
        public virtual ICollection<NomEscalaUtilEscolar> NomEscalaUtilEscolars { get; set; }
        public virtual ICollection<NomExperienciaLaboral> NomExperienciaLaborals { get; set; }
        public virtual ICollection<NomFamiliares> NomFamiliares { get; set; }
        public virtual ICollection<NomHcm> NomHcms { get; set; }
        public virtual ICollection<NomHistoricoNomina> NomHistoricoNominas { get; set; }
        public virtual ICollection<NomMovCajaAhorro> NomMovCajaAhorros { get; set; }
        public virtual ICollection<NomMovMasivo> NomMovMasivos { get; set; }
        public virtual ICollection<NomMovPrestaciones> NomMovPrestaciones { get; set; }
        public virtual ICollection<NomMovimientoNomina> NomMovimientoNominas { get; set; }
        public virtual ICollection<NomPersona> NomPersonaEstadoCivils { get; set; }
        public virtual ICollection<NomPersona> NomPersonaEstadoNacimientos { get; set; }
        public virtual ICollection<NomPersona> NomPersonaIdentificacions { get; set; }
        public virtual ICollection<NomPersona> NomPersonaPaisNacimientos { get; set; }
        public virtual ICollection<NomPrestamosCajaAhorro> NomPrestamosCajaAhorroCodigoPeriodo1erPagoNavigations { get; set; }
        public virtual ICollection<NomPrestamosCajaAhorro> NomPrestamosCajaAhorroCodigoPeriodoUltPagoNavigations { get; set; }
        public virtual ICollection<NomPrestamosCajaAhorro> NomPrestamosCajaAhorroTipoPrestamos { get; set; }
        public virtual ICollection<NomPrestamosPrestaciones> NomPrestamosPrestacioneFrecuenciaPagos { get; set; }
        public virtual ICollection<NomPrestamosPrestaciones> NomPrestamosPrestacioneTipoInteres { get; set; }
        public virtual ICollection<NomPrestamosPrestaciones> NomPrestamosPrestacioneTipoPrestamos { get; set; }
        public virtual ICollection<NomRegistroPermiso> NomRegistroPermisos { get; set; }
        public virtual ICollection<NomTasasInteres> NomTasasInteres { get; set; }
        public virtual ICollection<NomTemporalNomina> NomTemporalNominas { get; set; }
        public virtual ICollection<NomTiposNomina> NomTiposNominas { get; set; }
        public virtual ICollection<NomVacaciones> NomVacaciones { get; set; }
        public virtual ICollection<NomVacacionesContrato> NomVacacionesContratos { get; set; }
    }
}
