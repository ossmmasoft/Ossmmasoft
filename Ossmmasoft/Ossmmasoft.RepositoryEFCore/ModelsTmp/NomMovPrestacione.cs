using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomMovPrestacione
    {
        public decimal Id { get; set; }
        public decimal? CodigoPersona { get; set; }
        public decimal? ConceptoId { get; set; }
        public string ComplementoConcepto { get; set; }
        public DateOnly Fecha { get; set; }
        public decimal Monto { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }

        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomDescriptiva Concepto { get; set; }
    }
}
