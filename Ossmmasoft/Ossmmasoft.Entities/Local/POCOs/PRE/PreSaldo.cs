namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreSaldo
    {
        public int Id { get; set; }
        public int? Año { get; set; }
        public int? CodigoIcp { get; set; }
        public int? CodigoPuc { get; set; }
        public int? FinanciadoId { get; set; }
        public int? CodigoFinanciado { get; set; }
        public decimal Asignacion { get; set; }
        public decimal Bloqueado { get; set; }
        public decimal Modificado { get; set; }
        public decimal Comprometido { get; set; }
        public decimal Causado { get; set; }
        public decimal Pagado { get; set; }
        public decimal Ajustado { get; set; }
        public string Complemento1 { get; set; } = String.Empty;
        public string Complemeto2 { get; set; } = String.Empty;
        public string Complemeto3 { get; set; } = String.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? CodigoPresupuesto { get; set; }
        public decimal Presupuestado { get; set; }

        public virtual SisEmpresa CodigoEmpresaNavigation { get; set; }
        public virtual PreIndiceCatPrg CodigoIcpNavigation { get; set; }
        public virtual PrePlanUnicoCuenta CodigoPucNavigation { get; set; }
        public virtual PreDescriptiva Financiado { get; set; }
        public virtual PrePresupuesto PresupuestadoNavigation { get; set; }
    }
}
