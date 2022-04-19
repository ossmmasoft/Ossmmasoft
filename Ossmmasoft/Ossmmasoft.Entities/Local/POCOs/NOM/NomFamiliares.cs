namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomFamiliares
    {
        public NomFamiliares()
        {
            NomBecados = new HashSet<NomBecado>();
            NomHcms = new HashSet<NomHcm>();
            NomHistoricoBecados = new HashSet<NomHistoricoBecado>();
        }

        public int Id { get; set; }
        public int? CodigoPersona { get; set; }
        public int? CedulaFamiliar { get; set; }
        public string Nacionalidad { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public DateOnly? FechaNacimiento { get; set; }
        public int? ParienteId { get; set; }
        public string Sexo { get; set; } = string.Empty;
        public int? NivelEducativoId { get; set; }
        public int? Grado { get; set; }
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }

        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomDescriptiva NivelEducativo { get; set; }
        public virtual ICollection<NomBecado> NomBecados { get; set; }
        public virtual ICollection<NomHcm> NomHcms { get; set; }
        public virtual ICollection<NomHistoricoBecado> NomHistoricoBecados { get; set; }
    }
}
