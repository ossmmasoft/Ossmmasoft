using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomPeriodo
    {
        public NomPeriodo()
        {
            CargaArchivoControls = new HashSet<CargaArchivoControl>();
            NomCajaAhorroCodigoPeriodoFinNavigations = new HashSet<NomCajaAhorro>();
            NomCajaAhorroCodigoPeriodoInicioNavigations = new HashSet<NomCajaAhorro>();
            NomEscalaAguinaldoCodigoPeriodoAguinaldoNavigations = new HashSet<NomEscalaAguinaldo>();
            NomEscalaAguinaldoCodigoPeriodoDesdeNavigations = new HashSet<NomEscalaAguinaldo>();
            NomEscalaAguinaldoCodigoPeriodoHastaNavigations = new HashSet<NomEscalaAguinaldo>();
            NomHistoricoBecados = new HashSet<NomHistoricoBecado>();
            NomHistoricoNominas = new HashSet<NomHistoricoNomina>();
            NomHorasExtras = new HashSet<NomHorasExtra>();
            NomMovMasivos = new HashSet<NomMovMasivo>();
            NomPrestamosPrestacioneCodigoPeriodo1erPagoNavigations = new HashSet<NomPrestamosPrestacione>();
            NomPrestamosPrestacioneCodigoPeriodoUltPagoNavigations = new HashSet<NomPrestamosPrestacione>();
            NomTemporalNominas = new HashSet<NomTemporalNomina>();
            NomTmpAguinaldos = new HashSet<NomTmpAguinaldo>();
            NomVacaciones = new HashSet<NomVacacione>();
            NomVacacionesDisfrutada = new HashSet<NomVacacionesDisfrutada>();
        }

        public decimal Id { get; set; }
        public decimal? CodigoTipoNomina { get; set; }
        public DateOnly? FechaNomina { get; set; }
        public decimal? Periodo { get; set; }
        public char? TipoNomina { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? UsuarioPrecierre { get; set; }
        public DateOnly? FechaPrecierre { get; set; }
        public decimal? UsuarioCierre { get; set; }
        public DateOnly? FechaCierre { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal? CodigoCuentaEmpresa { get; set; }
        public decimal? UsuarioPrenomina { get; set; }
        public DateOnly? FechaPrenomina { get; set; }
        public decimal? CodigoPresupuesto { get; set; }
        public string Descripcion { get; set; }
        public string Complemento4 { get; set; }
        public string Complemento5 { get; set; }

        public virtual PrePresupuesto CodigoPresupuestoNavigation { get; set; }
        public virtual NomTiposNomina CodigoTipoNominaNavigation { get; set; }
        public virtual ICollection<CargaArchivoControl> CargaArchivoControls { get; set; }
        public virtual ICollection<NomCajaAhorro> NomCajaAhorroCodigoPeriodoFinNavigations { get; set; }
        public virtual ICollection<NomCajaAhorro> NomCajaAhorroCodigoPeriodoInicioNavigations { get; set; }
        public virtual ICollection<NomEscalaAguinaldo> NomEscalaAguinaldoCodigoPeriodoAguinaldoNavigations { get; set; }
        public virtual ICollection<NomEscalaAguinaldo> NomEscalaAguinaldoCodigoPeriodoDesdeNavigations { get; set; }
        public virtual ICollection<NomEscalaAguinaldo> NomEscalaAguinaldoCodigoPeriodoHastaNavigations { get; set; }
        public virtual ICollection<NomHistoricoBecado> NomHistoricoBecados { get; set; }
        public virtual ICollection<NomHistoricoNomina> NomHistoricoNominas { get; set; }
        public virtual ICollection<NomHorasExtra> NomHorasExtras { get; set; }
        public virtual ICollection<NomMovMasivo> NomMovMasivos { get; set; }
        public virtual ICollection<NomPrestamosPrestacione> NomPrestamosPrestacioneCodigoPeriodo1erPagoNavigations { get; set; }
        public virtual ICollection<NomPrestamosPrestacione> NomPrestamosPrestacioneCodigoPeriodoUltPagoNavigations { get; set; }
        public virtual ICollection<NomTemporalNomina> NomTemporalNominas { get; set; }
        public virtual ICollection<NomTmpAguinaldo> NomTmpAguinaldos { get; set; }
        public virtual ICollection<NomVacacione> NomVacaciones { get; set; }
        public virtual ICollection<NomVacacionesDisfrutada> NomVacacionesDisfrutada { get; set; }
    }
}
