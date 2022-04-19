namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreOefp
    {
        public int? Id { get; set; }
        public int? Ano { get; set; }
        public char? CodigoGrupo { get; set; }
        public string CodigoPartida { get; set; } = String.Empty;
        public string CodigoGenerica { get; set; } = String.Empty;
        public string CodigoEspecifica { get; set; } = String.Empty;
        public string CodigoSubespecifica { get; set; } = String.Empty;
        public string Denominacion { get; set; } = String.Empty;
        public decimal? IReal { get; set; }
        public decimal? IProyectado { get; set; }
        public decimal? IiReal { get; set; }
        public decimal? IiProyectado { get; set; }
        public decimal? IiiReal { get; set; }
        public decimal? IiiProyectado { get; set; }
        public decimal? IvReal { get; set; }
        public decimal? IvProyectado { get; set; }
    }
}
