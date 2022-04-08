using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class PreMeta
    {
        public decimal Id { get; set; }
        public decimal? CodigoProyecto { get; set; }
        public decimal? NumeroMeta { get; set; }
        public string DenominacionMeta { get; set; }
        public decimal? UnidadMedidaId { get; set; }
        public decimal? CantidadMeta { get; set; }
        public decimal? CostoMeta { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal? CodigoPresupuesto { get; set; }
        public decimal? CantidadPrimerTrimestre { get; set; }
        public decimal? CantidadSegundoTrimestre { get; set; }
        public decimal? CantidadTercerTrimestre { get; set; }
        public decimal? CantidadCuartoTrimestre { get; set; }

        public virtual PrePresupuesto CodigoPresupuestoNavigation { get; set; }
        public virtual PreProyecto CodigoProyectoNavigation { get; set; }
    }
}
