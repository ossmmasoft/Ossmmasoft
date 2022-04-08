namespace Ossmmasoft.DTOs.Local.PreTitulo
{
    public class UpdatePreTituloDTO
    {
        public int Id { get; init; }
        public int TituloPadreId { get; init; }
        public string Titulo { get; init; } = string.Empty;
        public string Codigo { get; init; } = string.Empty;
        public string Complemento1 { get; init; } = string.Empty;
        public string Complemento2 { get; init; } = string.Empty;
        public string Complemento3 { get; init; } = string.Empty;
        public string UsuarioActualizacion { get; init; } = string.Empty;
        public string UsuarioCreacion { get; init; } = string.Empty;
        public DateTime FechaCreacion { get; init; }
        public DateTime FechaActualizacion { get; init; }
        public int CodigoEmpresa { get; init; }
    }
}
