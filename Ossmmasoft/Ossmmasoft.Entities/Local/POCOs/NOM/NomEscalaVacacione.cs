namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomEscalaVacacione
    {
        public int Id { get; set; }
        public int? CantidadAños { get; set; }
        public int? CantidadDiasHabiles { get; set; }
        public int? CantidadDiasBonos { get; set; }
        public DateOnly? FechaInicio { get; set; }
        public DateOnly? FechaFin { get; set; }
        public string Observacion { get; set; } = string.Empty;
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public string Complemento4 { get; set; } = string.Empty;
        public string Complemento5 { get; set; } = string.Empty;
    }
}
