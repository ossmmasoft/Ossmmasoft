namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomEducacion
    {
        public int Id { get; set; }
        public int? CodigoPersona { get; set; }
        public int? NivelId { get; set; }
        public string NombreInstituto { get; set; } = string.Empty;
        public string LocalidadInstituto { get; set; } = string.Empty;
        public int? ProfesionId { get; set; }
        public DateOnly FechaInicio { get; set; }
        public DateOnly? FechaFin { get; set; }
        public int? UltimoAñoAprobado { get; set; }
        public string Graduado { get; set; } = string.Empty;
        public int? TituloId { get; set; }
        public int? MencionEspecialidadId { get; set; }
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public int? UsuarioIns { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public string Complemento4 { get; set; } = string.Empty;
        public string Complemento5 { get; set; } = string.Empty;

        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomDescriptiva MencionEspecialidad { get; set; }
        public virtual NomDescriptiva Nivel { get; set; }
        public virtual NomDescriptiva Profesion { get; set; }
        public virtual NomDescriptiva Titulo { get; set; }
    }
}
