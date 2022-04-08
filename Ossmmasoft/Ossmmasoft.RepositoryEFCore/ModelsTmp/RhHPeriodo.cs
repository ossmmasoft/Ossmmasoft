using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class RhHPeriodo
    {
        public decimal? CodigoHPeriodo { get; set; }
        public DateOnly? FechaInsH { get; set; }
        public decimal? UsuarioInsH { get; set; }
        public decimal? CodigoPeriodo { get; set; }
        public decimal? CodigoTipoNomina { get; set; }
        public DateOnly? FechaNomina { get; set; }
        public decimal? Periodo { get; set; }
        public char? TipoNomina { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public decimal? UsuarioIns { get; set; }
        public DateOnly? FechaIns { get; set; }
        public decimal? UsuarioUpd { get; set; }
        public DateOnly? FechaUpd { get; set; }
        public decimal? UsuarioPrecierre { get; set; }
        public DateOnly? FechaPrecierre { get; set; }
        public decimal? UsuarioCierre { get; set; }
        public DateOnly? FechaCierre { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal? CodigoCuentaEmpresa { get; set; }
        public decimal? UsuarioPrenomina { get; set; }
        public DateOnly? FechaPrenomina { get; set; }
        public decimal? CodigoPresupuesto { get; set; }
        public string Descripcion { get; set; }
    }
}
