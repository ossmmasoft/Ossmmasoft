namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreProyectosInversion
    {
        public int Id { get; set; }
        public int? Ano { get; set; }
        public int? Escenario { get; set; }
        public int? CodigoIcp { get; set; }
        public int? FinanciadoId { get; set; }
        public string CodigoObra { get; set; } = String.Empty;
        public string Denominacion { get; set; } = String.Empty;
        public int? CodigoFuncionario { get; set; }
        public DateOnly? FechaIni { get; set; }
        public DateOnly? FechaFin { get; set; }
        public int? SituacionId { get; set; }
        public decimal? Costo { get; set; }
        public decimal? CompromisoAnterior { get; set; }
        public decimal? CompromisoVigente { get; set; }
        public decimal? EjecutadoAnterior { get; set; }
        public decimal? EjecutadoVigente { get; set; }
        public decimal? EstimadaPresupuesto { get; set; }
        public decimal? EstimadaPosterior { get; set; }
        public string Complemento1 { get; set; } = String.Empty;
        public string Complemento2 { get; set; } = String.Empty;
        public string Complemento { get; set; } = String.Empty;
        public int? UsuarioIns { get; set; }
        public DateOnly? FechaIns { get; set; }
        public int? UsuarioUpd { get; set; }
        public DateOnly? FechaUpd { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? CodigoPresupuesto { get; set; }
        public string Funcionario { get; set; } = String.Empty;
    }
}
