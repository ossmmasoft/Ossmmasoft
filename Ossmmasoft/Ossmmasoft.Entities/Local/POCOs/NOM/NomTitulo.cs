namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomTitulo
    {
        public NomTitulo()
        {
            NomDescriptivas = new HashSet<NomDescriptiva>();
        }

        public int Id { get; set; }
        public int TituloPadreId { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string CodigoTitulo { get; set; } = string.Empty;
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public string Complemento4 { get; set; } = string.Empty;
        public string Complemento5 { get; set; } = string.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int CodigoEmpresa { get; set; }

        public virtual ICollection<NomDescriptiva> NomDescriptivas { get; set; }
    }
}
