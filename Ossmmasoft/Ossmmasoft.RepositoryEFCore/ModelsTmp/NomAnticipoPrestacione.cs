using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomAnticipoPrestacione
    {
        public decimal Id { get; set; }
        public decimal? CodigoPersona { get; set; }
        public DateOnly FechaAnticipo { get; set; }
        public decimal? MotivoAnticipoId { get; set; }
        public decimal MontoAnticipo { get; set; }
        public string Observacion { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacions { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }

        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomDescriptiva MotivoAnticipo { get; set; }
    }
}
