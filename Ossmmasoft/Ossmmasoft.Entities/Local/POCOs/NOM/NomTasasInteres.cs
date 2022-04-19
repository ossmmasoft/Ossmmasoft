namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomTasasInteres
    {
        public int Id { get; set; }
        public string NumeroTasa { get; set; } = string.Empty;
        public int TipoTasaId { get; set; }
        public decimal Tasa { get; set; }
        public int ArticuloId { get; set; }
        public string NumeroGacetaOficial { get; set; } = string.Empty;
        public DateOnly? FechaGacetaOficial { get; set; }
        public DateOnly FechaDesde { get; set; }
        public DateOnly? FechaHasta { get; set; }
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

        public virtual NomDescriptiva TipoTasa { get; set; }
    }
}
