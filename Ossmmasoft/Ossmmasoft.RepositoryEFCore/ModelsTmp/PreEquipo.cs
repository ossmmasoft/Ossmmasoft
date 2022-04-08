using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class PreEquipo
    {
        public decimal Id { get; set; }
        public decimal? Año { get; set; }
        public decimal? Escenario { get; set; }
        public decimal? CodigoIcp { get; set; }
        public decimal? Principal { get; set; }
        public string Denominacion { get; set; }
        public decimal? Reemplazos { get; set; }
        public decimal? Deficiencias { get; set; }
        public decimal? CostoUnitario { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal? CodigoPresupuesto { get; set; }

        public virtual PreIndiceCatPrg CodigoIcpNavigation { get; set; }
        public virtual PrePresupuesto CodigoPresupuestoNavigation { get; set; }
    }
}
