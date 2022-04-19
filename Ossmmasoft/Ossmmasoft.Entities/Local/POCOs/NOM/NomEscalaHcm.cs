namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomEscalaHcm
    {
        public int Id { get; set; }
        public int? AseguradoraId { get; set; }
        public int? ParienteId { get; set; }
        public char? Sexo { get; set; }
        public int? EdadMin { get; set; }
        public int? EdadMax { get; set; }
        public decimal Prima { get; set; }
        public string Observacion { get; set; } = string.Empty;
        public DateOnly? FechaDesde { get; set; }
        public DateOnly? FechaHasta { get; set; }
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActuaclizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }

        public virtual NomDescriptiva Aseguradora { get; set; }
        public virtual NomDescriptiva Pariente { get; set; }
    }
}
