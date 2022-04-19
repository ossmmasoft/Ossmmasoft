namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomEscalaAguinaldo
    {
        public int Id { get; set; }
        public int? CodigoTipoNomina { get; set; }
        public int? DiasAguinaldo { get; set; }
        public int? CodigoPeriodoDesde { get; set; }
        public int? CodigoPeriodoHasta { get; set; }
        public int? CodigoPeriodoAguinaldo { get; set; }
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }

        public virtual NomPeriodo CodigoPeriodoAguinaldoNavigation { get; set; }
        public virtual NomPeriodo CodigoPeriodoDesdeNavigation { get; set; }
        public virtual NomPeriodo CodigoPeriodoHastaNavigation { get; set; }
        public virtual NomTiposNomina CodigoTipoNominaNavigation { get; set; }
    }
}
