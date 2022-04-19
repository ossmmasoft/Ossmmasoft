﻿namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomPrestamosPrestaciones
    {
        public int Id { get; set; }
        public int? CodigoTipoNomina { get; set; }
        public int? CodigoPersona { get; set; }
        public int? TipoPrestamoId { get; set; }
        public DateOnly FechaPrestamo { get; set; }
        public decimal MontoPrestamo { get; set; }
        public decimal MontoPagado { get; set; }
        public int? FrecuenciaPagoId { get; set; }
        public int? NumeroCuotas { get; set; }
        public int? NumeroCuotasPagadas { get; set; }
        public decimal MontoCuota { get; set; }
        public decimal? PorInteres { get; set; }
        public int? TipoInteresId { get; set; }
        public decimal InteresPagado { get; set; }
        public int? CodigoPeriodo1erPago { get; set; }
        public int? CodigoPeriodoUltPago { get; set; }
        public char? Status { get; set; }
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public string Complemento4 { get; set; } = string.Empty;
        public string Complemento5 { get; set; } = string.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? CodigoPrestamoPrestacionRen { get; set; }
        public decimal MontoRenovado { get; set; }

        public virtual NomPeriodo CodigoPeriodo1erPagoNavigation { get; set; }
        public virtual NomPeriodo CodigoPeriodoUltPagoNavigation { get; set; }
        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomTiposNomina CodigoTipoNominaNavigation { get; set; }
        public virtual NomDescriptiva FrecuenciaPago { get; set; }
        public virtual NomDescriptiva TipoInteres { get; set; }
        public virtual NomDescriptiva TipoPrestamo { get; set; }
    }
}
