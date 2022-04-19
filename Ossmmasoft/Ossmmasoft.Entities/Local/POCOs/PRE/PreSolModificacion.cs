namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreSolModificacion
    {
        public PreSolModificacion()
        {
            PreModificacions = new HashSet<PreModificacion>();
            PrePucSolModificacions = new HashSet<PrePucSolModificacion>();
        }

        public int Id { get; set; }
        public int? TipoModificacionId { get; set; }
        public DateOnly FechaSolicitud { get; set; }
        public int? Año { get; set; }
        public string NumeroSolModificacion { get; set; }
        public string CodigoOficio { get; set; }
        public int? CodigoSolicitante { get; set; }
        public string Motivo { get; set; }
        public string Status { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? NumeroCorrelativo { get; set; }
        public int? CodigoPresupuesto { get; set; }

        public virtual SisEmpresa CodigoEmpresaNavigation { get; set; }
        public virtual PrePresupuesto CodigoPresupuestoNavigation { get; set; }
        public virtual PreDescriptiva TipoModificacion { get; set; }
        public virtual ICollection<PreModificacion> PreModificacions { get; set; }
        public virtual ICollection<PrePucSolModificacion> PrePucSolModificacions { get; set; }
    }
}
