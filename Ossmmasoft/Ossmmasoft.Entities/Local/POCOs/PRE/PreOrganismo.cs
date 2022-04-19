namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreOrganismo
    {
        public int Id { get; set; }
        public int? Año { get; set; }
        public string Denominacion { get; set; }
        public string NumeroRegistro { get; set; }
        public string Actividad { get; set; }
        public string UbicacionGeografica { get; set; }
        public int? TipoOrganismoId { get; set; }
        public decimal? CapitalSocial { get; set; }
        public decimal? Monto1 { get; set; }
        public decimal? Monto2 { get; set; }
        public decimal? Monto4 { get; set; }
        public string Complemeto1 { get; set; }
        public string Complemeto2 { get; set; }
        public string Complemeto3 { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public decimal? Monto3 { get; set; }
        public int? CodigoPresupuesto { get; set; }

        public virtual SisEmpresa CodigoEmpresaNavigation { get; set; }
        public virtual PrePresupuesto CodigoPresupuestoNavigation { get; set; }
        public virtual PreDescriptiva TipoOrganismo { get; set; }
    }
}
