namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomControlProceso
    {
        public int Id { get; set; }
        public int CodigoTipoNomina { get; set; }
        public int ProcesoId { get; set; }
        public string NumeroProceso { get; set; }
        public DateOnly FechaDesde { get; set; }
        public DateOnly FechaHasta { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }

        public virtual NomTiposNomina CodigoTipoNominaNavigation { get; set; }
    }
}
