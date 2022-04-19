namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomBecado
    {
        public NomBecado()
        {
            NomHistoricoBecados = new HashSet<NomHistoricoBecado>();
        }

        public int Id { get; set; }
        public int CodigoTipoNomina { get; set; }
        public int CodigoPersona { get; set; }
        public int CodigoFamiliar { get; set; }
        public decimal Monto { get; set; }
        public DateOnly? FechaDesde { get; set; }
        public DateOnly? FechaHasta { get; set; }
        public string Complemento1 { get; set; } = String.Empty;
        public string Complemento2 { get; set; } = String.Empty;
        public string Complemento3 { get; set; } = String.Empty;
        public int? UsuarioCeacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int CodigoEmpresa { get; set; }
        public string Observacion { get; set; } = String.Empty;
        public string Complemento4 { get; set; } = String.Empty;
        public string Complemento5 { get; set; } = String.Empty;

        public virtual NomPersona CodigoPersona1 { get; set; }
        public virtual NomFamiliares CodigoPersonaNavigation { get; set; }
        public virtual NomTiposNomina CodigoTipoNominaNavigation { get; set; }
        public virtual ICollection<NomHistoricoBecado> NomHistoricoBecados { get; set; }
    }
}
