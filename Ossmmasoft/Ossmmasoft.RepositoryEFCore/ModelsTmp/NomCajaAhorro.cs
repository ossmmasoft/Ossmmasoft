using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomCajaAhorro
    {
        public decimal Id { get; set; }
        public decimal? CodigoPersona { get; set; }
        public decimal? CodigoPeriodoInicio { get; set; }
        public decimal? CodigoPeriodoFin { get; set; }
        public DateOnly? FechaIngreso { get; set; }
        public DateOnly? FechaEgreso { get; set; }
        public decimal? CodigoBanco { get; set; }
        public decimal? TipoCuentaId { get; set; }
        public string NumeroCuenta { get; set; }
        public decimal? PorcAporteTrabajador { get; set; }
        public decimal? PorcAportePatron { get; set; }
        public DateOnly? FechaLiq { get; set; }
        public decimal? MontoLiq { get; set; }
        public decimal? NumeroChLiq { get; set; }
        public decimal? CodigoBancoLiq { get; set; }
        public string NumeroCuentaLiq { get; set; }
        public decimal? SaldoHaber { get; set; }
        public decimal? SaldoDeuda { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }

        public virtual NomPeriodo CodigoPeriodoFinNavigation { get; set; }
        public virtual NomPeriodo CodigoPeriodoInicioNavigation { get; set; }
        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomDescriptiva TipoCuenta { get; set; }
    }
}
