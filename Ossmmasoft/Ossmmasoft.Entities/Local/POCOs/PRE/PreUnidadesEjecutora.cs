

namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreUnidadesEjecutora
    {
        public int Id { get; set; }
        public string Denominacion { get; set; } = String.Empty;
        public DateOnly? FechaInicial { get; set; }
        public DateOnly? FechaFinal { get; set; }
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
        public virtual PrePresupuesto CodigoPresupuestoNavigation { get; set; }
    }
}
