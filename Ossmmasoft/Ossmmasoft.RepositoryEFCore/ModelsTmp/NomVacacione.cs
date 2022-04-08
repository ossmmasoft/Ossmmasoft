using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomVacacione
    {
        public decimal Id { get; set; }
        public decimal? CodigoTipoNomina { get; set; }
        public decimal? CodigoPeriodo { get; set; }
        public decimal? CodigoPersona { get; set; }
        public string PeriodoAño { get; set; }
        public DateOnly? FechaDesde { get; set; }
        public DateOnly? FechaHasta { get; set; }
        public DateOnly? FechaSalida { get; set; }
        public DateOnly? FechaEntrada { get; set; }
        public decimal? DiasHabiles { get; set; }
        public decimal? FrecuenciaPagoId { get; set; }
        public decimal? CantidadFrecuenciaPago { get; set; }
        public char? CobroAdelantoSueldo { get; set; }
        public decimal? BonoVacacional { get; set; }
        public char? Status { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }

        public virtual NomPeriodo CodigoPeriodoNavigation { get; set; }
        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomTiposNomina CodigoTipoNominaNavigation { get; set; }
        public virtual NomDescriptiva FrecuenciaPago { get; set; }
    }
}
