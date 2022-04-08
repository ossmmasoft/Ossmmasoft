using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class SisDescriptiva
    {
        public decimal Id { get; set; }
        public decimal? DescripcionPadreId { get; set; }
        public string Descripcion { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public string Codigo { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal? Estatus { get; set; }
    }
}
