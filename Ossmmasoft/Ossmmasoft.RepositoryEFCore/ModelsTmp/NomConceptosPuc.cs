using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomConceptosPuc
    {
        public decimal Id { get; set; }
        public decimal? CodigoConcepto { get; set; }
        public decimal? CodigoPresupuesto { get; set; }
        public decimal? CodigoPuc { get; set; }
        public decimal? Estatus { get; set; }
        public string Complemnto1 { get; set; }
        public string Complemnto2 { get; set; }
        public string Complemnto3 { get; set; }
        public string Complemnto4 { get; set; }
        public string Complemnto5 { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }

        public virtual NomConcepto CodigoConceptoNavigation { get; set; }
        public virtual PrePresupuesto CodigoPresupuestoNavigation { get; set; }
        public virtual PrePlanUnicoCuenta CodigoPucNavigation { get; set; }
    }
}
