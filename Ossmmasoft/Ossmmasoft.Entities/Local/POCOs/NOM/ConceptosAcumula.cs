namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class ConceptosAcumula
    {
        public int Id { get; set; }
        public int? CodigoConcepto { get; set; }
        public string TipoAcumuladoId { get; set; } = String.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public string Complemento1 { get; set; } = String.Empty;
        public string Complemento2 { get; set; } = String.Empty;
        public string Complemento3 { get; set; } = String.Empty;
        public int? CodigoConceptoAsociado { get; set; }
        public DateOnly? FechaDesde { get; set; }
        public DateOnly? FechaHasta { get; set; }

        public virtual NomConcepto? CodigoConceptoAsociadoNavigation { get; set; }
        public virtual NomConcepto? CodigoConceptoNavigation { get; set; }
    }
}
