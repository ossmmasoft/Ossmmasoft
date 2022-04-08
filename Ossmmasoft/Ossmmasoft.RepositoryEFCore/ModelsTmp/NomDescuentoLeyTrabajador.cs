using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomDescuentoLeyTrabajador
    {
        public decimal Id { get; set; }
        public decimal? CodigoDescuentoLey { get; set; }
        public decimal? CodigoPersona { get; set; }
        public decimal? PorDesLeyTrabajador { get; set; }
        public decimal? PorDesLeyPatrono { get; set; }
        public string Complemnto1 { get; set; }
        public string Complemnto2 { get; set; }
        public string Complemnto3 { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }

        public virtual NomDescuentoLey CodigoDescuentoLeyNavigation { get; set; }
        public virtual NomPersona CodigoPersonaNavigation { get; set; }
    }
}
