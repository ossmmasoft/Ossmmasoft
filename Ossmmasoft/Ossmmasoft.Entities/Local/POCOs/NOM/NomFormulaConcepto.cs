namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomFormulaConcepto
    {
        public int Id { get; set; }
        public int? CodigoConcepto { get; set; }
        public decimal? Porcentaje { get; set; }
        public decimal? MontoTope { get; set; }
        public string TipoSueldo { get; set; } = string.Empty;
        public DateOnly? FechaDesde { get; set; }
        public DateOnly? FechaHasta { get; set; }
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public string Complemento4 { get; set; } = string.Empty;
        public string Complemento5 { get; set; } = string.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public decimal? PorcentajePatronal { get; set; }


        public virtual NomConcepto CodigoConceptoNavigation { get; set; }
    }
}
