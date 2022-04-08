using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomMovimientoNomina
    {
        public NomMovimientoNomina()
        {
            NomCargaArchivos = new HashSet<NomCargaArchivo>();
        }

        public decimal Id { get; set; }
        public decimal? CodigoTipoNomina { get; set; }
        public decimal? CodigoPersona { get; set; }
        public decimal? CodigoConcepto { get; set; }
        public string ComplementoConcepto { get; set; }
        public string Tipo { get; set; }
        public decimal? FrecuenciaId { get; set; }
        public decimal? Monto { get; set; }
        public string Status { get; set; }
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

        public virtual NomConcepto CodigoConceptoNavigation { get; set; }
        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomTiposNomina CodigoTipoNominaNavigation { get; set; }
        public virtual NomDescriptiva Frecuencia { get; set; }
        public virtual ICollection<NomCargaArchivo> NomCargaArchivos { get; set; }
    }
}
