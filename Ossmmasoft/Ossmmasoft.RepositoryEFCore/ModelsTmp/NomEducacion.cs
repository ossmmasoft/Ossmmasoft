using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomEducacion
    {
        public decimal Id { get; set; }
        public decimal? CodigoPersona { get; set; }
        public decimal? NivelId { get; set; }
        public string NombreInstituto { get; set; }
        public string LocalidadInstituto { get; set; }
        public decimal? ProfesionId { get; set; }
        public DateOnly FechaInicio { get; set; }
        public DateOnly? FechaFin { get; set; }
        public decimal? UltimoAñoAprobado { get; set; }
        public string Graduado { get; set; }
        public decimal? TituloId { get; set; }
        public decimal? MencionEspecialidadId { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioIns { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public string Complemento4 { get; set; }
        public string Complemento5 { get; set; }

        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomDescriptiva MencionEspecialidad { get; set; }
        public virtual NomDescriptiva Nivel { get; set; }
        public virtual NomDescriptiva Profesion { get; set; }
        public virtual NomDescriptiva Titulo { get; set; }
    }
}
