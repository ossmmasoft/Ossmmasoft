namespace Ossmmasoft.DTOs.Local.PreDescriptiva
{
    public class PreDescriptivaDto
    {
        public int Id { get; set; }
        public int? DescripcionPadreId { get; set; }
        public int? PreTituloId { get; set; }
        public string Descripcion { get; set; }
        public string Codigo { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public string Complemento4 { get; set; }
        public string Complemento5 { get; set; }
        public int? CodigoEmpresa { get; set; }

    }
}
