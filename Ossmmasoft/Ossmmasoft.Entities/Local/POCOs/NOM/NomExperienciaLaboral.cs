namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomExperienciaLaboral
    {
        public int Id { get; set; }
        public int? CodigoPersona { get; set; }
        public string NombreEmpresa { get; set; } = string.Empty;
        public string TipoEmpresa { get; set; } = string.Empty;
        public int? RamoId { get; set; }
        public string Cargo { get; set; } = string.Empty;
        public DateOnly? FechaDesde { get; set; }
        public DateOnly? FechaHasta { get; set; }
        public decimal? UltimoSueldo { get; set; }
        public string Supervisor { get; set; } = string.Empty;
        public string CargoSupervisor { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public int UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public string Complemento4 { get; set; } = string.Empty;
        public string Complemento5 { get; set; } = string.Empty;

        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomDescriptiva Ramo { get; set; }
    }
}
