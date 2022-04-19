namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreIngreso
    {
        public int Id { get; set; }
        public int? Año { get; set; }
        public int? Escenario { get; set; }
        public int? CodigoPuc { get; set; }
        public decimal? Monto { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? CodigoPresupuesto { get; set; }

        public virtual SisEmpresa CodigoEmpresaNavigation { get; set; }
        public virtual PrePresupuesto CodigoPresupuestoNavigation { get; set; }
        public virtual PrePlanUnicoCuenta CodigoPucNavigation { get; set; }
    }
}
