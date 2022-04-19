namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public class PreTitulo
    {
        public PreTitulo()
        {
            PreDescriptivas = new HashSet<PreDescriptiva>();
        }
        public int Id { get; set; }
        public int TituloPadreId { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Codigo { get; set; } = string.Empty;
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public int UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int UsuarioActualizacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public int CodigoEmpresa { get; set; }
        public virtual ICollection<PreDescriptiva> PreDescriptivas { get; set; }
    }
}
