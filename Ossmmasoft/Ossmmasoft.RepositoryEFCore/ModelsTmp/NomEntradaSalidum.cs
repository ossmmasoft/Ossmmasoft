using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomEntradaSalidum
    {
        public decimal Id { get; set; }
        public decimal? CodigoPersona { get; set; }
        public DateOnly FechaMov { get; set; }
        public string TipoMov { get; set; }
        public string Status { get; set; }
        public decimal? Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal? PersonaHorarioId { get; set; }
        public string Complemento4 { get; set; }
        public string Complemento5 { get; set; }
        public string Complemento6 { get; set; }
        public string Complemento7 { get; set; }
        public string Complemento8 { get; set; }
        public string Complemento9 { get; set; }
        public string Complemento10 { get; set; }
        public string Complemento11 { get; set; }
        public string Complemento12 { get; set; }
        public string Complemento13 { get; set; }
        public string Complemento14 { get; set; }
        public string Complemento15 { get; set; }

        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomDescriptiva PersonaHorario { get; set; }
    }
}
