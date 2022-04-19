namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreEquipo
    {
        public int Id { get; set; }
        public int? Año { get; set; }
        public int? Escenario { get; set; }
        public int? CodigoIcp { get; set; }
        public int? Principal { get; set; }
        public string Denominacion { get; set; }
        public decimal? Reemplazos { get; set; }
        public decimal? Deficiencias { get; set; }
        public decimal? CostoUnitario { get; set; }
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
        public virtual PreIndiceCatPrg CodigoIcpNavigation { get; set; }
        public virtual PrePresupuesto CodigoPresupuestoNavigation { get; set; }
    }
}
