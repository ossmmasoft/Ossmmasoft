namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomMoneda
    {
        public int Id { get; set; }
        public decimal? Valor { get; set; }
        public string Denominacion { get; set; } = string.Empty;
        public int? TipoMonedaId { get; set; }
        public DateOnly? FechaInicioCirculacion { get; set; }
        public DateOnly? FechaFinCirculacion { get; set; }
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

    }
}
