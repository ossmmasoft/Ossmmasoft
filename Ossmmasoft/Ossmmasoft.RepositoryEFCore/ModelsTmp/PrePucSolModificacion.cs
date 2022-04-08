using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class PrePucSolModificacion
    {
        public PrePucSolModificacion()
        {
            PrePucModificacions = new HashSet<PrePucModificacion>();
        }

        public decimal Id { get; set; }
        public decimal? CodigoSolModificacion { get; set; }
        public decimal CodigoSaldo { get; set; }
        public string FinanciadoId { get; set; }
        public decimal? CodigoFinanciado { get; set; }
        public decimal? CodigoIcp { get; set; }
        public decimal? CodigoPuc { get; set; }
        public decimal Monto { get; set; }
        public string DePara { get; set; }
        public decimal? Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal MontoModificado { get; set; }
        public decimal MontoAnulado { get; set; }
        public decimal? CodigoPresupuesto { get; set; }

        public virtual PreIndiceCatPrg CodigoIcpNavigation { get; set; }
        public virtual PrePresupuesto CodigoPresupuestoNavigation { get; set; }
        public virtual PrePlanUnicoCuenta CodigoPucNavigation { get; set; }
        public virtual PreSolModificacion CodigoSolModificacionNavigation { get; set; }
        public virtual ICollection<PrePucModificacion> PrePucModificacions { get; set; }
    }
}
