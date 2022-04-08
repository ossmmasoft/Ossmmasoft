using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class PreSolModificacion
    {
        public PreSolModificacion()
        {
            PreModificacions = new HashSet<PreModificacion>();
            PrePucSolModificacions = new HashSet<PrePucSolModificacion>();
        }

        public decimal Id { get; set; }
        public decimal? TipoModificacionId { get; set; }
        public DateOnly FechaSolicitud { get; set; }
        public decimal? Año { get; set; }
        public string NumeroSolModificacion { get; set; }
        public string CodigoOficio { get; set; }
        public decimal? CodigoSolicitante { get; set; }
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
        public decimal? NumeroCorrelativo { get; set; }
        public decimal? CodigoPresupuesto { get; set; }

        public virtual PrePresupuesto CodigoPresupuestoNavigation { get; set; }
        public virtual PreDescriptiva TipoModificacion { get; set; }
        public virtual ICollection<PreModificacion> PreModificacions { get; set; }
        public virtual ICollection<PrePucSolModificacion> PrePucSolModificacions { get; set; }
    }
}
