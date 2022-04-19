namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomComunicaciones
    {
        public int Id { get; set; }
        public int CodigoPersona { get; set; }
        public int TipoComunicacionId { get; set; }
        public string CodigoArea { get; set; } = String.Empty;
        public string LineaComunicacion { get; set; } = String.Empty;
        public decimal? Extencion { get; set; }
        public decimal? Principal { get; set; }
        public string Complemento1 { get; set; } = String.Empty;
        public string Complemento2 { get; set; } = String.Empty;
        public string Complemento3 { get; set; } = String.Empty;
        public int UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int CodigoEmpresa { get; set; }

        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomDescriptiva TipoComunicacion { get; set; }
    }
}
