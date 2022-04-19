namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreSaldosTmp
    {
        public int Id { get; set; }
        public int? Ano { get; set; }
        public int? CodigoIcp { get; set; }
        public int? CodigoPuc { get; set; }
        public int? FinanciadoId { get; set; }
        public int? CodigoFinanciado { get; set; }
        public decimal Asignacion { get; set; }
        public decimal Bloqueado { get; set; }
        public decimal Modificado { get; set; }
        public decimal Comprometido { get; set; }
        public decimal Causado { get; set; }
        public decimal Pagado { get; set; }
        public decimal Ajustado { get; set; }
        public string Complemento1 { get; set; } = String.Empty;
        public string Complemento2 { get; set; } = String.Empty;
        public string Complemento3 { get; set; } = String.Empty;
        public int? UsuarioIns { get; set; }
        public DateOnly? FechaIns { get; set; }
        public int? UsuarioUpd { get; set; }
        public DateOnly? FechaUpd { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? CodigoPresupuesto { get; set; }
        public decimal Presupuestado { get; set; }
    }
}
