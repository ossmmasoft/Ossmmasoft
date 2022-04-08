using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomRegistroPermiso
    {
        public decimal Id { get; set; }
        public decimal? CodigoPersona { get; set; }
        public decimal? TipoPermisoId { get; set; }
        public DateOnly? FechaPermiso { get; set; }
        public DateOnly? FechaSalida { get; set; }
        public DateOnly? FechaEntrada { get; set; }
        public string Motivo { get; set; }
        public decimal? Status { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }

        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomDescriptiva TipoPermiso { get; set; }
    }
}
