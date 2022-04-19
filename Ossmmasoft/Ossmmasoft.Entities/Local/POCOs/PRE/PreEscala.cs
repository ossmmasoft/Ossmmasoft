namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreEscala
    {
        public int Id { get; set; }
        public int? Año { get; set; }
        public int? Escenario { get; set; }
        public string NumeroEscala { get; set; }
        public string CodigoGrupo { get; set; }
        public decimal? ValorIni { get; set; }
        public decimal? ValorFin { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? CodigoPresupuesto { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public string Complemento4 { get; set; }
        public string Complemento5 { get; set; }

        public virtual SisEmpresa CodigoEmpresaNavigation { get; set; }
        public virtual PrePresupuesto CodigoPresupuestoNavigation { get; set; }
    }
}
