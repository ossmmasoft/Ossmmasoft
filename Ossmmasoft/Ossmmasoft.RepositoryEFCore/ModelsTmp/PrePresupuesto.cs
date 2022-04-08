using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class PrePresupuesto
    {
        public PrePresupuesto()
        {
            NomConceptosPucs = new HashSet<NomConceptosPuc>();
            NomMovCajaAhorros = new HashSet<NomMovCajaAhorro>();
            NomPeriodos = new HashSet<NomPeriodo>();
            NomRelacionCargos = new HashSet<NomRelacionCargo>();
            NomTiposNominas = new HashSet<NomTiposNomina>();
            PreAnteproyectos = new HashSet<PreAnteproyecto>();
            PreAsignaciones = new HashSet<PreAsignacione>();
            PreEquipos = new HashSet<PreEquipo>();
            PreEscalas = new HashSet<PreEscala>();
            PreIdentificaciones = new HashSet<PreIdentificacione>();
            PreIndiceCatPrgs = new HashSet<PreIndiceCatPrg>();
            PreIngresos = new HashSet<PreIngreso>();
            PreMeta = new HashSet<PreMeta>();
            PreModificacions = new HashSet<PreModificacion>();
            PreObjetivos = new HashSet<PreObjetivo>();
            PreOrganismos = new HashSet<PreOrganismo>();
            PreProyectos = new HashSet<PreProyecto>();
            PrePucModificacions = new HashSet<PrePucModificacion>();
            PrePucSolModificacions = new HashSet<PrePucSolModificacion>();
            PreRelacionCargos = new HashSet<PreRelacionCargo>();
            PreSaldos = new HashSet<PreSaldo>();
            PreSolModificacions = new HashSet<PreSolModificacion>();
            PreTransferencia = new HashSet<PreTransferencia>();
            PreUnidadesEjecutoras = new HashSet<PreUnidadesEjecutora>();
        }

        public decimal Id { get; set; }
        public string Denominacion { get; set; }
        public string Descripcion { get; set; }
        public decimal? Año { get; set; }
        public decimal MontoPresupuesto { get; set; }
        public DateOnly? FechaDesde { get; set; }
        public DateOnly? FechaHasta { get; set; }
        public DateOnly? FechaAprobacion { get; set; }
        public string NumeroOrdenanza { get; set; }
        public DateOnly? FechaOrdenanza { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public string Complemento4 { get; set; }
        public string Complemento5 { get; set; }

        public virtual ICollection<NomConceptosPuc> NomConceptosPucs { get; set; }
        public virtual ICollection<NomMovCajaAhorro> NomMovCajaAhorros { get; set; }
        public virtual ICollection<NomPeriodo> NomPeriodos { get; set; }
        public virtual ICollection<NomRelacionCargo> NomRelacionCargos { get; set; }
        public virtual ICollection<NomTiposNomina> NomTiposNominas { get; set; }
        public virtual ICollection<PreAnteproyecto> PreAnteproyectos { get; set; }
        public virtual ICollection<PreAsignacione> PreAsignaciones { get; set; }
        public virtual ICollection<PreEquipo> PreEquipos { get; set; }
        public virtual ICollection<PreEscala> PreEscalas { get; set; }
        public virtual ICollection<PreIdentificacione> PreIdentificaciones { get; set; }
        public virtual ICollection<PreIndiceCatPrg> PreIndiceCatPrgs { get; set; }
        public virtual ICollection<PreIngreso> PreIngresos { get; set; }
        public virtual ICollection<PreMeta> PreMeta { get; set; }
        public virtual ICollection<PreModificacion> PreModificacions { get; set; }
        public virtual ICollection<PreObjetivo> PreObjetivos { get; set; }
        public virtual ICollection<PreOrganismo> PreOrganismos { get; set; }
        public virtual ICollection<PreProyecto> PreProyectos { get; set; }
        public virtual ICollection<PrePucModificacion> PrePucModificacions { get; set; }
        public virtual ICollection<PrePucSolModificacion> PrePucSolModificacions { get; set; }
        public virtual ICollection<PreRelacionCargo> PreRelacionCargos { get; set; }
        public virtual ICollection<PreSaldo> PreSaldos { get; set; }
        public virtual ICollection<PreSolModificacion> PreSolModificacions { get; set; }
        public virtual ICollection<PreTransferencia> PreTransferencia { get; set; }
        public virtual ICollection<PreUnidadesEjecutora> PreUnidadesEjecutoras { get; set; }
    }
}
