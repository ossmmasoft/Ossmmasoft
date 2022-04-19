namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomTransactionMontoMoneda
    {
        public int CodigoPersona { get; set; }
        public decimal? MontoNeto { get; set; }
        public decimal? CantidadMoneda { get; set; }
        public decimal? ValorMoneda { get; set; }
        public int CodigoIcp { get; set; }
        public int CodigoEmpresa { get; set; }
    }
}
