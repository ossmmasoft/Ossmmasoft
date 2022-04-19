namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class CargaArchivoControl
    {
        public CargaArchivoControl()
        {
            NomCargaArchivos = new HashSet<NomCargaArchivo>();
        }

        public int Id { get; set; }
        public int? CodigoTipoNomina { get; set; }
        public int? CodigoPeriodo { get; set; }
        public string NombreArchivo { get; set; } = String.Empty;
        public int? CodigoConcepto { get; set; }
        public string ComplementoConcepto { get; set; } = String.Empty;
        public char? Tipo { get; set; }
        public int? FrecuenciaId { get; set; }
        public decimal MontoTotal { get; set; }
        public string Complemento1 { get; set; } = String.Empty;
        public string Complemento2 { get; set; } = String.Empty;
        public string Complemento3 { get; set; } = String.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public string Complemento4 { get; set; } = String.Empty;
        public string Complemento5 { get; set; } = String.Empty;

        public virtual NomConcepto CodigoConceptoNavigation { get; set; }
        public virtual NomPeriodo CodigoPeriodoNavigation { get; set; }
        public virtual NomTiposNomina CodigoTipoNominaNavigation { get; set; }
        public virtual NomDescriptiva Frecuencia { get; set; }
        public virtual ICollection<NomCargaArchivo> NomCargaArchivos { get; set; }
    }
}
