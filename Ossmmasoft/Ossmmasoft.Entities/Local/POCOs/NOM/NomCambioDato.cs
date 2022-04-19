namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomCambioDato
    {
        public int Id { get; set; }
        public int CodigoPersona { get; set; }
        public string Tabla { get; set; } = String.Empty;
        public string Campo { get; set; } = String.Empty;
        public string DatoOld { get; set; } = String.Empty;
        public string DatoNew { get; set; } = String.Empty;
        public string Observacion { get; set; } = String.Empty;
        public string Complemento1 { get; set; } = String.Empty;
        public string Complemento2 { get; set; } = String.Empty;
        public string Complemento3 { get; set; } = String.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int CodigoEmpresa { get; set; }

        public virtual NomPersona CodigoPersonaNavigation { get; set; }
    }
}
