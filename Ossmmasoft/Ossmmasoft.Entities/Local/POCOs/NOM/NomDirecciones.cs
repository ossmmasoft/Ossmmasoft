namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomDirecciones
    {
        public int Id { get; set; }
        public int CodigoPersona { get; set; }
        public int? DireccionId { get; set; }
        public int? PaisId { get; set; }
        public int? EstadoId { get; set; }
        public int? MunicipioId { get; set; }
        public int? CiudadId { get; set; }
        public int? ParroquiaId { get; set; }
        public int? SectorId { get; set; }
        public int? UrbanizacionId { get; set; }
        public int? ManzanaId { get; set; }
        public int? ParcelaId { get; set; }
        public int? VialidadId { get; set; }
        public string Vialidad { get; set; } = string.Empty;
        public int? TipoViviendaId { get; set; }
        public int? ViviendaId { get; set; }
        public string Vivienda { get; set; } = string.Empty;
        public int? TipoNivelId { get; set; }
        public string Nivel { get; set; } = string.Empty;
        public string NroVivienda { get; set; } = string.Empty;
        public string ComplementoDir { get; set; } = string.Empty;
        public int? TenenciaId { get; set; }
        public int? CodigoPostal { get; set; }
        public int? Principal { get; set; }
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

        public virtual NomDescriptiva? Ciudad { get; set; }
        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomDescriptiva Direccion { get; set; }
        public virtual NomDescriptiva Estado { get; set; }
        public virtual NomDescriptiva Manzana { get; set; }
        public virtual NomDescriptiva Municipio { get; set; }
        public virtual NomDescriptiva Pais { get; set; }
        public virtual NomDescriptiva Parcela { get; set; }
        public virtual NomDescriptiva Parroquia { get; set; }
        public virtual NomDescriptiva Sector { get; set; }
        public virtual NomDescriptiva Tenencia { get; set; }
        public virtual NomDescriptiva TipoNivel { get; set; }
        public virtual NomDescriptiva TipoVivienda { get; set; }
        public virtual NomDescriptiva Urbanizacion { get; set; }
        public virtual NomDescriptiva VialidadNavigation { get; set; }
        public virtual NomDescriptiva ViviendaNavigation { get; set; }
    }
}
