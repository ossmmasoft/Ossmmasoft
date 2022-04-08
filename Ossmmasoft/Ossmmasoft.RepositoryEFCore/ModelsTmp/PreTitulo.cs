using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class PreTitulo
    {
        public PreTitulo()
        {
            PreDescriptivas = new HashSet<PreDescriptiva>();
        }

        public decimal Id { get; set; }
        public decimal? TituloPadreId { get; set; }
        public string Titulo { get; set; }
        public string Codigo { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }

        public virtual ICollection<PreDescriptiva> PreDescriptivas { get; set; }
    }
}
