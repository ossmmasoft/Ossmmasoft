using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class PreSaldosDiariosTmp
    {
        public decimal? CodigoSaldoDiario { get; set; }
        public decimal? CodigoSaldo { get; set; }
        public DateOnly FechaSaldo { get; set; }
        public decimal Asignacion { get; set; }
        public decimal Bloqueado { get; set; }
        public decimal Modificado { get; set; }
        public decimal Comprometido { get; set; }
        public decimal Causado { get; set; }
        public decimal Pagado { get; set; }
        public decimal Ajustado { get; set; }
        public decimal? Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public decimal? UsuarioIns { get; set; }
        public DateOnly? FechaIns { get; set; }
        public decimal? UsuarioUpd { get; set; }
        public DateOnly? FechaUpd { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal? CodigoPresupuesto { get; set; }
    }
}
