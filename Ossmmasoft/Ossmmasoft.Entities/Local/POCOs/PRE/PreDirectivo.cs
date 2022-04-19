namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreDirectivo
    {
        public int? Id { get; set; }
        public int? CodigoIdentificacion { get; set; }
        public int? TipoDirectivoId { get; set; }
        public int? TituloId { get; set; }
        public int? Cedula { get; set; }
        public string Nombre { get; set; } = String.Empty;
        public string Apellido { get; set; } = String.Empty;
        public string Cargo { get; set; } = String.Empty;
        public string Extra1 { get; set; } = String.Empty;
        public string Extra2 { get; set; } = String.Empty;
        public string Extra3 { get; set; } = String.Empty;
        public int? UsuarioIns { get; set; }
        public DateOnly? FechaIns { get; set; }
        public int? UsuarioUpd { get; set; }
        public DateOnly? FechaUpd { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? CodigoPresupuesto { get; set; }
    }
}
