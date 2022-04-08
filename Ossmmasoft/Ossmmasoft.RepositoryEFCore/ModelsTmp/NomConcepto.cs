using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
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

        public decimal Id { get; set; }
        public string Codigo { get; set; }
        public decimal? CodigoTipoNomina { get; set; }
        public string Denominacion { get; set; }
        public string Descripcion { get; set; }
        public string TipoConcepto { get; set; }
        public decimal? ModuloId { get; set; }
        public decimal? CodigoPuc { get; set; }
        public string Status { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal? FrecuenciaId { get; set; }
        public decimal? Dedusible { get; set; }
        public decimal? Automatico { get; set; }

        public virtual NomTiposNomina CodigoTipoNominaNavigation { get; set; }
        public virtual NomDescriptiva Frecuencia { get; set; }
        public virtual NomDescriptiva Modulo { get; set; }
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
