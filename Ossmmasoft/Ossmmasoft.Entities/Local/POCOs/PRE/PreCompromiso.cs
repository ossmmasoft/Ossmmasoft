namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreCompromiso
    {
        public int Id { get; set; }
        public int? Año { get; set; }
        public int? CodigoSolicitud { get; set; }
        public string NumeroCompromiso { get; set; }
        public DateOnly FechaCompromiso { get; set; }
        public decimal? CodigoProveedor { get; set; }
        public DateOnly? FechaEntrega { get; set; }
        public int? CodigoDirEntrega { get; set; }
        public int? TipoPagoId { get; set; }
        public string Motivo { get; set; }
        public string Status { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? CodigoPresupuesto { get; set; }
        public int? TipoRenglonId { get; set; }
        public string NumeroOrden { get; set; }

        public virtual SisEmpresa CodigoEmpresaNavigation { get; set; }
    }
}
