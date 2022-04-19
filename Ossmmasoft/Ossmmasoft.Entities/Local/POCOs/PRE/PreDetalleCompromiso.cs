namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreDetalleCompromiso
    {
        public int? Id { get; set; }
        public int? CodigoCompromiso { get; set; }
        public int? CodigoDetalleSolicitud { get; set; }
        public decimal Cantidad { get; set; }
        public decimal CantidadAnulada { get; set; }
        public int? UdmId { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal? PorDescuento { get; set; }
        public decimal? MontoDescuento { get; set; }
        public int? TipoImpuestoId { get; set; }
        public decimal PorImpuesto { get; set; }
        public decimal? MontoImpuesto { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public int? UsuarioIns { get; set; }
        public DateOnly? FechaIns { get; set; }
        public int? UsuarioUpd { get; set; }
        public DateOnly? FechaUpd { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? CodigoPresupuesto { get; set; }
    }
}
