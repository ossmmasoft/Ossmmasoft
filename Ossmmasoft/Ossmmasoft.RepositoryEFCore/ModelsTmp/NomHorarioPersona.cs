using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomHorarioPersona
    {
        public decimal Id { get; set; }
        public decimal? CodigoPersona { get; set; }
        public decimal? CodigoHdom { get; set; }
        public decimal? CodigoHlun { get; set; }
        public decimal? CodigoHmar { get; set; }
        public decimal? CodigoHmie { get; set; }
        public decimal? CodigoHjue { get; set; }
        public decimal? CodigoHvie { get; set; }
        public decimal? CodigoHsab { get; set; }
        public decimal? CodigoIcp { get; set; }
        public DateOnly? FechaDesde { get; set; }
        public DateOnly? FechaHasta { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public string Complemento4 { get; set; }
        public string Complemento5 { get; set; }

        public virtual NomHorario CodigoHdomNavigation { get; set; }
        public virtual NomHorario CodigoHjueNavigation { get; set; }
        public virtual NomHorario CodigoHlunNavigation { get; set; }
        public virtual NomHorario CodigoHmarNavigation { get; set; }
        public virtual NomHorario CodigoHmieNavigation { get; set; }
        public virtual NomHorario CodigoHsabNavigation { get; set; }
        public virtual NomHorario CodigoHvieNavigation { get; set; }
        public virtual PreIndiceCatPrg CodigoIcpNavigation { get; set; }
        public virtual NomPersona CodigoPersonaNavigation { get; set; }
    }
}
