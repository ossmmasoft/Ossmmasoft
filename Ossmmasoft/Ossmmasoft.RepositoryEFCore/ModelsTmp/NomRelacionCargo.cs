using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomRelacionCargo
    {
        public NomRelacionCargo()
        {
            NomEgresos = new HashSet<NomEgreso>();
            NomPromocioneCodigoRelacionCargoNewNavigations = new HashSet<NomPromocione>();
            NomPromocioneCodigoRelacionCargoOldNavigations = new HashSet<NomPromocione>();
        }

        public decimal Id { get; set; }
        public decimal? CodigoTipoNomina { get; set; }
        public decimal? CodigoIcp { get; set; }
        public decimal? CodigoIcpUbicacion { get; set; }
        public decimal? CodigoCargo { get; set; }
        public string CargoCodigo { get; set; }
        public decimal? CodigoPersona { get; set; }
        public decimal? Sueldo { get; set; }
        public DateOnly? FechaInicial { get; set; }
        public DateOnly? FechaFinal { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal CodigoRelacionCargoPre { get; set; }
        public decimal? CodigoPresupuesto { get; set; }
        public DateOnly? FechaIniVigencia { get; set; }
        public DateOnly? FechaFinVigencia { get; set; }

        public virtual PreCargo CodigoCargoNavigation { get; set; }
        public virtual PreIndiceCatPrg CodigoIcpNavigation { get; set; }
        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual PrePresupuesto CodigoPresupuestoNavigation { get; set; }
        public virtual PreRelacionCargo CodigoRelacionCargoPreNavigation { get; set; }
        public virtual NomTiposNomina CodigoTipoNominaNavigation { get; set; }
        public virtual ICollection<NomEgreso> NomEgresos { get; set; }
        public virtual ICollection<NomPromocione> NomPromocioneCodigoRelacionCargoNewNavigations { get; set; }
        public virtual ICollection<NomPromocione> NomPromocioneCodigoRelacionCargoOldNavigations { get; set; }
    }
}
