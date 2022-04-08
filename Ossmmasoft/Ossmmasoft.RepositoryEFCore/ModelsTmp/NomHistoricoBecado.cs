using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomHistoricoBecado
    {
        public decimal Id { get; set; }
        public decimal? CodigoPeriodo { get; set; }
        public decimal? CodigoTipoNomina { get; set; }
        public DateOnly? FechaNomina { get; set; }
        public decimal? CodigoBecado { get; set; }
        public decimal? CodigoPersona { get; set; }
        public decimal? CodigoFamiliar { get; set; }
        public decimal? Monto { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public string Observacion { get; set; }

        public virtual NomBecado CodigoBecadoNavigation { get; set; }
        public virtual NomFamiliare CodigoFamiliarNavigation { get; set; }
        public virtual NomPeriodo CodigoPeriodoNavigation { get; set; }
        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomTiposNomina CodigoTipoNominaNavigation { get; set; }
    }
}
