namespace Ossmmasoft.DTOs.Local.PreTitulo
{
    public class PreTituloDTO
    {

        public int Id { get; init; }
        public int TituloPadreId { get; init; }
        public string Titulo { get; init; } = string.Empty;
        public string Codigo { get; init; } = string.Empty;
        public string Complemento1 { get; init; } = string.Empty;
        public string Complemento2 { get; init; } = string.Empty;
        public string Complemento3 { get; init; } = string.Empty;
        public int CodigoEmpresa { get; set; }

    }
}
