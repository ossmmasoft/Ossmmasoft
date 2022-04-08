using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomExperienciaLaboral
    {
        public decimal Id { get; set; }
        public decimal? CodigoPersona { get; set; }
        public string NombreEmpresa { get; set; }
        public string TipoEmpresa { get; set; }
        public decimal? RamoId { get; set; }
        public string Cargo { get; set; }
        public DateOnly? FechaDesde { get; set; }
        public DateOnly? FechaHasta { get; set; }
        public decimal? UltimoSueldo { get; set; }
        public string Supervisor { get; set; }
        public string CargoSupervisor { get; set; }
        public string Telefono { get; set; }
        public string Descripcion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public string Complemento4 { get; set; }
        public string Complemento5 { get; set; }

        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomDescriptiva Ramo { get; set; }
    }
}
