using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class PreEscala
    {
        public decimal Id { get; set; }
        public decimal? Año { get; set; }
        public decimal? Escenario { get; set; }
        public string NumeroEscala { get; set; }
        public string CodigoGrupo { get; set; }
        public decimal? ValorIni { get; set; }
        public decimal? ValorFin { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal? CodigoPresupuesto { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public string Complemento4 { get; set; }
        public string Complemento5 { get; set; }

        public virtual PrePresupuesto CodigoPresupuestoNavigation { get; set; }
    }
}
