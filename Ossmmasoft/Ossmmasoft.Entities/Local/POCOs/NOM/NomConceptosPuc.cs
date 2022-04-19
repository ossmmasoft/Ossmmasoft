namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomConceptosPuc
    {
        public int Id { get; set; }
        public int CodigoConcepto { get; set; }
        public int CodigoPresupuesto { get; set; }
        public int CodigoPuc { get; set; }
        public int Estatus { get; set; }
        public string Complemnto1 { get; set; } = String.Empty;
        public string Complemnto2 { get; set; } = String.Empty;
        public string Complemnto3 { get; set; } = String.Empty;
        public string Complemnto4 { get; set; } = String.Empty;
        public string Complemnto5 { get; set; } = String.Empty;
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public int CodigoEmpresa { get; set; }

        public virtual NomConcepto CodigoConceptoNavigation { get; set; }
        public virtual PrePresupuesto CodigoPresupuestoNavigation { get; set; }
        public virtual PrePlanUnicoCuenta CodigoPucNavigation { get; set; }
    }
}
