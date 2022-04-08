using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomEscalaUtilEscolar
    {
        public decimal Id { get; set; }
        public decimal? ParienteId { get; set; }
        public decimal? NivelEducativoId { get; set; }
        public decimal? Grado { get; set; }
        public decimal Monto { get; set; }
        public DateOnly FechaDesde { get; set; }
        public DateOnly? FechaHasta { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal? CodigoTipoNomina { get; set; }
        public string Complemento4 { get; set; }
        public string Complemento5 { get; set; }

        public virtual NomTiposNomina CodigoTipoNominaNavigation { get; set; }
        public virtual PreDescriptiva NivelEducativo { get; set; }
        public virtual NomDescriptiva Pariente { get; set; }
    }
}
