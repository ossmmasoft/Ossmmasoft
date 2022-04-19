namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreSaldosIngreso
    {
        public int Id { get; set; }
        public int? CodigoPuc { get; set; }
        public decimal? Presupuestado { get; set; }
        public decimal? Recaudado { get; set; }
        public string Complemento1 { get; set; } = String.Empty;
        public string Complemento2 { get; set; } = String.Empty;
        public string Complemento3 { get; set; } = String.Empty;
        public int? UsuarioIns { get; set; }
        public DateOnly? FechaIns { get; set; }
        public int? UsuarioUpd { get; set; }
        public DateOnly? FechaUpd { get; set; }
        public int? CodigoPresupuesto { get; set; }
        public int? CodigoEmpresa { get; set; }
    }
}
