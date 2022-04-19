namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomAnticipoPrestaciones
    {
        public int Id { get; set; }
        public int CodigoPersona { get; set; }
        public DateOnly FechaAnticipo { get; set; }
        public int MotivoAnticipoId { get; set; }
        public decimal MontoAnticipo { get; set; }
        public string Observacion { get; set; } = String.Empty;
        public string Complemento1 { get; set; } = String.Empty;
        public string Complemento2 { get; set; } = String.Empty;
        public string Complemento3 { get; set; } = String.Empty;
        public int UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacions { get; set; }
        public int UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int CodigoEmpresa { get; set; }

        public virtual NomPersona? CodigoPersonaNavigation { get; set; }
        public virtual NomDescriptiva? MotivoAnticipo { get; set; }
    }
}
