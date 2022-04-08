using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class PreOrganismo
    {
        public decimal Id { get; set; }
        public decimal? Año { get; set; }
        public string Denominacion { get; set; }
        public string NumeroRegistro { get; set; }
        public string Actividad { get; set; }
        public string UbicacionGeografica { get; set; }
        public decimal? TipoOrganismoId { get; set; }
        public decimal? CapitalSocial { get; set; }
        public decimal? Monto1 { get; set; }
        public decimal? Monto2 { get; set; }
        public decimal? Monto4 { get; set; }
        public string Complemeto1 { get; set; }
        public string Complemeto2 { get; set; }
        public string Complemeto3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal? Monto3 { get; set; }
        public decimal? CodigoPresupuesto { get; set; }

        public virtual PrePresupuesto CodigoPresupuestoNavigation { get; set; }
        public virtual PreDescriptiva TipoOrganismo { get; set; }
    }
}
