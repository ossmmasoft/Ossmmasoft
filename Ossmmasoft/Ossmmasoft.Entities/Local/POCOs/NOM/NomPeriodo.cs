namespace Ossmmasoft.Entities.Local.POCOs.NOM
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
            NomPrestamosPrestacioneCodigoPeriodo1erPagoNavigations = new HashSet<NomPrestamosPrestaciones>();
            NomPrestamosPrestacioneCodigoPeriodoUltPagoNavigations = new HashSet<NomPrestamosPrestaciones>();
            NomTemporalNominas = new HashSet<NomTemporalNomina>();
            NomTmpAguinaldos = new HashSet<NomTmpAguinaldo>();
            NomVacaciones = new HashSet<NomVacaciones>();
            NomVacacionesDisfrutada = new HashSet<NomVacacionesDisfrutada>();
        }

        public int Id { get; set; }
        public int CodigoTipoNomina { get; set; }
        public DateOnly? FechaNomina { get; set; }
        public int Periodo { get; set; }
        public char? TipoNomina { get; set; }
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public string Complemento4 { get; set; } = string.Empty;
        public string Complemento5 { get; set; } = string.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? UsuarioPrecierre { get; set; }
        public DateOnly? FechaPrecierre { get; set; }
        public int? UsuarioCierre { get; set; }
        public DateOnly? FechaCierre { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? CodigoCuentaEmpresa { get; set; }
        public decimal? UsuarioPrenomina { get; set; }
        public DateOnly? FechaPrenomina { get; set; }
        public int? CodigoPresupuesto { get; set; }
        public string Descripcion { get; set; } = string.Empty;


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
        public virtual ICollection<NomPrestamosPrestaciones> NomPrestamosPrestacioneCodigoPeriodo1erPagoNavigations { get; set; }
        public virtual ICollection<NomPrestamosPrestaciones> NomPrestamosPrestacioneCodigoPeriodoUltPagoNavigations { get; set; }
        public virtual ICollection<NomTemporalNomina> NomTemporalNominas { get; set; }
        public virtual ICollection<NomTmpAguinaldo> NomTmpAguinaldos { get; set; }
        public virtual ICollection<NomVacaciones> NomVacaciones { get; set; }
        public virtual ICollection<NomVacacionesDisfrutada> NomVacacionesDisfrutada { get; set; }
    }
}
