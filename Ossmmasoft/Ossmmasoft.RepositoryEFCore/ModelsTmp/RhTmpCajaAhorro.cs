using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class RhTmpCajaAhorro
    {
        public decimal? CodigoCajaAhorro { get; set; }
        public decimal? CodigoPersona { get; set; }
        public decimal? CodigoPeriodoInicio { get; set; }
        public decimal? CodigoPeriodoFin { get; set; }
        public DateOnly? FechaIngreso { get; set; }
        public DateOnly? FechaEgreso { get; set; }
        public decimal? CodigoBanco { get; set; }
        public decimal? TipoCuentaId { get; set; }
        public string NumeroCuenta { get; set; }
        public decimal? PorAporteTrabajador { get; set; }
        public decimal? PorAportePatron { get; set; }
        public DateOnly? FechaLiq { get; set; }
        public decimal? MontoLiq { get; set; }
        public decimal? NumeroChLiq { get; set; }
        public decimal? CodigoBancoLiq { get; set; }
        public string NumeroCuentaLiq { get; set; }
        public decimal? SaldoHaber { get; set; }
        public decimal? SaldoDeuda { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public decimal? UsuarioIns { get; set; }
        public DateOnly? FechaIns { get; set; }
        public decimal? UsuarioUpd { get; set; }
        public DateOnly? FechaUpd { get; set; }
        public decimal? CodigoEmpresa { get; set; }
    }
}
