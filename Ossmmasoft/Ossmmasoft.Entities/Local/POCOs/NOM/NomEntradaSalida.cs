namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomEntradaSalida
    {
        public int Id { get; set; }
        public int? CodigoPersona { get; set; }
        public DateOnly FechaMov { get; set; }
        public string TipoMov { get; set; } = String.Empty;
        public string Status { get; set; } = String.Empty;
        public int? Complemento1 { get; set; }
        public string Complemento2 { get; set; } = String.Empty;
        public string Complemento3 { get; set; } = String.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? PersonaHorarioId { get; set; }
        public string Complemento4 { get; set; } = String.Empty;
        public string Complemento5 { get; set; } = String.Empty;
        public string Complemento6 { get; set; } = String.Empty;
        public string Complemento7 { get; set; } = String.Empty;
        public string Complemento8 { get; set; } = String.Empty;
        public string Complemento9 { get; set; } = String.Empty;
        public string Complemento10 { get; set; } = String.Empty;
        public string Complemento11 { get; set; } = String.Empty;
        public string Complemento12 { get; set; } = String.Empty;
        public string Complemento13 { get; set; } = String.Empty;
        public string Complemento14 { get; set; } = String.Empty;
        public string Complemento15 { get; set; } = String.Empty;

        public virtual NomPersona? CodigoPersonaNavigation { get; set; }
        public virtual NomDescriptiva? PersonaHorario { get; set; }
    }
}
