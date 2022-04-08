using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomTmpAguinaldo
    {
        public decimal Id { get; set; }
        public decimal? CodigoTipoNomina { get; set; }
        public decimal? CodigoPeriodo { get; set; }
        public decimal? CodigoPersona { get; set; }
        public DateOnly? FechaIngreso { get; set; }
        public decimal? Meses { get; set; }
        public decimal? Dias { get; set; }
        public decimal? SueldoIntegral { get; set; }
        public decimal? BonoVacacional { get; set; }
        public decimal? Comisiones { get; set; }
        public decimal? Aguinaldo { get; set; }
        public string Status { get; set; }
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
