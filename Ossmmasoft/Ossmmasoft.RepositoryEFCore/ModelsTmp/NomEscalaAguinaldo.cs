using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomEscalaAguinaldo
    {
        public decimal Id { get; set; }
        public decimal? CodigoTipoNomina { get; set; }
        public decimal? DiasAguinaldo { get; set; }
        public decimal? CodigoPeriodoDesde { get; set; }
        public decimal? CodigoPeriodoHasta { get; set; }
        public decimal? CodigoPeriodoAguinaldo { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }

        public virtual NomPeriodo CodigoPeriodoAguinaldoNavigation { get; set; }
        public virtual NomPeriodo CodigoPeriodoDesdeNavigation { get; set; }
        public virtual NomPeriodo CodigoPeriodoHastaNavigation { get; set; }
        public virtual NomTiposNomina CodigoTipoNominaNavigation { get; set; }
    }
}
