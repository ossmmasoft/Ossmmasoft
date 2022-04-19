namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomHistoricoBecado
    {
        public int Id { get; set; }
        public int? CodigoPeriodo { get; set; }
        public int? CodigoTipoNomina { get; set; }
        public DateOnly? FechaNomina { get; set; }
        public int? CodigoBecado { get; set; }
        public int? CodigoPersona { get; set; }
        public int? CodigoFamiliar { get; set; }
        public decimal? Monto { get; set; }
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public string Observacion { get; set; }

        public virtual NomBecado CodigoBecadoNavigation { get; set; }
        public virtual NomFamiliares CodigoFamiliarNavigation { get; set; }
        public virtual NomPeriodo CodigoPeriodoNavigation { get; set; }
        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomTiposNomina CodigoTipoNominaNavigation { get; set; }
    }
}
