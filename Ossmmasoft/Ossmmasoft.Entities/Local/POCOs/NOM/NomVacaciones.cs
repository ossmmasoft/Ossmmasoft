namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomVacaciones
    {
        public int Id { get; set; }
        public int CodigoTipoNomina { get; set; }
        public int CodigoPeriodo { get; set; }
        public int CodigoPersona { get; set; }
        public string PeriodoAño { get; set; } = string.Empty;
        public DateOnly? FechaDesde { get; set; }
        public DateOnly? FechaHasta { get; set; }
        public DateOnly? FechaSalida { get; set; }
        public DateOnly? FechaEntrada { get; set; }
        public int DiasHabiles { get; set; }
        public int FrecuenciaPagoId { get; set; }
        public int CantidadFrecuenciaPago { get; set; }
        public char? CobroAdelantoSueldo { get; set; }
        public decimal BonoVacacional { get; set; }
        public char? Status { get; set; }
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public string Complemento4 { get; set; } = string.Empty;
        public string Complemento5 { get; set; } = string.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int CodigoEmpresa { get; set; }

        public virtual NomPeriodo CodigoPeriodoNavigation { get; set; }
        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomTiposNomina CodigoTipoNominaNavigation { get; set; }
        public virtual NomDescriptiva FrecuenciaPago { get; set; }
    }
}
