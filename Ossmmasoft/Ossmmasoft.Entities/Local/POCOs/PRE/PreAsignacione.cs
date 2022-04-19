namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreAsignacione
    {
        public int Id { get; set; }
        public int? Año { get; set; }
        public int? Escenario { get; set; }
        public int? CodigoIcp { get; set; }
        public int? CodigoPuc { get; set; }
        public decimal Ordinario { get; set; }
        public decimal? Coordinado { get; set; }
        public decimal? Laee { get; set; }
        public decimal? Fides { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? CodigoPresupuesto { get; set; }
        public decimal Presupuestado { get; set; }

        public virtual SisEmpresa CodigoEmpresaNavigation { get; set; }
        public virtual PreIndiceCatPrg CodigoIcpNavigation { get; set; }
        public virtual PrePresupuesto CodigoPresupuestoNavigation { get; set; }
        public virtual PrePlanUnicoCuenta CodigoPucNavigation { get; set; }
    }
}
