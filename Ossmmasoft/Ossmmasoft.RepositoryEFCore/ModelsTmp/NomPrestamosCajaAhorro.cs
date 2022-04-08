using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomPrestamosCajaAhorro
    {
        public decimal Id { get; set; }
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
        public decimal? CodigoPeriodo1erPago { get; set; }
        public decimal? CodigoPeriodoUltPago { get; set; }
        public char? Status { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? Fechaactualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }

        public virtual NomDescriptiva CodigoPeriodo1erPagoNavigation { get; set; }
        public virtual NomDescriptiva CodigoPeriodoUltPagoNavigation { get; set; }
        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomTiposNomina CodigoTipoNominaNavigation { get; set; }
        public virtual NomDescriptiva TipoPrestamo { get; set; }
    }
}
