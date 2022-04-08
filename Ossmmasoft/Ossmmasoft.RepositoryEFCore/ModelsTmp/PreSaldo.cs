using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class PreSaldo
    {
        public decimal Id { get; set; }
        public decimal? Año { get; set; }
        public decimal? CodigoIcp { get; set; }
        public decimal? CodigoPuc { get; set; }
        public decimal? FinanciadoId { get; set; }
        public decimal? CodigoFinanciado { get; set; }
        public decimal Asignacion { get; set; }
        public decimal Bloqueado { get; set; }
        public decimal Modificado { get; set; }
        public decimal Comprometido { get; set; }
        public decimal Causado { get; set; }
        public decimal Pagado { get; set; }
        public decimal Ajustado { get; set; }
        public string Complemento1 { get; set; }
        public string Complemeto2 { get; set; }
        public string Complemeto3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal? CodigoPresupuesto { get; set; }
        public decimal Presupuestado { get; set; }

        public virtual PreIndiceCatPrg CodigoIcpNavigation { get; set; }
        public virtual PrePlanUnicoCuenta CodigoPucNavigation { get; set; }
        public virtual PreDescriptiva Financiado { get; set; }
        public virtual PrePresupuesto PresupuestadoNavigation { get; set; }
    }
}
