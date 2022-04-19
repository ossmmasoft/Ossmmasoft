namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PrePucModificacion
    {
        public int Id { get; set; }
        public int? CodigoModificacion { get; set; }
        public decimal CodigoSaldo { get; set; }
        public string FinanciadoId { get; set; } = String.Empty;
        public int? CodigoFinanciado { get; set; }
        public int? CodigoIcp { get; set; }
        public int? CodigoPuc { get; set; }
        public decimal Monto { get; set; }
        public string DePara { get; set; } = String.Empty;
        public decimal? Complemento1 { get; set; }
        public string Complemento2 { get; set; } = String.Empty;
        public string Complemento3 { get; set; } = String.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? CodigoPucSolModificacion { get; set; }
        public decimal MontoAnulado { get; set; }
        public int? CodigoPresupuesto { get; set; }

        public virtual SisEmpresa CodigoEmpresaNavigation { get; set; }
        public virtual PreIndiceCatPrg CodigoIcpNavigation { get; set; }
        public virtual PreModificacion CodigoModificacionNavigation { get; set; }
        public virtual PrePresupuesto CodigoPresupuestoNavigation { get; set; }
        public virtual PrePlanUnicoCuenta CodigoPucNavigation { get; set; }
        public virtual PrePucSolModificacion CodigoPucSolModificacionNavigation { get; set; }
    }
}
