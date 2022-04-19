namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomEscalaHoraExtra
    {
        public int Id { get; set; }
        public int? CodigoTipoNomina { get; set; }
        public int? DiaHora { get; set; }
        public DateOnly HoraDesde { get; set; }
        public DateOnly HoraHasta { get; set; }
        public char? TipoHora { get; set; }
        public DateOnly? FechaFeriado { get; set; }
        public string TipoSueldo { get; set; } = string.Empty;
        public decimal? PorHora { get; set; }
        public decimal? MontoHora { get; set; }
        public decimal? MontoMax { get; set; }
        public int? PrecisionDecimal { get; set; }
        public DateOnly? FechaDesde { get; set; }
        public DateOnly? FechaHasta { get; set; }
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public decimal? HorasDia { get; set; }
        public decimal? PorPrevioCalculo { get; set; }

        public virtual NomTiposNomina CodigoTipoNominaNavigation { get; set; }
    }
}
