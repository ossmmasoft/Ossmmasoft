namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreTransferencia
    {
        public int Id { get; set; }
        public int? CodigoPuc { get; set; }
        public int? CodigoIcp { get; set; }
        public string Denominacion { get; set; } = String.Empty;
        public int? TipoMontoId { get; set; }
        public decimal? Monto { get; set; }
        public string Complemeto1 { get; set; } = String.Empty;
        public string Complemeto2 { get; set; } = String.Empty;
        public string Complemeto3 { get; set; } = String.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? Año { get; set; }
        public int? CodigoPresupuesto { get; set; }

        public virtual SisEmpresa CodigoEmpresaNavigation { get; set; }
        public virtual PreIndiceCatPrg CodigoIcpNavigation { get; set; }
        public virtual PrePresupuesto CodigoPresupuestoNavigation { get; set; }
        public virtual PrePlanUnicoCuenta CodigoPucNavigation { get; set; }
        public virtual PreDescriptiva TipoMonto { get; set; }
    }
}
