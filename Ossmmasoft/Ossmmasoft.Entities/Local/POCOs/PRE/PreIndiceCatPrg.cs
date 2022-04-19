namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreIndiceCatPrg
    {
        public PreIndiceCatPrg()
        {
            NomHorarioPersonas = new HashSet<NomHorarioPersona>();
            NomRelacionCargos = new HashSet<NomRelacionCargo>();
            PreAnteproyectos = new HashSet<PreAnteproyecto>();
            PreAsignaciones = new HashSet<PreAsignacione>();
            PreEquipos = new HashSet<PreEquipo>();
            PreObjetivos = new HashSet<PreObjetivo>();
            PreProyectos = new HashSet<PreProyecto>();
            PrePucModificacions = new HashSet<PrePucModificacion>();
            PrePucSolModificacions = new HashSet<PrePucSolModificacion>();
            PreSaldos = new HashSet<PreSaldo>();
            PreTransferencia = new HashSet<PreTransferencia>();
        }

        public int Id { get; set; }
        public int? Año { get; set; }
        public int? Escenario { get; set; }
        public string CodigoSector { get; set; }
        public string CodigoPrograma { get; set; }
        public string CodigoSubprograma { get; set; }
        public string CodigoProyecto { get; set; }
        public string CodigoActividad { get; set; }
        public string Denominacion { get; set; }
        public string UnidadEjecutora { get; set; }
        public string Descripcion { get; set; }
        public int? CodigoFuncionario { get; set; }
        public DateOnly? FechaInicial { get; set; }
        public DateOnly? FechaFinal { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public string CodigoOficina { get; set; }
        public int? CodigoPresupuesto { get; set; }

        public virtual SisEmpresa? CodigoEmpresaNavigation { get; set; }
        public virtual PrePresupuesto? CodigoPresupuestoNavigation { get; set; }
        public virtual ICollection<NomHorarioPersona> NomHorarioPersonas { get; set; }
        public virtual ICollection<NomRelacionCargo> NomRelacionCargos { get; set; }
        public virtual ICollection<PreAnteproyecto> PreAnteproyectos { get; set; }
        public virtual ICollection<PreAsignacione> PreAsignaciones { get; set; }
        public virtual ICollection<PreEquipo> PreEquipos { get; set; }
        public virtual ICollection<PreObjetivo> PreObjetivos { get; set; }
        public virtual ICollection<PreProyecto> PreProyectos { get; set; }
        public virtual ICollection<PrePucModificacion> PrePucModificacions { get; set; }
        public virtual ICollection<PrePucSolModificacion> PrePucSolModificacions { get; set; }
        public virtual ICollection<PreSaldo> PreSaldos { get; set; }
        public virtual ICollection<PreTransferencia> PreTransferencia { get; set; }
    }
}
