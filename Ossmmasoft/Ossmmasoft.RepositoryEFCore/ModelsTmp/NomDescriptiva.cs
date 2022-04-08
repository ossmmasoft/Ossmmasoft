using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
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
            NomAnticipoPrestaciones = new HashSet<NomAnticipoPrestacione>();
            NomCajaAhorros = new HashSet<NomCajaAhorro>();
            NomComunicaciones = new HashSet<NomComunicacione>();
            NomConceptoFrecuencia = new HashSet<NomConcepto>();
            NomConceptoModulos = new HashSet<NomConcepto>();
            NomDescuentoLeyCodigoDescuentoLeys = new HashSet<NomDescuentoLey>();
            NomDescuentoLeyLeys = new HashSet<NomDescuentoLey>();
            NomDireccioneCiudads = new HashSet<NomDireccione>();
            NomDireccioneDireccions = new HashSet<NomDireccione>();
            NomDireccioneEstados = new HashSet<NomDireccione>();
            NomDireccioneManzanas = new HashSet<NomDireccione>();
            NomDireccioneMunicipios = new HashSet<NomDireccione>();
            NomDireccionePais = new HashSet<NomDireccione>();
            NomDireccioneParcelas = new HashSet<NomDireccione>();
            NomDireccioneParroquia = new HashSet<NomDireccione>();
            NomDireccioneSectors = new HashSet<NomDireccione>();
            NomDireccioneTenencia = new HashSet<NomDireccione>();
            NomDireccioneTipoNivels = new HashSet<NomDireccione>();
            NomDireccioneTipoVivienda = new HashSet<NomDireccione>();
            NomDireccioneUrbanizacions = new HashSet<NomDireccione>();
            NomDireccioneVialidadNavigations = new HashSet<NomDireccione>();
            NomDireccioneViviendaNavigations = new HashSet<NomDireccione>();
            NomDocumentoGrados = new HashSet<NomDocumento>();
            NomDocumentoTipoDocumentos = new HashSet<NomDocumento>();
            NomDocumentoTipoGrados = new HashSet<NomDocumento>();
            NomEducacionMencionEspecialidads = new HashSet<NomEducacion>();
            NomEducacionNivels = new HashSet<NomEducacion>();
            NomEducacionProfesions = new HashSet<NomEducacion>();
            NomEducacionTitulos = new HashSet<NomEducacion>();
            NomEgresos = new HashSet<NomEgreso>();
            NomEntradaSalida = new HashSet<NomEntradaSalidum>();
            NomEscalaHcmAseguradoras = new HashSet<NomEscalaHcm>();
            NomEscalaHcmParientes = new HashSet<NomEscalaHcm>();
            NomEscalaJuguetes = new HashSet<NomEscalaJuguete>();
            NomEscalaUtilEscolars = new HashSet<NomEscalaUtilEscolar>();
            NomExperienciaLaborals = new HashSet<NomExperienciaLaboral>();
            NomFamiliares = new HashSet<NomFamiliare>();
            NomHcms = new HashSet<NomHcm>();
            NomHistoricoNominas = new HashSet<NomHistoricoNomina>();
            NomMovCajaAhorros = new HashSet<NomMovCajaAhorro>();
            NomMovMasivos = new HashSet<NomMovMasivo>();
            NomMovPrestaciones = new HashSet<NomMovPrestacione>();
            NomMovimientoNominas = new HashSet<NomMovimientoNomina>();
            NomPersonaEstadoCivils = new HashSet<NomPersona>();
            NomPersonaEstadoNacimientos = new HashSet<NomPersona>();
            NomPersonaIdentificacions = new HashSet<NomPersona>();
            NomPersonaPaisNacimientos = new HashSet<NomPersona>();
            NomPrestamosCajaAhorroCodigoPeriodo1erPagoNavigations = new HashSet<NomPrestamosCajaAhorro>();
            NomPrestamosCajaAhorroCodigoPeriodoUltPagoNavigations = new HashSet<NomPrestamosCajaAhorro>();
            NomPrestamosCajaAhorroTipoPrestamos = new HashSet<NomPrestamosCajaAhorro>();
            NomPrestamosPrestacioneFrecuenciaPagos = new HashSet<NomPrestamosPrestacione>();
            NomPrestamosPrestacioneTipoInteres = new HashSet<NomPrestamosPrestacione>();
            NomPrestamosPrestacioneTipoPrestamos = new HashSet<NomPrestamosPrestacione>();
            NomRegistroPermisos = new HashSet<NomRegistroPermiso>();
            NomTasasInteres = new HashSet<NomTasasIntere>();
            NomTemporalNominas = new HashSet<NomTemporalNomina>();
            NomTiposNominas = new HashSet<NomTiposNomina>();
            NomVacaciones = new HashSet<NomVacacione>();
            NomVacacionesContratos = new HashSet<NomVacacionesContrato>();
        }

        public decimal Id { get; set; }
        public decimal? DescripcionPadreId { get; set; }
        public decimal? NomTituloId { get; set; }
        public string Descripcion { get; set; }
        public string Codigo { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }

        public virtual NomTitulo NomTitulo { get; set; }
        public virtual ICollection<CargaArchivoControl> CargaArchivoControls { get; set; }
        public virtual ICollection<NomAcumulado> NomAcumulados { get; set; }
        public virtual ICollection<NomAdministrativo> NomAdministrativoBancos { get; set; }
        public virtual ICollection<NomAdministrativo> NomAdministrativoCargos { get; set; }
        public virtual ICollection<NomAdministrativo> NomAdministrativoTipoCuenta { get; set; }
        public virtual ICollection<NomAnticipoPrestacione> NomAnticipoPrestaciones { get; set; }
        public virtual ICollection<NomCajaAhorro> NomCajaAhorros { get; set; }
        public virtual ICollection<NomComunicacione> NomComunicaciones { get; set; }
        public virtual ICollection<NomConcepto> NomConceptoFrecuencia { get; set; }
        public virtual ICollection<NomConcepto> NomConceptoModulos { get; set; }
        public virtual ICollection<NomDescuentoLey> NomDescuentoLeyCodigoDescuentoLeys { get; set; }
        public virtual ICollection<NomDescuentoLey> NomDescuentoLeyLeys { get; set; }
        public virtual ICollection<NomDireccione> NomDireccioneCiudads { get; set; }
        public virtual ICollection<NomDireccione> NomDireccioneDireccions { get; set; }
        public virtual ICollection<NomDireccione> NomDireccioneEstados { get; set; }
        public virtual ICollection<NomDireccione> NomDireccioneManzanas { get; set; }
        public virtual ICollection<NomDireccione> NomDireccioneMunicipios { get; set; }
        public virtual ICollection<NomDireccione> NomDireccionePais { get; set; }
        public virtual ICollection<NomDireccione> NomDireccioneParcelas { get; set; }
        public virtual ICollection<NomDireccione> NomDireccioneParroquia { get; set; }
        public virtual ICollection<NomDireccione> NomDireccioneSectors { get; set; }
        public virtual ICollection<NomDireccione> NomDireccioneTenencia { get; set; }
        public virtual ICollection<NomDireccione> NomDireccioneTipoNivels { get; set; }
        public virtual ICollection<NomDireccione> NomDireccioneTipoVivienda { get; set; }
        public virtual ICollection<NomDireccione> NomDireccioneUrbanizacions { get; set; }
        public virtual ICollection<NomDireccione> NomDireccioneVialidadNavigations { get; set; }
        public virtual ICollection<NomDireccione> NomDireccioneViviendaNavigations { get; set; }
        public virtual ICollection<NomDocumento> NomDocumentoGrados { get; set; }
        public virtual ICollection<NomDocumento> NomDocumentoTipoDocumentos { get; set; }
        public virtual ICollection<NomDocumento> NomDocumentoTipoGrados { get; set; }
        public virtual ICollection<NomEducacion> NomEducacionMencionEspecialidads { get; set; }
        public virtual ICollection<NomEducacion> NomEducacionNivels { get; set; }
        public virtual ICollection<NomEducacion> NomEducacionProfesions { get; set; }
        public virtual ICollection<NomEducacion> NomEducacionTitulos { get; set; }
        public virtual ICollection<NomEgreso> NomEgresos { get; set; }
        public virtual ICollection<NomEntradaSalidum> NomEntradaSalida { get; set; }
        public virtual ICollection<NomEscalaHcm> NomEscalaHcmAseguradoras { get; set; }
        public virtual ICollection<NomEscalaHcm> NomEscalaHcmParientes { get; set; }
        public virtual ICollection<NomEscalaJuguete> NomEscalaJuguetes { get; set; }
        public virtual ICollection<NomEscalaUtilEscolar> NomEscalaUtilEscolars { get; set; }
        public virtual ICollection<NomExperienciaLaboral> NomExperienciaLaborals { get; set; }
        public virtual ICollection<NomFamiliare> NomFamiliares { get; set; }
        public virtual ICollection<NomHcm> NomHcms { get; set; }
        public virtual ICollection<NomHistoricoNomina> NomHistoricoNominas { get; set; }
        public virtual ICollection<NomMovCajaAhorro> NomMovCajaAhorros { get; set; }
        public virtual ICollection<NomMovMasivo> NomMovMasivos { get; set; }
        public virtual ICollection<NomMovPrestacione> NomMovPrestaciones { get; set; }
        public virtual ICollection<NomMovimientoNomina> NomMovimientoNominas { get; set; }
        public virtual ICollection<NomPersona> NomPersonaEstadoCivils { get; set; }
        public virtual ICollection<NomPersona> NomPersonaEstadoNacimientos { get; set; }
        public virtual ICollection<NomPersona> NomPersonaIdentificacions { get; set; }
        public virtual ICollection<NomPersona> NomPersonaPaisNacimientos { get; set; }
        public virtual ICollection<NomPrestamosCajaAhorro> NomPrestamosCajaAhorroCodigoPeriodo1erPagoNavigations { get; set; }
        public virtual ICollection<NomPrestamosCajaAhorro> NomPrestamosCajaAhorroCodigoPeriodoUltPagoNavigations { get; set; }
        public virtual ICollection<NomPrestamosCajaAhorro> NomPrestamosCajaAhorroTipoPrestamos { get; set; }
        public virtual ICollection<NomPrestamosPrestacione> NomPrestamosPrestacioneFrecuenciaPagos { get; set; }
        public virtual ICollection<NomPrestamosPrestacione> NomPrestamosPrestacioneTipoInteres { get; set; }
        public virtual ICollection<NomPrestamosPrestacione> NomPrestamosPrestacioneTipoPrestamos { get; set; }
        public virtual ICollection<NomRegistroPermiso> NomRegistroPermisos { get; set; }
        public virtual ICollection<NomTasasIntere> NomTasasInteres { get; set; }
        public virtual ICollection<NomTemporalNomina> NomTemporalNominas { get; set; }
        public virtual ICollection<NomTiposNomina> NomTiposNominas { get; set; }
        public virtual ICollection<NomVacacione> NomVacaciones { get; set; }
        public virtual ICollection<NomVacacionesContrato> NomVacacionesContratos { get; set; }
    }
}
