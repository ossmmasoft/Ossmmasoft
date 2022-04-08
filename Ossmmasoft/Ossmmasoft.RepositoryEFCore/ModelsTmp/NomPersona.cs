using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomPersona
    {
        public NomPersona()
        {
            NomAcumulados = new HashSet<NomAcumulado>();
            NomAdministrativos = new HashSet<NomAdministrativo>();
            NomAnticipoPrestaciones = new HashSet<NomAnticipoPrestacione>();
            NomAris = new HashSet<NomAri>();
            NomBecados = new HashSet<NomBecado>();
            NomCajaAhorros = new HashSet<NomCajaAhorro>();
            NomCambioDatos = new HashSet<NomCambioDato>();
            NomCargaArchivos = new HashSet<NomCargaArchivo>();
            NomComunicaciones = new HashSet<NomComunicacione>();
            NomControlHorarios = new HashSet<NomControlHorario>();
            NomDescuentoLeyTrabajadors = new HashSet<NomDescuentoLeyTrabajador>();
            NomDirecciones = new HashSet<NomDireccione>();
            NomDocumentos = new HashSet<NomDocumento>();
            NomEducacions = new HashSet<NomEducacion>();
            NomEgresos = new HashSet<NomEgreso>();
            NomEntradaSalida = new HashSet<NomEntradaSalidum>();
            NomExperienciaLaborals = new HashSet<NomExperienciaLaboral>();
            NomFamiliares = new HashSet<NomFamiliare>();
            NomHcms = new HashSet<NomHcm>();
            NomHistoricoBecados = new HashSet<NomHistoricoBecado>();
            NomHistoricoNominas = new HashSet<NomHistoricoNomina>();
            NomHorarioPersonas = new HashSet<NomHorarioPersona>();
            NomHorasExtras = new HashSet<NomHorasExtra>();
            NomMovCajaAhorros = new HashSet<NomMovCajaAhorro>();
            NomMovPrestaciones = new HashSet<NomMovPrestacione>();
            NomMovimientoNominas = new HashSet<NomMovimientoNomina>();
            NomPersonasMovControls = new HashSet<NomPersonasMovControl>();
            NomPrestamosCajaAhorros = new HashSet<NomPrestamosCajaAhorro>();
            NomPrestamosPrestaciones = new HashSet<NomPrestamosPrestacione>();
            NomPromociones = new HashSet<NomPromocione>();
            NomRegistroPermisos = new HashSet<NomRegistroPermiso>();
            NomRelacionCargos = new HashSet<NomRelacionCargo>();
            NomRetencionesAportes = new HashSet<NomRetencionesAporte>();
            NomTemporalNominas = new HashSet<NomTemporalNomina>();
            NomTmpAguinaldos = new HashSet<NomTmpAguinaldo>();
            NomVacaciones = new HashSet<NomVacacione>();
            NomVacacionesDisfrutada = new HashSet<NomVacacionesDisfrutada>();
            NomVacacionesVencida = new HashSet<NomVacacionesVencida>();
        }

        public decimal Id { get; set; }
        public decimal? Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nacionalidad { get; set; }
        public string Sexo { get; set; }
        public DateOnly? FechaNacimiento { get; set; }
        public decimal? PaisNacimientoId { get; set; }
        public decimal? EstadoNacimientoId { get; set; }
        public string NumeroGacetaNacional { get; set; }
        public DateOnly? FechaGacetaNacional { get; set; }
        public decimal? EstadoCivilId { get; set; }
        public decimal? Estatura { get; set; }
        public decimal? Peso { get; set; }
        public string ManoHabil { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public string Status { get; set; }
        public decimal? IdentificacionId { get; set; }
        public decimal? NumeroIdentificacion { get; set; }
        public string Complemento4 { get; set; }
        public string Complemento5 { get; set; }

        public virtual NomDescriptiva EstadoCivil { get; set; }
        public virtual NomDescriptiva EstadoNacimiento { get; set; }
        public virtual NomDescriptiva Identificacion { get; set; }
        public virtual NomDescriptiva PaisNacimiento { get; set; }
        public virtual ICollection<NomAcumulado> NomAcumulados { get; set; }
        public virtual ICollection<NomAdministrativo> NomAdministrativos { get; set; }
        public virtual ICollection<NomAnticipoPrestacione> NomAnticipoPrestaciones { get; set; }
        public virtual ICollection<NomAri> NomAris { get; set; }
        public virtual ICollection<NomBecado> NomBecados { get; set; }
        public virtual ICollection<NomCajaAhorro> NomCajaAhorros { get; set; }
        public virtual ICollection<NomCambioDato> NomCambioDatos { get; set; }
        public virtual ICollection<NomCargaArchivo> NomCargaArchivos { get; set; }
        public virtual ICollection<NomComunicacione> NomComunicaciones { get; set; }
        public virtual ICollection<NomControlHorario> NomControlHorarios { get; set; }
        public virtual ICollection<NomDescuentoLeyTrabajador> NomDescuentoLeyTrabajadors { get; set; }
        public virtual ICollection<NomDireccione> NomDirecciones { get; set; }
        public virtual ICollection<NomDocumento> NomDocumentos { get; set; }
        public virtual ICollection<NomEducacion> NomEducacions { get; set; }
        public virtual ICollection<NomEgreso> NomEgresos { get; set; }
        public virtual ICollection<NomEntradaSalidum> NomEntradaSalida { get; set; }
        public virtual ICollection<NomExperienciaLaboral> NomExperienciaLaborals { get; set; }
        public virtual ICollection<NomFamiliare> NomFamiliares { get; set; }
        public virtual ICollection<NomHcm> NomHcms { get; set; }
        public virtual ICollection<NomHistoricoBecado> NomHistoricoBecados { get; set; }
        public virtual ICollection<NomHistoricoNomina> NomHistoricoNominas { get; set; }
        public virtual ICollection<NomHorarioPersona> NomHorarioPersonas { get; set; }
        public virtual ICollection<NomHorasExtra> NomHorasExtras { get; set; }
        public virtual ICollection<NomMovCajaAhorro> NomMovCajaAhorros { get; set; }
        public virtual ICollection<NomMovPrestacione> NomMovPrestaciones { get; set; }
        public virtual ICollection<NomMovimientoNomina> NomMovimientoNominas { get; set; }
        public virtual ICollection<NomPersonasMovControl> NomPersonasMovControls { get; set; }
        public virtual ICollection<NomPrestamosCajaAhorro> NomPrestamosCajaAhorros { get; set; }
        public virtual ICollection<NomPrestamosPrestacione> NomPrestamosPrestaciones { get; set; }
        public virtual ICollection<NomPromocione> NomPromociones { get; set; }
        public virtual ICollection<NomRegistroPermiso> NomRegistroPermisos { get; set; }
        public virtual ICollection<NomRelacionCargo> NomRelacionCargos { get; set; }
        public virtual ICollection<NomRetencionesAporte> NomRetencionesAportes { get; set; }
        public virtual ICollection<NomTemporalNomina> NomTemporalNominas { get; set; }
        public virtual ICollection<NomTmpAguinaldo> NomTmpAguinaldos { get; set; }
        public virtual ICollection<NomVacacione> NomVacaciones { get; set; }
        public virtual ICollection<NomVacacionesDisfrutada> NomVacacionesDisfrutada { get; set; }
        public virtual ICollection<NomVacacionesVencida> NomVacacionesVencida { get; set; }
    }
}
