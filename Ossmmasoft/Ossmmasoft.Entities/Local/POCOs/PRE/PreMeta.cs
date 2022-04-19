namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreMeta
    {
        public int Id { get; set; }
        public int? CodigoProyecto { get; set; }
        public int? NumeroMeta { get; set; }
        public string DenominacionMeta { get; set; }
        public int? UnidadMedidaId { get; set; }
        public int? CantidadMeta { get; set; }
        public decimal? CostoMeta { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? CodigoPresupuesto { get; set; }
        public int? CantidadPrimerTrimestre { get; set; }
        public int? CantidadSegundoTrimestre { get; set; }
        public int? CantidadTercerTrimestre { get; set; }
        public int? CantidadCuartoTrimestre { get; set; }

        public virtual SisEmpresa CodigoEmpresaNavigation { get; set; }
        public virtual PrePresupuesto CodigoPresupuestoNavigation { get; set; }
        public virtual PreProyecto CodigoProyectoNavigation { get; set; }
    }
}
