namespace Ossmmasoft.DTOs.Local.PreTitulo
{
    public class CreatePreTituloDTO
    {
        public int Id { get; set; }
        public int TituloPadreId { get; init; }
        public string Titulo { get; init; } = string.Empty;
        public string Codigo { get; init; } = string.Empty;
        public string Complemento1 { get; init; } = string.Empty;
        public string Complemento2 { get; init; } = string.Empty;
        public string Complemento3 { get; init; } = string.Empty;
        public int UsuarioActualizacion { get; init; }
        public int UsuarioCreacion { get; init; }
        public DateTime FechaCreacion { get; init; }
        public DateTime FechaActualizacion { get; init; }
        public int CodigoEmpresa { get; init; }
    }
}
