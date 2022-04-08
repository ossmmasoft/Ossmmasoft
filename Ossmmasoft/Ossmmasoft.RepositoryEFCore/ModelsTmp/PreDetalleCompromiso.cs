using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class PreDetalleCompromiso
    {
        public decimal? CodigoDetalleCompromiso { get; set; }
        public decimal? CodigoCompromiso { get; set; }
        public decimal? CodigoDetalleSolicitud { get; set; }
        public decimal Cantidad { get; set; }
        public decimal CantidadAnulada { get; set; }
        public decimal? UdmId { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal? PorDescuento { get; set; }
        public decimal? MontoDescuento { get; set; }
        public decimal? TipoImpuestoId { get; set; }
        public decimal PorImpuesto { get; set; }
        public decimal? MontoImpuesto { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public decimal? UsuarioIns { get; set; }
        public DateOnly? FechaIns { get; set; }
        public decimal? UsuarioUpd { get; set; }
        public DateOnly? FechaUpd { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal? CodigoPresupuesto { get; set; }
    }
}
