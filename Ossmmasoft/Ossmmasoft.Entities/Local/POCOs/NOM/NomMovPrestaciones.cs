namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomMovPrestaciones
    {
        public int Id { get; set; }
        public int CodigoPersona { get; set; }
        public int ConceptoId { get; set; }
        public string ComplementoConcepto { get; set; } = string.Empty;
        public DateOnly Fecha { get; set; }
        public decimal Monto { get; set; }
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }

        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomDescriptiva Concepto { get; set; }
    }
}
