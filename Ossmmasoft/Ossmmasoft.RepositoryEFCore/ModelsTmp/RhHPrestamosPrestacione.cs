using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class RhHPrestamosPrestacione
    {
        public decimal? CodigoHPrestamoPrestacion { get; set; }
        public decimal? CodigoPrestamoPrestacion { get; set; }
        public decimal? CodigoTipoNomina { get; set; }
        public decimal? CodigoPersona { get; set; }
        public decimal? TipoPrestamoId { get; set; }
        public DateOnly FechaPrestamo { get; set; }
        public decimal MontoPrestamo { get; set; }
        public decimal MontoPagado { get; set; }
        public decimal? FrecuenciaPagoId { get; set; }
        public decimal? NumeroCuotas { get; set; }
        public decimal? NumeroCuotasPagadas { get; set; }
        public decimal MontoCuota { get; set; }
        public decimal? PorInteres { get; set; }
        public decimal? TipoInteresId { get; set; }
        public decimal InteresPagado { get; set; }
        public decimal? CodigoPeriodo1erpago { get; set; }
        public decimal? CodigoPeriodoUltpago { get; set; }
        public char? Status { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public decimal? UsuarioHIns { get; set; }
        public DateOnly? FechaHIns { get; set; }
        public decimal? UsuarioIns { get; set; }
        public DateOnly? FechaIns { get; set; }
        public decimal? UsuarioUpd { get; set; }
        public DateOnly? FechaUpd { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal? CodigoPrestamoPrestacionRen { get; set; }
        public decimal MontoRenovado { get; set; }
    }
}
