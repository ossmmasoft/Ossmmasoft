using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class PreTransferencia
    {
        public decimal Id { get; set; }
        public decimal? CodigoPuc { get; set; }
        public decimal? CodigoIcp { get; set; }
        public string Denominacion { get; set; }
        public decimal? TipoMontoId { get; set; }
        public decimal? Monto { get; set; }
        public string Complemeto1 { get; set; }
        public string Complemeto2 { get; set; }
        public string Complemeto3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal? Año { get; set; }
        public decimal? CodigoPresupuesto { get; set; }

        public virtual PreIndiceCatPrg CodigoIcpNavigation { get; set; }
        public virtual PrePresupuesto CodigoPresupuestoNavigation { get; set; }
        public virtual PrePlanUnicoCuenta CodigoPucNavigation { get; set; }
        public virtual PreDescriptiva TipoMonto { get; set; }
    }
}
