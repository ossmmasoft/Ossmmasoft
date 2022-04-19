namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomHorario
    {
        public NomHorario()
        {
            NomHorarioPersonaCodigoHdomNavigations = new HashSet<NomHorarioPersona>();
            NomHorarioPersonaCodigoHjueNavigations = new HashSet<NomHorarioPersona>();
            NomHorarioPersonaCodigoHlunNavigations = new HashSet<NomHorarioPersona>();
            NomHorarioPersonaCodigoHmarNavigations = new HashSet<NomHorarioPersona>();
            NomHorarioPersonaCodigoHmieNavigations = new HashSet<NomHorarioPersona>();
            NomHorarioPersonaCodigoHsabNavigations = new HashSet<NomHorarioPersona>();
            NomHorarioPersonaCodigoHvieNavigations = new HashSet<NomHorarioPersona>();
        }

        public int Id { get; set; }
        public int? CodigoTipoNomina { get; set; }
        public string NumeroHorario { get; set; }
        public string NombreHorario { get; set; }
        public DateOnly? InPrincipal { get; set; }
        public DateOnly? OutPrincipal { get; set; }
        public DateOnly? InSecundaria { get; set; }
        public DateOnly? OutSecundaria { get; set; }
        public int? Halmuerzo { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public string Complemento4 { get; set; }
        public string Complemento5 { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }

        public virtual NomTiposNomina CodigoTipoNominaNavigation { get; set; }
        public virtual ICollection<NomHorarioPersona> NomHorarioPersonaCodigoHdomNavigations { get; set; }
        public virtual ICollection<NomHorarioPersona> NomHorarioPersonaCodigoHjueNavigations { get; set; }
        public virtual ICollection<NomHorarioPersona> NomHorarioPersonaCodigoHlunNavigations { get; set; }
        public virtual ICollection<NomHorarioPersona> NomHorarioPersonaCodigoHmarNavigations { get; set; }
        public virtual ICollection<NomHorarioPersona> NomHorarioPersonaCodigoHmieNavigations { get; set; }
        public virtual ICollection<NomHorarioPersona> NomHorarioPersonaCodigoHsabNavigations { get; set; }
        public virtual ICollection<NomHorarioPersona> NomHorarioPersonaCodigoHvieNavigations { get; set; }
    }
}
