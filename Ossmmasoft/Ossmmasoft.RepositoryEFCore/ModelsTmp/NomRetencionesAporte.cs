using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomRetencionesAporte
    {
        public decimal Id { get; set; }
        public decimal? CodigoPersona { get; set; }
        public decimal? Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal? CodigoTipoNomina { get; set; }
        public string CodigoRetencion { get; set; }
        public DateOnly? FechaNomina { get; set; }
        public decimal? MontoBase { get; set; }
        public decimal? MontoRt { get; set; }
        public decimal? MontoAp { get; set; }
        public decimal? MontoTotal { get; set; }
        public decimal? UsuarioCeacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }

        public virtual NomPersona CodigoPersonaNavigation { get; set; }
    }
}
