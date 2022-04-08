using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomEgreso
    {
        public decimal Id { get; set; }
        public decimal? CodigoPersona { get; set; }
        public decimal? CodigoRelacionCargo { get; set; }
        public decimal? TipoEgresoId { get; set; }
        public string Observaciones { get; set; }
        public DateOnly? FechaEgreso { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }

        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomRelacionCargo CodigoRelacionCargoNavigation { get; set; }
        public virtual NomDescriptiva TipoEgreso { get; set; }
    }
}
