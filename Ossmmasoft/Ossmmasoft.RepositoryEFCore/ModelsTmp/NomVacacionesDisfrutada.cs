using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomVacacionesDisfrutada
    {
        public decimal Id { get; set; }
        public decimal? CodigoPersona { get; set; }
        public decimal? CodigoPeriodo { get; set; }
        public DateOnly? FechaDesde { get; set; }
        public DateOnly? FechaHasta { get; set; }
        public decimal? DiasHabiles { get; set; }
        public decimal? CobroAdelantoSueldo { get; set; }
        public decimal? CobroBonoVacacional { get; set; }
        public string NumeroOficioIncorporacion { get; set; }
        public DateOnly? FechaIncorporacion { get; set; }
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
    }
}
