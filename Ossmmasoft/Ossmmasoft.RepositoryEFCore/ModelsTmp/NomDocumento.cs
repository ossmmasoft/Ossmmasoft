using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomDocumento
    {
        public NomDocumento()
        {
            NomDocumentosDetalles = new HashSet<NomDocumentosDetalle>();
        }

        public decimal? CodigoPersona { get; set; }
        public decimal Id { get; set; }
        public decimal? TipoDocumentoId { get; set; }
        public string NumeroDocumento { get; set; }
        public DateOnly? FechaVencimiento { get; set; }
        public decimal? TipoGradoId { get; set; }
        public decimal? GradoId { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActuaclizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public string Complemento4 { get; set; }
        public string Complemento5 { get; set; }

        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomDescriptiva Grado { get; set; }
        public virtual NomDescriptiva TipoDocumento { get; set; }
        public virtual NomDescriptiva TipoGrado { get; set; }
        public virtual ICollection<NomDocumentosDetalle> NomDocumentosDetalles { get; set; }
    }
}
