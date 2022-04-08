using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomDetalleLiquidacione
    {
        public decimal? Id { get; set; }
        public decimal? CodigoEgreso { get; set; }
        public char? TipoDetalle { get; set; }
        public decimal? ConceptoId { get; set; }
        public string ComplementoConcepto { get; set; }
        public decimal? Dias { get; set; }
        public decimal Spd { get; set; }
        public decimal Monto { get; set; }
        public string Observacion { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }

        public virtual NomEgreso CodigoEgresoNavigation { get; set; }
        public virtual NomDescriptiva Concepto { get; set; }
    }
}
