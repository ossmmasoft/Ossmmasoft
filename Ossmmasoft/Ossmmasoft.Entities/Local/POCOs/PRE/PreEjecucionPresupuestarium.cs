namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreEjecucionPresupuestaria
    {
        public char? CodigoGrupo { get; set; }
        public string CodigoNivel1 { get; set; } = String.Empty;
        public string CodigoNivel2 { get; set; } = String.Empty;
        public string CodigoNivel3 { get; set; } = String.Empty;
        public string CodigoNivel4 { get; set; } = String.Empty;
        public decimal? IReal { get; set; }
        public decimal? IProyectado { get; set; }
        public decimal? IiReal { get; set; }
        public decimal? IiProyectado { get; set; }
        public decimal? IiiReal { get; set; }
        public decimal? IiiProyectado { get; set; }
        public decimal? IvReal { get; set; }
        public decimal? IvProyectado { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? CodigoPresupuesto { get; set; }
    }
}
