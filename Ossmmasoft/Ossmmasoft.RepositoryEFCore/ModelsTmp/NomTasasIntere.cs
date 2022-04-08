using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomTasasIntere
    {
        public decimal Id { get; set; }
        public string NumeroTasa { get; set; }
        public decimal? TipoTasaId { get; set; }
        public decimal? Tasa { get; set; }
        public decimal? ArticuloId { get; set; }
        public string NumeroGacetaOficial { get; set; }
        public DateOnly? FechaGacetaOficial { get; set; }
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

        public virtual NomDescriptiva TipoTasa { get; set; }
    }
}
