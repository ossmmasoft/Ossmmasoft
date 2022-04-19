namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomTmpAguinaldo
    {
        public int Id { get; set; }
        public int CodigoTipoNomina { get; set; }
        public int CodigoPeriodo { get; set; }
        public int CodigoPersona { get; set; }
        public DateOnly? FechaIngreso { get; set; }
        public int Meses { get; set; }
        public int Dias { get; set; }
        public decimal SueldoIntegral { get; set; }
        public decimal BonoVacacional { get; set; }
        public decimal Comisiones { get; set; }
        public decimal Aguinaldo { get; set; }
        public string Status { get; set; } = string.Empty;
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int CodigoEmpresa { get; set; }

        public virtual NomPeriodo CodigoPeriodoNavigation { get; set; }
        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomTiposNomina CodigoTipoNominaNavigation { get; set; }
    }
}
