using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomDescuentoLey
    {
        public NomDescuentoLey()
        {
            NomDescuentoLeyTrabajadors = new HashSet<NomDescuentoLeyTrabajador>();
        }

        public decimal Id { get; set; }
        public decimal? CodigoTipoNomina { get; set; }
        public decimal? CodigoConcepto { get; set; }
        public decimal? CodigoDescuentoLeyId { get; set; }
        public decimal? LeyId { get; set; }
        public DateOnly? FechaVigenciaLey { get; set; }
        public decimal? PorMinTrabajador { get; set; }
        public decimal? PorMaxTrabajador { get; set; }
        public decimal? PorMinPatrono { get; set; }
        public decimal? PorMaxPatrono { get; set; }
        public decimal? MontoMinCalculado { get; set; }
        public decimal? MontoMaxCalculado { get; set; }
        public decimal? CodigoConceptoPendiente { get; set; }
        public decimal? CodigoConceptoReintegro { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }

        public virtual NomConcepto CodigoConceptoNavigation { get; set; }
        public virtual NomDescriptiva CodigoDescuentoLey { get; set; }
        public virtual NomTiposNomina CodigoTipoNominaNavigation { get; set; }
        public virtual NomDescriptiva Ley { get; set; }
        public virtual ICollection<NomDescuentoLeyTrabajador> NomDescuentoLeyTrabajadors { get; set; }
    }
}
