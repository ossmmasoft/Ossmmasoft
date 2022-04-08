using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class PrePucCompromiso
    {
        public decimal? CodigoPucCompromiso { get; set; }
        public decimal? CodigoDetalleCompromiso { get; set; }
        public decimal? CodigoPucSolicitud { get; set; }
        public decimal? CodigoSaldo { get; set; }
        public decimal? CodigoIcp { get; set; }
        public decimal? CodigoPuc { get; set; }
        public decimal? FinanciadoId { get; set; }
        public decimal? CodigoFinanciado { get; set; }
        public decimal Monto { get; set; }
        public decimal MontoCausado { get; set; }
        public decimal MontoAnulado { get; set; }
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
