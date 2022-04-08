using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomTitulo
    {
        public NomTitulo()
        {
            NomDescriptivas = new HashSet<NomDescriptiva>();
        }

        public decimal Id { get; set; }
        public decimal? TituloPadreId { get; set; }
        public string Titulo { get; set; }
        public string CodigoTitulo { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }

        public virtual ICollection<NomDescriptiva> NomDescriptivas { get; set; }
    }
}
