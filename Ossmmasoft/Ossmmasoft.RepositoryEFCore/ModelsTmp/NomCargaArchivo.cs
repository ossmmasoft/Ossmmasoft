using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomCargaArchivo
    {
        public decimal Id { get; set; }
        public decimal? CodigoCargaArchivoControl { get; set; }
        public decimal? CodigoPersona { get; set; }
        public decimal? Cedula { get; set; }
        public decimal Monto { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal? CodigoMovNomina { get; set; }
        public string Complemento4 { get; set; }
        public string Complemento5 { get; set; }

        public virtual CargaArchivoControl CodigoCargaArchivoControlNavigation { get; set; }
        public virtual NomMovimientoNomina CodigoMovNominaNavigation { get; set; }
        public virtual NomPersona CodigoPersonaNavigation { get; set; }
    }
}
