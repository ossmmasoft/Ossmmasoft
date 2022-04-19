namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreParticipaFinancieraOrg
    {
        public int? Id { get; set; }
        public int? Ano { get; set; }
        public int? CodigoOrganismo { get; set; }
        public int? CodigoIcp { get; set; }
        public decimal? CuotaParticipacion { get; set; }
        public string Observaciones { get; set; } = String.Empty;
        public string Complementto1 { get; set; } = String.Empty;
        public string Complementto2 { get; set; } = String.Empty;
        public string Complementto3 { get; set; } = String.Empty;
        public int? UsuarioIns { get; set; }
        public DateOnly? FechaIns { get; set; }
        public int? UsuarioUpd { get; set; }
        public DateOnly? FechaUpd { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? CodigoPuc { get; set; }
        public int? CodigoPresupuesto { get; set; }
    }
}
