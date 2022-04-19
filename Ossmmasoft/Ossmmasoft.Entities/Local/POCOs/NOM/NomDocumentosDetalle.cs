namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomDocumentosDetalle
    {
        public int Id { get; set; }
        public int? CodigoDocumento { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public DateOnly? FechaFinal { get; set; }
        public DateOnly? FechaInicial { get; set; }

        public virtual NomDocumento CodigoDocumentoNavigation { get; set; }
    }
}
