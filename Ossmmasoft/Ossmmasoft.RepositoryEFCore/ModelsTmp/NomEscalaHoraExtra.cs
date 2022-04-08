using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomEscalaHoraExtra
    {
        public decimal Id { get; set; }
        public decimal? CodigoTipoNomina { get; set; }
        public decimal? DiaHora { get; set; }
        public DateOnly HoraDesde { get; set; }
        public DateOnly HoraHasta { get; set; }
        public char? TipoHora { get; set; }
        public DateOnly? FechaFeriado { get; set; }
        public string TipoSueldo { get; set; }
        public decimal? PorHora { get; set; }
        public decimal? MontoHora { get; set; }
        public decimal? MontoMax { get; set; }
        public decimal? PrecisionDecimal { get; set; }
        public DateOnly? FechaDesde { get; set; }
        public DateOnly? FechaHasta { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal? HorasDia { get; set; }
        public decimal? PorPrevioCalculo { get; set; }

        public virtual NomTiposNomina CodigoTipoNominaNavigation { get; set; }
    }
}
