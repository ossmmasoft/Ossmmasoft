using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomPromocione
    {
        public decimal Id { get; set; }
        public decimal? CodigoPersona { get; set; }
        public decimal? CodigoRelacionCargoOld { get; set; }
        public decimal? CodigoRelacionCargoNew { get; set; }
        public string NumeroOficio { get; set; }
        public DateOnly? FechaOficio { get; set; }
        public string Observacion { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? IsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public string Complemento4 { get; set; }
        public string Complemento5 { get; set; }

        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomRelacionCargo CodigoRelacionCargoNewNavigation { get; set; }
        public virtual NomRelacionCargo CodigoRelacionCargoOldNavigation { get; set; }
    }
}
