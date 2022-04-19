namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomVacacionesDisfrutada
    {
        public int Id { get; set; }
        public int CodigoPersona { get; set; }
        public int CodigoPeriodo { get; set; }
        public DateOnly? FechaDesde { get; set; }
        public DateOnly? FechaHasta { get; set; }
        public decimal DiasHabiles { get; set; }
        public decimal CobroAdelantoSueldo { get; set; }
        public decimal CobroBonoVacacional { get; set; }
        public string NumeroOficioIncorporacion { get; set; } = string.Empty;
        public DateOnly? FechaIncorporacion { get; set; }
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

        public virtual NomPeriodo CodigoPeriodoNavigation { get; set; }
        public virtual NomPersona CodigoPersonaNavigation { get; set; }
    }
}
