namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomDocumento
    {
        public NomDocumento()
        {
            NomDocumentosDetalles = new HashSet<NomDocumentosDetalle>();
        }

        public int Id { get; set; }
        public int? CodigoPersona { get; set; }

        public int? TipoDocumentoId { get; set; }
        public string NumeroDocumento { get; set; } = string.Empty;
        public DateOnly? FechaVencimiento { get; set; }
        public int? TipoGradoId { get; set; }
        public int? GradoId { get; set; }
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActuaclizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public string Complemento4 { get; set; } = string.Empty;
        public string Complemento5 { get; set; } = string.Empty;

        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomDescriptiva Grado { get; set; }
        public virtual NomDescriptiva TipoDocumento { get; set; }
        public virtual NomDescriptiva TipoGrado { get; set; }
        public virtual ICollection<NomDocumentosDetalle> NomDocumentosDetalles { get; set; }
    }
}
