namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomHcm
    {
        public int Id { get; set; }
        public int? CodigoPersona { get; set; }
        public int? CodigoFamiliar { get; set; }
        public int? AseguradoraId { get; set; }
        public decimal PrimaAsegurado { get; set; }
        public decimal AporteAsegurado { get; set; }
        public decimal AportePatron { get; set; }
        public char? TipoAportePatron { get; set; }
        public DateOnly? FechaDesde { get; set; }
        public DateOnly? FechaHasta { get; set; }
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public string Complemento4 { get; set; } = string.Empty;
        public string Complemento5 { get; set; } = string.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }

        public virtual NomDescriptiva Aseguradora { get; set; }
        public virtual NomFamiliares CodigoFamiliarNavigation { get; set; }
        public virtual NomPersona CodigoPersonaNavigation { get; set; }
    }
}
