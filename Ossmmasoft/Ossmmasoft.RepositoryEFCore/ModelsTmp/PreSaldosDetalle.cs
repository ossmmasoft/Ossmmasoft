using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class PreSaldosDetalle
    {
        public decimal? CodigoSaldoDetalle { get; set; }
        public decimal? CodigoSaldo { get; set; }
        public decimal Monto { get; set; }
        public DateOnly FechaAsignacion { get; set; }
        public decimal PorcentajeAsignacion { get; set; }
        public string Extra1 { get; set; }
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
