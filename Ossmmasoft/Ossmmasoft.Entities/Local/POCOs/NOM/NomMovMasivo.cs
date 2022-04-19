﻿namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomMovMasivo
    {
        public int Id { get; set; }
        public int CodigoTipoNomina { get; set; }
        public int CodigoPeriodo { get; set; }
        public int CodigoConcepto { get; set; }
        public string ComplementoConcepto { get; set; } = string.Empty;
        public string CriterioBusqueda { get; set; } = string.Empty;
        public char? Tipo { get; set; }
        public int? FrecuenciaId { get; set; }
        public string OrigenMonto { get; set; } = string.Empty;
        public decimal Monto { get; set; }
        public string Status { get; set; } = string.Empty;
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public string Complemento4 { get; set; } = string.Empty;
        public string Complemento5 { get; set; } = string.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }


        public virtual NomConcepto CodigoConceptoNavigation { get; set; }
        public virtual NomPeriodo CodigoPeriodoNavigation { get; set; }
        public virtual NomTiposNomina CodigoTipoNominaNavigation { get; set; }
        public virtual NomDescriptiva Frecuencia { get; set; }
    }
}
