using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomDireccione
    {
        public decimal Id { get; set; }
        public decimal? CodigoPersona { get; set; }
        public decimal? DireccionId { get; set; }
        public decimal? PaisId { get; set; }
        public decimal? EstadoId { get; set; }
        public decimal? MunicipioId { get; set; }
        public decimal? CiudadId { get; set; }
        public decimal? ParroquiaId { get; set; }
        public decimal? SectorId { get; set; }
        public decimal? UrbanizacionId { get; set; }
        public decimal? ManzanaId { get; set; }
        public decimal? ParcelaId { get; set; }
        public decimal? VialidadId { get; set; }
        public string Vialidad { get; set; }
        public decimal? TipoViviendaId { get; set; }
        public decimal? ViviendaId { get; set; }
        public string Vivienda { get; set; }
        public decimal? TipoNivelId { get; set; }
        public string Nivel { get; set; }
        public string NroVivienda { get; set; }
        public string ComplementoDir { get; set; }
        public decimal? TenenciaId { get; set; }
        public decimal? CodigoPostal { get; set; }
        public decimal? Principal { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public string Complemento4 { get; set; }
        public string Complemento5 { get; set; }

        public virtual NomDescriptiva Ciudad { get; set; }
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
