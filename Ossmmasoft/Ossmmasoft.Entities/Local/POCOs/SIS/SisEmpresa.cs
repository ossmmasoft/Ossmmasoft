


namespace Ossmmasoft.Entities.Local.POCOs.SIS
{
    public partial class SisEmpresa
    {
        public SisEmpresa()
        {
            PreAnteproyectos = new HashSet<PreAnteproyecto>();
            PreAsignaciones = new HashSet<PreAsignacione>();
            PreCargos = new HashSet<PreCargo>();
            PreCompromisos = new HashSet<PreCompromiso>();
            PreDescriptivas = new HashSet<PreDescriptiva>();
            PreEquipos = new HashSet<PreEquipo>();
            PreEscalas = new HashSet<PreEscala>();
            PreIdentificaciones = new HashSet<PreIdentificacion>();
            PreIndiceCatPrgs = new HashSet<PreIndiceCatPrg>();
            PreIngresos = new HashSet<PreIngreso>();
            PreMeta = new HashSet<PreMeta>();
            PreModificacions = new HashSet<PreModificacion>();
            PreNivelesPucs = new HashSet<PreNivelesPuc>();
            PreObjetivos = new HashSet<PreObjetivo>();
            PreOrganismos = new HashSet<PreOrganismo>();
            PrePlanUnicoCuenta = new HashSet<PrePlanUnicoCuenta>();
            PrePresupuestos = new HashSet<PrePresupuesto>();
            PreProyectos = new HashSet<PreProyecto>();
            PrePucModificacions = new HashSet<PrePucModificacion>();
            PrePucSolModificacions = new HashSet<PrePucSolModificacion>();
            PreRelacionCargos = new HashSet<PreRelacionCargo>();
            PreSaldos = new HashSet<PreSaldo>();
            PreSolModificacions = new HashSet<PreSolModificacion>();
            PreTitulos = new HashSet<PreTitulo>();
            PreTransferencia = new HashSet<PreTransferencia>();
            PreUnidadesEjecutoras = new HashSet<PreUnidadesEjecutora>();
        }

        public int Id { get; set; }
        public string NombreEmpresa { get; set; } = String.Empty;
        public int? TipoEmpresaId { get; set; }
        public int? IdentificacionId { get; set; }
        public string NumeroIdentificacion { get; set; } = String.Empty;
        public DateOnly? FechaInstalacion { get; set; }
        public int? VersionSistemaId { get; set; }
        public int? MarcaServidorId { get; set; }
        public int? SistemaOperativoId { get; set; }
        public string NombreServidor { get; set; }
        public string UnidadInstalacion { get; set; } = String.Empty;
        public string DirectorioPrincipal { get; set; } = String.Empty;
        public string DirectorioPrivado { get; set; } = String.Empty;
        public string DirectorioPublico { get; set; } = String.Empty;
        public string Complemento1 { get; set; } = String.Empty;
        public string Complemento2 { get; set; } = String.Empty;
        public string Complemento3 { get; set; } = String.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public string CodigoEstadoCtaFiscal { get; set; } = String.Empty;
        public string CodigoMunicipioCtaFiscal { get; set; } = String.Empty;
        public string Separator { get; set; } = String.Empty;
        public int? Gerencial { get; set; }
        public string Complemento4 { get; set; } = String.Empty;
        public string Complemento5 { get; set; } = String.Empty;
        public string Complemento6 { get; set; } = String.Empty;
        public string Complemento7 { get; set; } = String.Empty;
        public string Complemento8 { get; set; } = String.Empty;
        public string Complemento9 { get; set; } = String.Empty;
        public string Complemento10 { get; set; } = String.Empty;
        public string Complemento11 { get; set; } = String.Empty;
        public string Complemento12 { get; set; } = String.Empty;
        public string Complemento13 { get; set; } = String.Empty;
        public string Complemento14 { get; set; } = String.Empty;
        public string Complemento15 { get; set; } = String.Empty;
        public int? DondeEstoy { get; set; }

        public virtual SisDescriptiva Identificacion { get; set; }
        public virtual SisDescriptiva MarcaServidor { get; set; }
        public virtual SisDescriptiva SistemaOperativo { get; set; }
        public virtual SisDescriptiva TipoEmpresa { get; set; }
        public virtual SisDescriptiva VersionSistema { get; set; }
        public virtual ICollection<PreAnteproyecto> PreAnteproyectos { get; set; }
        public virtual ICollection<PreAsignacione> PreAsignaciones { get; set; }
        public virtual ICollection<PreCargo> PreCargos { get; set; }
        public virtual ICollection<PreCompromiso> PreCompromisos { get; set; }
        public virtual ICollection<PreDescriptiva> PreDescriptivas { get; set; }
        public virtual ICollection<PreEquipo> PreEquipos { get; set; }
        public virtual ICollection<PreEscala> PreEscalas { get; set; }
        public virtual ICollection<PreIdentificacion> PreIdentificaciones { get; set; }
        public virtual ICollection<PreIndiceCatPrg> PreIndiceCatPrgs { get; set; }
        public virtual ICollection<PreIngreso> PreIngresos { get; set; }
        public virtual ICollection<PreMeta> PreMeta { get; set; }
        public virtual ICollection<PreModificacion> PreModificacions { get; set; }
        public virtual ICollection<PreNivelesPuc> PreNivelesPucs { get; set; }
        public virtual ICollection<PreObjetivo> PreObjetivos { get; set; }
        public virtual ICollection<PreOrganismo> PreOrganismos { get; set; }
        public virtual ICollection<PrePlanUnicoCuenta> PrePlanUnicoCuenta { get; set; }
        public virtual ICollection<PrePresupuesto> PrePresupuestos { get; set; }
        public virtual ICollection<PreProyecto> PreProyectos { get; set; }
        public virtual ICollection<PrePucModificacion> PrePucModificacions { get; set; }
        public virtual ICollection<PrePucSolModificacion> PrePucSolModificacions { get; set; }
        public virtual ICollection<PreRelacionCargo> PreRelacionCargos { get; set; }
        public virtual ICollection<PreSaldo> PreSaldos { get; set; }
        public virtual ICollection<PreSolModificacion> PreSolModificacions { get; set; }
        public virtual ICollection<PreTitulo> PreTitulos { get; set; }
        public virtual ICollection<PreTransferencia> PreTransferencia { get; set; }
        public virtual ICollection<PreUnidadesEjecutora> PreUnidadesEjecutoras { get; set; }
    }
}
