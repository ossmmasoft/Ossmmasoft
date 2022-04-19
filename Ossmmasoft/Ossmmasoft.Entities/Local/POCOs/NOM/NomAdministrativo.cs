namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomAdministrativo
    {
        public int Id { get; set; }
        public int CodigoPersona { get; set; }
        public int CargoId { get; set; }
        public DateOnly FechaIngreso { get; set; }
        public string TipoPago { get; set; } = String.Empty;
        public int BancoId { get; set; }
        public int TipoCuentaId { get; set; }
        public string NroCuenta { get; set; } = String.Empty;
        public string Turno { get; set; } = String.Empty;
        public int ProfesionId { get; set; }
        public string Status { get; set; } = String.Empty;
        public int UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int CodigoEmpresa { get; set; }
        public string Complemento1 { get; set; } = String.Empty;
        public string Complemento2 { get; set; } = String.Empty;
        public string Complemento3 { get; set; } = String.Empty;
        public string Complemento4 { get; set; } = String.Empty;
        public string Complemento5 { get; set; } = String.Empty;

        public virtual NomDescriptiva? Banco { get; set; }
        public virtual NomDescriptiva? Cargo { get; set; }
        public virtual NomPersona? CodigoPersonaNavigation { get; set; }
        public virtual NomDescriptiva? TipoCuenta { get; set; }
    }
}
