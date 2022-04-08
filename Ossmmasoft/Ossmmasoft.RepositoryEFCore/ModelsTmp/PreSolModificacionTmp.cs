using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class PreSolModificacionTmp
    {
        public decimal? CodigoSolModificacion { get; set; }
        public decimal? TipoModificacionId { get; set; }
        public DateOnly FechaSolicitud { get; set; }
        public decimal? Ano { get; set; }
        public string NumeroSolModificacion { get; set; }
        public string CodigoOficio { get; set; }
        public decimal? CodigoSolicitante { get; set; }
        public string Motivo { get; set; }
        public string Status { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public decimal? UsuarioIns { get; set; }
        public DateOnly? FechaIns { get; set; }
        public decimal? UsuarioUpd { get; set; }
        public DateOnly? FechaUpd { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal? NumeroCorrelativo { get; set; }
        public decimal? CodigoPresupuesto { get; set; }
    }
}
