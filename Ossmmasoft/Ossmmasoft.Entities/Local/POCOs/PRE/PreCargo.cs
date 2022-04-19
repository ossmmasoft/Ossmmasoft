

namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreCargo
    {
        public PreCargo()
        {
            NomRelacionCargos = new HashSet<NomRelacionCargo>();
            PreRelacionCargos = new HashSet<PreRelacionCargo>();
        }

        public int Id { get; set; }
        public int? TipoPersonalId { get; set; }
        public int? TipoCargoId { get; set; }
        public string Denominacion { get; set; }
        public string Descripcion { get; set; }
        public int? Grado { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? CodigoPresupuesto { get; set; }
        public string Complemento4 { get; set; }
        public string Complemento5 { get; set; }

        public virtual SisEmpresa CodigoEmpresaNavigation { get; set; }
        public virtual PreDescriptiva TipoCargo { get; set; }
        public virtual PreDescriptiva TipoPersonal { get; set; }
        public virtual ICollection<NomRelacionCargo> NomRelacionCargos { get; set; }
        public virtual ICollection<PreRelacionCargo> PreRelacionCargos { get; set; }
    }
}
