using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class PrePlanUnicoCuenta
    {
        public PrePlanUnicoCuenta()
        {
            NomConceptosPucs = new HashSet<NomConceptosPuc>();
            PreAnteproyectos = new HashSet<PreAnteproyecto>();
            PreAsignaciones = new HashSet<PreAsignacione>();
            PreIngresos = new HashSet<PreIngreso>();
            PrePucModificacions = new HashSet<PrePucModificacion>();
            PrePucSolModificacions = new HashSet<PrePucSolModificacion>();
            PreSaldos = new HashSet<PreSaldo>();
            PreTransferencia = new HashSet<PreTransferencia>();
        }

        public decimal Id { get; set; }
        public char? CodigoGrupo { get; set; }
        public string CodigoNivel1 { get; set; }
        public string CodigoNivel2 { get; set; }
        public string CodigoNivel3 { get; set; }
        public string CodigoNivel4 { get; set; }
        public string CodigoNivel5 { get; set; }
        public string CodigoNivel6 { get; set; }
        public string Denominacion { get; set; }
        public string Descripcion { get; set; }
        public DateOnly? FechaInicial { get; set; }
        public DateOnly? FechaFinal { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal? CodigoPresupuesto { get; set; }

        public virtual ICollection<NomConceptosPuc> NomConceptosPucs { get; set; }
        public virtual ICollection<PreAnteproyecto> PreAnteproyectos { get; set; }
        public virtual ICollection<PreAsignacione> PreAsignaciones { get; set; }
        public virtual ICollection<PreIngreso> PreIngresos { get; set; }
        public virtual ICollection<PrePucModificacion> PrePucModificacions { get; set; }
        public virtual ICollection<PrePucSolModificacion> PrePucSolModificacions { get; set; }
        public virtual ICollection<PreSaldo> PreSaldos { get; set; }
        public virtual ICollection<PreTransferencia> PreTransferencia { get; set; }
    }
}
