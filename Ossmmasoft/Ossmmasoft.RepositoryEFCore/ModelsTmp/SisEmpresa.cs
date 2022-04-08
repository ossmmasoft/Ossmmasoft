using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class SisEmpresa
    {
        public decimal Id { get; set; }
        public string NombreEmpresa { get; set; }
        public decimal? TipoEmpresaId { get; set; }
        public decimal? IdentificacionId { get; set; }
        public string NumeroIdentificacion { get; set; }
        public DateOnly? FechaInstalacion { get; set; }
        public decimal? VersionSistemaId { get; set; }
        public decimal? MarcaServidorId { get; set; }
        public decimal? SistemaOperativoId { get; set; }
        public string NombreServidor { get; set; }
        public string UnidadInstalacion { get; set; }
        public string DirectorioPrincipal { get; set; }
        public string DirectorioPrivado { get; set; }
        public string DirectorioPublico { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public string CodigoEstadoCtaFiscal { get; set; }
        public string CodigoMunicipioCtaFiscal { get; set; }
        public string Separator { get; set; }
        public decimal? Gerencial { get; set; }
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
        public decimal? DondeEstoy { get; set; }
    }
}
