using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomVacacionesVencida
    {
        public decimal Id { get; set; }
        public decimal? CodigoPersona { get; set; }
        public decimal? AñoPeriodo { get; set; }
        public DateOnly? FechaVencimiento { get; set; }
        public decimal? DiasVencidos { get; set; }
        public decimal? DiasDisfrutados { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }

        public virtual NomPersona CodigoPersonaNavigation { get; set; }
    }
}
