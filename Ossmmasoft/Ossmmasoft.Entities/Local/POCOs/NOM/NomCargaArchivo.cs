namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomCargaArchivo
    {
        public int Id { get; set; }
        public int CodigoCargaArchivoControl { get; set; }
        public int CodigoPersona { get; set; }
        public int Cedula { get; set; }
        public decimal Monto { get; set; }
        public string Complemento1 { get; set; } = String.Empty;
        public string Complemento2 { get; set; } = String.Empty;
        public string Complemento3 { get; set; } = String.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? CodigoMovNomina { get; set; }
        public string Complemento4 { get; set; } = String.Empty;
        public string Complemento5 { get; set; } = String.Empty;

        public virtual CargaArchivoControl? CodigoCargaArchivoControlNavigation { get; set; }
        public virtual NomMovimientoNomina? CodigoMovNominaNavigation { get; set; }
        public virtual NomPersona? CodigoPersonaNavigation { get; set; }
    }
}
