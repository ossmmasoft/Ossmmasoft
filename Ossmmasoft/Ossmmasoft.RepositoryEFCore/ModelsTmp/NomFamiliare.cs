using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomFamiliare
    {
        public NomFamiliare()
        {
            NomBecados = new HashSet<NomBecado>();
            NomHcms = new HashSet<NomHcm>();
            NomHistoricoBecados = new HashSet<NomHistoricoBecado>();
        }

        public decimal? CodigoPersona { get; set; }
        public decimal Id { get; set; }
        public decimal? CedulaFamiliar { get; set; }
        public string Nacionalidad { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateOnly? FechaNacimiento { get; set; }
        public decimal? ParienteId { get; set; }
        public string Sexo { get; set; }
        public decimal? NivelEducativoId { get; set; }
        public decimal? Grado { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }

        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomDescriptiva NivelEducativo { get; set; }
        public virtual ICollection<NomBecado> NomBecados { get; set; }
        public virtual ICollection<NomHcm> NomHcms { get; set; }
        public virtual ICollection<NomHistoricoBecado> NomHistoricoBecados { get; set; }
    }
}
