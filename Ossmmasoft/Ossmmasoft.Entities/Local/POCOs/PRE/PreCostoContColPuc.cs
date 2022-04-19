namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreCostoContColPuc
    {
        public int? Id { get; set; }
        public int? CodigoCostoContCol { get; set; }
        public int? CodigoPuc { get; set; }
        public decimal? Monto { get; set; }
        public string BaseCalculo { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public int? UsuarioIns { get; set; }
        public DateOnly? FechaIns { get; set; }
        public int? UsuarioUpd { get; set; }
        public DateOnly? FechaUpd { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? CodigoPresupuesto { get; set; }
    }
}
