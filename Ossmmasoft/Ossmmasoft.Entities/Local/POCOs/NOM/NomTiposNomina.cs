namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomTiposNomina
    {
        public NomTiposNomina()
        {
            CargaArchivoControls = new HashSet<CargaArchivoControl>();
            NomBecados = new HashSet<NomBecado>();
            NomConceptos = new HashSet<NomConcepto>();
            NomControlHorarios = new HashSet<NomControlHorario>();
            NomControlProcesos = new HashSet<NomControlProceso>();
            NomDescuentoLeys = new HashSet<NomDescuentoLey>();
            NomEscalaAguinaldos = new HashSet<NomEscalaAguinaldo>();
            NomEscalaHoraExtras = new HashSet<NomEscalaHoraExtra>();
            NomEscalaUtilEscolars = new HashSet<NomEscalaUtilEscolar>();
            NomHistoricoBecados = new HashSet<NomHistoricoBecado>();
            NomHistoricoNominas = new HashSet<NomHistoricoNomina>();
            NomHorarios = new HashSet<NomHorario>();
            NomHorasExtras = new HashSet<NomHorasExtra>();
            NomMovMasivos = new HashSet<NomMovMasivo>();
            NomMovimientoNominas = new HashSet<NomMovimientoNomina>();
            NomPeriodos = new HashSet<NomPeriodo>();
            NomPrestamosCajaAhorros = new HashSet<NomPrestamosCajaAhorro>();
            NomPrestamosPrestaciones = new HashSet<NomPrestamosPrestaciones>();
            NomRelacionCargos = new HashSet<NomRelacionCargo>();
            NomTemporalNominas = new HashSet<NomTemporalNomina>();
            NomTmpAguinaldos = new HashSet<NomTmpAguinaldo>();
            NomVacaciones = new HashSet<NomVacaciones>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public string SiglasTipoNomina { get; set; } = string.Empty;
        public int FrecuenciaPagoId { get; set; }
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento4 { get; set; } = string.Empty;
        public string Complemento5 { get; set; } = string.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int CodigoEmpresa { get; set; }
        public decimal SueldoMinimo { get; set; }
        public int? CodigoPresupuestoActual { get; set; }

        public virtual PrePresupuesto CodigoPresupuestoActualNavigation { get; set; }
        public virtual NomDescriptiva FrecuenciaPago { get; set; }
        public virtual ICollection<CargaArchivoControl> CargaArchivoControls { get; set; }
        public virtual ICollection<NomBecado> NomBecados { get; set; }
        public virtual ICollection<NomConcepto> NomConceptos { get; set; }
        public virtual ICollection<NomControlHorario> NomControlHorarios { get; set; }
        public virtual ICollection<NomControlProceso> NomControlProcesos { get; set; }
        public virtual ICollection<NomDescuentoLey> NomDescuentoLeys { get; set; }
        public virtual ICollection<NomEscalaAguinaldo> NomEscalaAguinaldos { get; set; }
        public virtual ICollection<NomEscalaHoraExtra> NomEscalaHoraExtras { get; set; }
        public virtual ICollection<NomEscalaUtilEscolar> NomEscalaUtilEscolars { get; set; }
        public virtual ICollection<NomHistoricoBecado> NomHistoricoBecados { get; set; }
        public virtual ICollection<NomHistoricoNomina> NomHistoricoNominas { get; set; }
        public virtual ICollection<NomHorario> NomHorarios { get; set; }
        public virtual ICollection<NomHorasExtra> NomHorasExtras { get; set; }
        public virtual ICollection<NomMovMasivo> NomMovMasivos { get; set; }
        public virtual ICollection<NomMovimientoNomina> NomMovimientoNominas { get; set; }
        public virtual ICollection<NomPeriodo> NomPeriodos { get; set; }
        public virtual ICollection<NomPrestamosCajaAhorro> NomPrestamosCajaAhorros { get; set; }
        public virtual ICollection<NomPrestamosPrestaciones> NomPrestamosPrestaciones { get; set; }
        public virtual ICollection<NomRelacionCargo> NomRelacionCargos { get; set; }
        public virtual ICollection<NomTemporalNomina> NomTemporalNominas { get; set; }
        public virtual ICollection<NomTmpAguinaldo> NomTmpAguinaldos { get; set; }
        public virtual ICollection<NomVacaciones> NomVacaciones { get; set; }
    }
}
