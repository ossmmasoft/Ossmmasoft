using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class RhTmpMovPrestacione
    {
        public decimal? CodigoMovPrestacion { get; set; }
        public decimal? CodigoPersona { get; set; }
        public decimal? ConceptoId { get; set; }
        public string ComplementoConcepto { get; set; }
        public DateOnly Fecha { get; set; }
        public decimal Monto { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public decimal? UsuarioIns { get; set; }
        public DateOnly? FechaIns { get; set; }
        public decimal? UsuarioUpd { get; set; }
        public DateOnly? FechaUpd { get; set; }
        public decimal? CodigoEmpresa { get; set; }
    }
}
