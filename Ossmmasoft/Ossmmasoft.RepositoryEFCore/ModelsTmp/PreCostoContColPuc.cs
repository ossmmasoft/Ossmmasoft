using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class PreCostoContColPuc
    {
        public decimal? CodigoCostoContColPuc { get; set; }
        public decimal? CodigoCostoContCol { get; set; }
        public decimal? CodigoPuc { get; set; }
        public decimal? Monto { get; set; }
        public string BaseCalculo { get; set; }
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
