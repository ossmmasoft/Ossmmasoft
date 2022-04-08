namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public class PreTitulo
    {
        public int Id { get; set; }
        public int TituloPadreId { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Codigo { get; set; } = string.Empty;
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public string UsuarioCreacion { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
        public string UsuarioActualizacion { get; set; } = string.Empty;
        public DateTime FechaActualizacion { get; set; }
        public int CodigoEmpresa { get; set; }

    }
}
