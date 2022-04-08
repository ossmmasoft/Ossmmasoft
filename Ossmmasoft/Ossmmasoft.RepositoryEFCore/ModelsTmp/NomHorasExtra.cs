using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomHorasExtra
    {
        public decimal Id { get; set; }
        public decimal? CodigoPersona { get; set; }
        public decimal? CodigoTipoNomina { get; set; }
        public decimal? CodigoPeriodo { get; set; }
        public decimal? SueldoBaseDiario { get; set; }
        public DateOnly FechaHora { get; set; }
        public DateOnly HoraDesde { get; set; }
        public DateOnly HoraHasta { get; set; }
        public decimal? HorasDiurnas { get; set; }
        public decimal? MontoHorasDiurnas { get; set; }
        public decimal? HorasNocturnas { get; set; }
        public decimal? MontoHorasNocturnas { get; set; }
        public decimal? HorasFeriadas { get; set; }
        public decimal? MontoHorasFeriadas { get; set; }
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
    }
}
