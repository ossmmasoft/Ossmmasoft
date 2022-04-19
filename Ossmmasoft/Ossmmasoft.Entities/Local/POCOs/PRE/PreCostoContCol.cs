namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreCostoContCol
    {
        public int? Id { get; set; }
        public int? NumeroClausula { get; set; }
        public DateOnly FechaIni { get; set; }
        public DateOnly FechaFin { get; set; }
        public string Denominacion { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public int? UsuarioIns { get; set; }
        public DateOnly? FechaIns { get; set; }
        public int? UsuarioUpd { get; set; }
        public DateOnly? FechaUpd { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? TipoNomina { get; set; }
        public int? CodigoPresupuesto { get; set; }
    }
}
