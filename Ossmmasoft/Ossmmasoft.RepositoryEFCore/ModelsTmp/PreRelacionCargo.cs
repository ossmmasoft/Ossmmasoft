using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class PreRelacionCargo
    {
        public PreRelacionCargo()
        {
            NomRelacionCargos = new HashSet<NomRelacionCargo>();
        }

        public decimal Id { get; set; }
        public decimal? Año { get; set; }
        public decimal? Escenario { get; set; }
        public decimal? CodigoIcp { get; set; }
        public decimal? CodigoCargo { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal Sueldo { get; set; }
        public decimal? Compensacion { get; set; }
        public decimal? Prima { get; set; }
        public decimal? Otro { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal? CodigoPresupuesto { get; set; }

        public virtual PrePresupuesto CodigoPresupuestoNavigation { get; set; }
        public virtual ICollection<NomRelacionCargo> NomRelacionCargos { get; set; }
    }
}
