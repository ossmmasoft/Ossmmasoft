namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreRelacionCargo
    {
        public PreRelacionCargo()
        {
            NomRelacionCargos = new HashSet<NomRelacionCargo>();
        }

        public int Id { get; set; }
        public int? Año { get; set; }
        public int? Escenario { get; set; }
        public int? CodigoIcp { get; set; }
        public int? CodigoCargo { get; set; }
        public int? Cantidad { get; set; }
        public decimal Sueldo { get; set; }
        public decimal? Compensacion { get; set; }
        public decimal? Prima { get; set; }
        public decimal? Otro { get; set; }
        public string Complemento1 { get; set; } = String.Empty;
        public string Complemento2 { get; set; } = String.Empty;
        public string Complemento3 { get; set; } = String.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? CodigoPresupuesto { get; set; }

        public virtual PreCargo CodigoCargoNavigation { get; set; }
        public virtual SisEmpresa CodigoEmpresaNavigation { get; set; }
        public virtual PrePresupuesto CodigoPresupuestoNavigation { get; set; }
        public virtual ICollection<NomRelacionCargo> NomRelacionCargos { get; set; }
    }
}
