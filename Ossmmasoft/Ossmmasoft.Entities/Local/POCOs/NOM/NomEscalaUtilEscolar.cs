namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomEscalaUtilEscolar
    {
        public int Id { get; set; }
        public int? ParienteId { get; set; }
        public int? NivelEducativoId { get; set; }
        public int? Grado { get; set; }
        public decimal Monto { get; set; }
        public DateOnly FechaDesde { get; set; }
        public DateOnly? FechaHasta { get; set; }
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? CodigoTipoNomina { get; set; }
        public string Complemento4 { get; set; } = string.Empty;
        public string Complemento5 { get; set; } = string.Empty;

        public virtual NomTiposNomina CodigoTipoNominaNavigation { get; set; }
        public virtual PreDescriptiva NivelEducativo { get; set; }
        public virtual NomDescriptiva Pariente { get; set; }
    }
}
