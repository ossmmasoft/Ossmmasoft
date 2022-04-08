using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomComunicacione
    {
        public decimal Id { get; set; }
        public decimal? CodigoPersona { get; set; }
        public decimal? TipoComunicacionId { get; set; }
        public string CodigoArea { get; set; }
        public string LineaComunicacion { get; set; }
        public decimal? Extencion { get; set; }
        public decimal? Principal { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }

        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomDescriptiva TipoComunicacion { get; set; }
    }
}
