namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomControlHorario
    {
        public int Id { get; set; }
        public int CodigoTipoNomina { get; set; }
        public int CodigoPersona { get; set; }
        public DateOnly FechaDesde { get; set; }
        public DateOnly FechaHasta { get; set; }
        public int TipoHoraId { get; set; }
        public int? Horas { get; set; }
        public string Complemento1 { get; set; } = String.Empty;
        public string Complemento2 { get; set; } = String.Empty;
        public string Complemento3 { get; set; } = String.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int CodigoEmpresa { get; set; }

        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomTiposNomina CodigoTipoNominaNavigation { get; set; }
    }
}
