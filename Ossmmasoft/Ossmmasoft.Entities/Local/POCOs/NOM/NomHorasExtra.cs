namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomHorasExtra
    {
        public int Id { get; set; }
        public int? CodigoPersona { get; set; }
        public int? CodigoTipoNomina { get; set; }
        public int? CodigoPeriodo { get; set; }
        public decimal? SueldoBaseDiario { get; set; }
        public DateOnly FechaHora { get; set; }
        public DateOnly HoraDesde { get; set; }
        public DateOnly HoraHasta { get; set; }
        public decimal? HorasDiurnas { get; set; }
        public decimal? MontoHorasDiurnas { get; set; }
        public decimal? HorasNocturnas { get; set; }
        public decimal? MontoHorasNocturnas { get; set; }
        public decimal? HorasFeriadas { get; set; }
        public decimal? MontoHorasFeriadas { get; set; }
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public string Complemento4 { get; set; } = string.Empty;
        public string Complemento5 { get; set; } = string.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }

        public virtual NomPeriodo CodigoPeriodoNavigation { get; set; }
        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomTiposNomina CodigoTipoNominaNavigation { get; set; }
    }
}
