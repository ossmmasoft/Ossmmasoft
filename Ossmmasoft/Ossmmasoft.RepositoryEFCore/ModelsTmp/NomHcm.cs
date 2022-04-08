using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomHcm
    {
        public decimal Id { get; set; }
        public decimal? CodigoPersona { get; set; }
        public decimal? CodigoFamiliar { get; set; }
        public decimal? AseguradoraId { get; set; }
        public decimal PrimaAsegurado { get; set; }
        public decimal AporteAsegurado { get; set; }
        public decimal AportePatron { get; set; }
        public char? TipoAportePatron { get; set; }
        public DateOnly? FechaDesde { get; set; }
        public DateOnly? FechaHasta { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemnto3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }

        public virtual NomDescriptiva Aseguradora { get; set; }
        public virtual NomFamiliare CodigoFamiliarNavigation { get; set; }
        public virtual NomPersona CodigoPersonaNavigation { get; set; }
    }
}
