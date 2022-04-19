namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomDetalleLiquidaciones
    {
        public int? Id { get; set; }
        public int? CodigoEgreso { get; set; }
        public char? TipoDetalle { get; set; }
        public int? ConceptoId { get; set; }
        public string ComplementoConcepto { get; set; } = String.Empty;
        public int? Dias { get; set; }
        public decimal Spd { get; set; }
        public decimal Monto { get; set; }
        public string Observacion { get; set; } = String.Empty;
        public string Complemento1 { get; set; } = String.Empty;
        public string Complemento2 { get; set; } = String.Empty;
        public string Complemento3 { get; set; } = String.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int CodigoEmpresa { get; set; }

        public virtual NomEgreso CodigoEgresoNavigation { get; set; }
        public virtual NomDescriptiva Concepto { get; set; }
    }
}
