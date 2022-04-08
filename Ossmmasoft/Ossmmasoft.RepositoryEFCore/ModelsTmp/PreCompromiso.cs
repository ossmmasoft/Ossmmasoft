using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class PreCompromiso
    {
        public decimal Id { get; set; }
        public decimal? Año { get; set; }
        public decimal? CodigoSolicitud { get; set; }
        public string NumeroCompromiso { get; set; }
        public DateOnly FechaCompromiso { get; set; }
        public decimal? CodigoProveedor { get; set; }
        public DateOnly? FechaEntrega { get; set; }
        public decimal? CodigoDirEntrega { get; set; }
        public decimal? TipoPagoId { get; set; }
        public string Motivo { get; set; }
        public string Status { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal? CodigoPresupuesto { get; set; }
        public decimal? TipoRenglonId { get; set; }
        public string NumeroOrden { get; set; }
    }
}
