using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class PreEjecucionPresupuestarium
    {
        public char? CodigoGrupo { get; set; }
        public string CodigoNivel1 { get; set; }
        public string CodigoNivel2 { get; set; }
        public string CodigoNivel3 { get; set; }
        public string CodigoNivel4 { get; set; }
        public decimal? IReal { get; set; }
        public decimal? IProyectado { get; set; }
        public decimal? IiReal { get; set; }
        public decimal? IiProyectado { get; set; }
        public decimal? IiiReal { get; set; }
        public decimal? IiiProyectado { get; set; }
        public decimal? IvReal { get; set; }
        public decimal? IvProyectado { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal? CodigoPresupuesto { get; set; }
    }
}
