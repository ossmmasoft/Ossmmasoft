namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreProyecto
    {
        public PreProyecto()
        {
            PreMeta = new HashSet<PreMeta>();
        }

        public int Id { get; set; }
        public int? CodigoIcp { get; set; }
        public int? NumeroProyecto { get; set; }
        public string DenominacionProyecto { get; set; } = String.Empty;
        public string Complemento1 { get; set; } = String.Empty;
        public string Complemento2 { get; set; } = String.Empty;
        public string Complemento3 { get; set; } = String.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? CodigoPresupuesto { get; set; }

        public virtual SisEmpresa CodigoEmpresaNavigation { get; set; }
        public virtual PreIndiceCatPrg CodigoIcpNavigation { get; set; }
        public virtual PrePresupuesto CodigoPresupuestoNavigation { get; set; }
        public virtual ICollection<PreMeta> PreMeta { get; set; }
    }
}
