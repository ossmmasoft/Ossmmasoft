using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class PreSaldosIngreso
    {
        public decimal? CodigoSaldoIngreso { get; set; }
        public decimal? CodigoPuc { get; set; }
        public decimal? Presupuestado { get; set; }
        public decimal? Recaudado { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public decimal? UsuarioIns { get; set; }
        public DateOnly? FechaIns { get; set; }
        public decimal? UsuarioUpd { get; set; }
        public DateOnly? FechaUpd { get; set; }
        public decimal? CodigoPresupuesto { get; set; }
        public decimal? CodigoEmpresa { get; set; }
    }
}
