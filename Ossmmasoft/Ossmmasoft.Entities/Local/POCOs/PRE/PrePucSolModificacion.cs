namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PrePucSolModificacion
    {
        public PrePucSolModificacion()
        {
            PrePucModificacions = new HashSet<PrePucModificacion>();
        }

        public int Id { get; set; }
        public int? CodigoSolModificacion { get; set; }
        public decimal CodigoSaldo { get; set; }
        public string FinanciadoId { get; set; }
        public decimal? CodigoFinanciado { get; set; }
        public int? CodigoIcp { get; set; }
        public int? CodigoPuc { get; set; }
        public decimal Monto { get; set; }
        public string DePara { get; set; }
        public decimal? Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public decimal MontoModificado { get; set; }
        public decimal MontoAnulado { get; set; }
        public int? CodigoPresupuesto { get; set; }

        public virtual SisEmpresa CodigoEmpresaNavigation { get; set; }
        public virtual PreIndiceCatPrg CodigoIcpNavigation { get; set; }
        public virtual PrePresupuesto CodigoPresupuestoNavigation { get; set; }
        public virtual PrePlanUnicoCuenta CodigoPucNavigation { get; set; }
        public virtual PreSolModificacion CodigoSolModificacionNavigation { get; set; }
        public virtual ICollection<PrePucModificacion> PrePucModificacions { get; set; }
    }
}
