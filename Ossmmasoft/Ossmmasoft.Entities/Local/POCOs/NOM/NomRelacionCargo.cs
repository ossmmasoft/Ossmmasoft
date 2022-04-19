namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomRelacionCargo
    {
        public NomRelacionCargo()
        {
            NomEgresos = new HashSet<NomEgreso>();
            NomPromocioneCodigoRelacionCargoNewNavigations = new HashSet<NomPromociones>();
            NomPromocioneCodigoRelacionCargoOldNavigations = new HashSet<NomPromociones>();
        }

        public int Id { get; set; }
        public int CodigoTipoNomina { get; set; }
        public int CodigoIcp { get; set; }
        public int CodigoIcpUbicacion { get; set; }
        public int CodigoCargo { get; set; }
        public string CargoCodigo { get; set; }
        public int CodigoPersona { get; set; }
        public decimal Sueldo { get; set; }
        public DateOnly? FechaInicial { get; set; }
        public DateOnly? FechaFinal { get; set; }
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public string Complemento4 { get; set; } = string.Empty;
        public string Complemento5 { get; set; } = string.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int CodigoEmpresa { get; set; }
        public int CodigoRelacionCargoPre { get; set; }
        public int CodigoPresupuesto { get; set; }
        public DateOnly? FechaIniVigencia { get; set; }
        public DateOnly? FechaFinVigencia { get; set; }

        public virtual PreCargo CodigoCargoNavigation { get; set; }
        public virtual PreIndiceCatPrg CodigoIcpNavigation { get; set; }
        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual PrePresupuesto CodigoPresupuestoNavigation { get; set; }
        public virtual PreRelacionCargo CodigoRelacionCargoPreNavigation { get; set; }
        public virtual NomTiposNomina CodigoTipoNominaNavigation { get; set; }
        public virtual ICollection<NomEgreso> NomEgresos { get; set; }
        public virtual ICollection<NomPromociones> NomPromocioneCodigoRelacionCargoNewNavigations { get; set; }
        public virtual ICollection<NomPromociones> NomPromocioneCodigoRelacionCargoOldNavigations { get; set; }
    }
}
