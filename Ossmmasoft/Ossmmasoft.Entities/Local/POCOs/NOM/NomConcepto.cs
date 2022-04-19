namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomConcepto
    {
        public NomConcepto()
        {
            CargaArchivoControls = new HashSet<CargaArchivoControl>();
            ConceptosAcumulaCodigoConceptoAsociadoNavigations = new HashSet<ConceptosAcumula>();
            ConceptosAcumulaCodigoConceptoNavigations = new HashSet<ConceptosAcumula>();
            NomConceptosPucs = new HashSet<NomConceptosPuc>();
            NomDescuentoLeys = new HashSet<NomDescuentoLey>();
            NomFormulaConceptos = new HashSet<NomFormulaConcepto>();
            NomHistoricoNominas = new HashSet<NomHistoricoNomina>();
            NomMovMasivos = new HashSet<NomMovMasivo>();
            NomMovimientoNominas = new HashSet<NomMovimientoNomina>();
            NomPersonasMovControls = new HashSet<NomPersonasMovControl>();
            NomTemporalNominas = new HashSet<NomTemporalNomina>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public int CodigoTipoNomina { get; set; }
        public string Denominacion { get; set; } = String.Empty;
        public string Descripcion { get; set; } = String.Empty;
        public string TipoConcepto { get; set; } = String.Empty;
        public int? ModuloId { get; set; }
        public int? CodigoPuc { get; set; }
        public string Status { get; set; } = String.Empty;
        public string Complemento1 { get; set; } = String.Empty;
        public string Complemento2 { get; set; } = String.Empty;
        public string Complemento3 { get; set; } = String.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int CodigoEmpresa { get; set; }
        public int FrecuenciaId { get; set; }
        public decimal? Dedusible { get; set; }
        public decimal? Automatico { get; set; }

        public virtual NomTiposNomina? CodigoTipoNominaNavigation { get; set; }
        public virtual NomDescriptiva? Frecuencia { get; set; }
        public virtual NomDescriptiva? Modulo { get; set; }
        public virtual ICollection<CargaArchivoControl> CargaArchivoControls { get; set; }
        public virtual ICollection<ConceptosAcumula> ConceptosAcumulaCodigoConceptoAsociadoNavigations { get; set; }
        public virtual ICollection<ConceptosAcumula> ConceptosAcumulaCodigoConceptoNavigations { get; set; }
        public virtual ICollection<NomConceptosPuc> NomConceptosPucs { get; set; }
        public virtual ICollection<NomDescuentoLey> NomDescuentoLeys { get; set; }
        public virtual ICollection<NomFormulaConcepto> NomFormulaConceptos { get; set; }
        public virtual ICollection<NomHistoricoNomina> NomHistoricoNominas { get; set; }
        public virtual ICollection<NomMovMasivo> NomMovMasivos { get; set; }
        public virtual ICollection<NomMovimientoNomina> NomMovimientoNominas { get; set; }
        public virtual ICollection<NomPersonasMovControl> NomPersonasMovControls { get; set; }
        public virtual ICollection<NomTemporalNomina> NomTemporalNominas { get; set; }
    }
}
