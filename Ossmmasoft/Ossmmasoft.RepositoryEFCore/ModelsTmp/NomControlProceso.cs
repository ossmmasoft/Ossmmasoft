using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomControlProceso
    {
        public decimal Id { get; set; }
        public decimal? CodigoTipoNomina { get; set; }
        public decimal? ProcesoId { get; set; }
        public string NumeroProceso { get; set; }
        public DateOnly FechaDesde { get; set; }
        public DateOnly FechaHasta { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }

        public virtual NomTiposNomina CodigoTipoNominaNavigation { get; set; }
    }
}
