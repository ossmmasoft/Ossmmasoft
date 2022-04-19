namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PrePucCompromiso
    {
        public int Id { get; set; }
        public int? CodigoDetalleCompromiso { get; set; }
        public int? CodigoPucSolicitud { get; set; }
        public int? CodigoSaldo { get; set; }
        public int? CodigoIcp { get; set; }
        public int? CodigoPuc { get; set; }
        public int? FinanciadoId { get; set; }
        public int? CodigoFinanciado { get; set; }
        public decimal Monto { get; set; }
        public decimal MontoCausado { get; set; }
        public decimal MontoAnulado { get; set; }
        public string Complemento1 { get; set; } = String.Empty;
        public string Complemento2 { get; set; } = String.Empty;
        public string Complemento3 { get; set; } = String.Empty;
        public int? UsuarioIns { get; set; }
        public DateOnly? FechaIns { get; set; }
        public int? UsuarioUpd { get; set; }
        public DateOnly? FechaUpd { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? CodigoPresupuesto { get; set; }
    }
}
