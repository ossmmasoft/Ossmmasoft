namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomVacacionesVencida
    {
        public int Id { get; set; }
        public int CodigoPersona { get; set; }
        public int AñoPeriodo { get; set; }
        public DateOnly? FechaVencimiento { get; set; }
        public decimal? DiasVencidos { get; set; }
        public decimal? DiasDisfrutados { get; set; }
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

        public virtual NomPersona CodigoPersonaNavigation { get; set; }
    }
}
