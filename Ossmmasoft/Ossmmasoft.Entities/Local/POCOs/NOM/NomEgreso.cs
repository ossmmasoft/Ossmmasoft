namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomEgreso
    {
        public int Id { get; set; }
        public int? CodigoPersona { get; set; }
        public int? CodigoRelacionCargo { get; set; }
        public int? TipoEgresoId { get; set; }
        public string Observaciones { get; set; } = string.Empty;
        public DateOnly? FechaEgreso { get; set; }
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }

        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomRelacionCargo CodigoRelacionCargoNavigation { get; set; }
        public virtual NomDescriptiva TipoEgreso { get; set; }
    }
}
