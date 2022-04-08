using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class ConceptosAcumula
    {
        public decimal Id { get; set; }
        public decimal? CodigoConcepto { get; set; }
        public string TipoAcumuladoId { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? CodigoConceptoAsociado { get; set; }
        public DateOnly? FechaDesde { get; set; }
        public DateOnly? FechaHasta { get; set; }

        public virtual NomConcepto CodigoConceptoAsociadoNavigation { get; set; }
        public virtual NomConcepto CodigoConceptoNavigation { get; set; }
    }
}
