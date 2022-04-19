namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreModificacion
    {
        public PreModificacion()
        {
            PrePucModificacions = new HashSet<PrePucModificacion>();
        }

        public int Id { get; set; }
        public int? CodigoSolModificacion { get; set; }
        public int? TipoModificacionId { get; set; }
        public DateOnly FechaModificacion { get; set; }
        public int? Año { get; set; }
        public string NumeroModificacion { get; set; }
        public string NroResAct { get; set; }
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
        public int? CodigoPresupuesto { get; set; }

        public virtual SisEmpresa CodigoEmpresaNavigation { get; set; }
        public virtual PrePresupuesto CodigoPresupuestoNavigation { get; set; }
        public virtual PreSolModificacion CodigoSolModificacionNavigation { get; set; }
        public virtual PreDescriptiva TipoModificacion { get; set; }
        public virtual ICollection<PrePucModificacion> PrePucModificacions { get; set; }
    }
}
