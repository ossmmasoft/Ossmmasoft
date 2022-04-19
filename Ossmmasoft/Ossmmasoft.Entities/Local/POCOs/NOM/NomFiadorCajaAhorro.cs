namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomFiadorCajaAhorro
    {
        public int Id { get; set; }
        public int? CodigoPreCajaAho { get; set; }
        public int? CodigoPersonaFiador { get; set; }
        public decimal? MontoFianza { get; set; }
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacions { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public string Complemento4 { get; set; } = string.Empty;
        public string Complemento5 { get; set; } = string.Empty;
    }
}
