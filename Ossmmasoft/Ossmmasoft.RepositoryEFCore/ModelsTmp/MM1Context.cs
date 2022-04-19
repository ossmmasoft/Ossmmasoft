/*
using Ossmmasoft.Entities.Local.POCOs.NOM;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class MM1Context : DbContext
    {
        public MM1Context()
        {
        }

        public MM1Context(DbContextOptions<MM1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<CargaArchivoControl> CargaArchivoControls { get; set; }
        public virtual DbSet<CccTransaction> CccTransactions { get; set; }
        public virtual DbSet<ConceptosAcumula> ConceptosAcumulas { get; set; }
        public virtual DbSet<NomAcumulado> NomAcumulados { get; set; }
        public virtual DbSet<NomAdministrativo> NomAdministrativos { get; set; }
        public virtual DbSet<NomAnticipoPrestacione> NomAnticipoPrestaciones { get; set; }
        public virtual DbSet<NomAri> NomAris { get; set; }
        public virtual DbSet<NomBecado> NomBecados { get; set; }
        public virtual DbSet<NomCajaAhorro> NomCajaAhorros { get; set; }
        public virtual DbSet<NomCambioDato> NomCambioDatos { get; set; }
        public virtual DbSet<NomCargaArchivo> NomCargaArchivos { get; set; }
        public virtual DbSet<NomComunicacione> NomComunicaciones { get; set; }
        public virtual DbSet<NomConcepto> NomConceptos { get; set; }
        public virtual DbSet<NomConceptosPuc> NomConceptosPucs { get; set; }
        public virtual DbSet<NomControlHorario> NomControlHorarios { get; set; }
        public virtual DbSet<NomControlProceso> NomControlProcesos { get; set; }
        public virtual DbSet<NomDescriptiva> NomDescriptivas { get; set; }
        public virtual DbSet<NomDescuentoLey> NomDescuentoLeys { get; set; }
        public virtual DbSet<NomDescuentoLeyTrabajador> NomDescuentoLeyTrabajadors { get; set; }
        public virtual DbSet<NomDetalleLiquidacione> NomDetalleLiquidaciones { get; set; }
        public virtual DbSet<NomDireccione> NomDirecciones { get; set; }
        public virtual DbSet<NomDocumento> NomDocumentos { get; set; }
        public virtual DbSet<NomDocumentosDetalle> NomDocumentosDetalles { get; set; }
        public virtual DbSet<NomEducacion> NomEducacions { get; set; }
        public virtual DbSet<NomEgreso> NomEgresos { get; set; }
        public virtual DbSet<NomEntradaSalidum> NomEntradaSalida { get; set; }
        public virtual DbSet<NomEscalaAguinaldo> NomEscalaAguinaldos { get; set; }
        public virtual DbSet<NomEscalaHcm> NomEscalaHcms { get; set; }
        public virtual DbSet<NomEscalaHoraExtra> NomEscalaHoraExtras { get; set; }
        public virtual DbSet<NomEscalaIslr> NomEscalaIslrs { get; set; }
        public virtual DbSet<NomEscalaJuguete> NomEscalaJuguetes { get; set; }
        public virtual DbSet<NomEscalaUtilEscolar> NomEscalaUtilEscolars { get; set; }
        public virtual DbSet<NomEscalaVacacione> NomEscalaVacaciones { get; set; }
        public virtual DbSet<NomExperienciaLaboral> NomExperienciaLaborals { get; set; }
        public virtual DbSet<NomFamiliare> NomFamiliares { get; set; }
        public virtual DbSet<NomFiadorCajaAhorro> NomFiadorCajaAhorros { get; set; }
        public virtual DbSet<NomFormulaConcepto> NomFormulaConceptos { get; set; }
        public virtual DbSet<NomHcm> NomHcms { get; set; }
        public virtual DbSet<NomHistoricoBecado> NomHistoricoBecados { get; set; }
        public virtual DbSet<NomHistoricoNomina> NomHistoricoNominas { get; set; }
        public virtual DbSet<NomHistoricoPersonalCargo> NomHistoricoPersonalCargos { get; set; }
        public virtual DbSet<NomHorario> NomHorarios { get; set; }
        public virtual DbSet<NomHorarioPersona> NomHorarioPersonas { get; set; }
        public virtual DbSet<NomHorasExtra> NomHorasExtras { get; set; }
        public virtual DbSet<NomMoneda> NomMonedas { get; set; }
        public virtual DbSet<NomMovCajaAhorro> NomMovCajaAhorros { get; set; }
        public virtual DbSet<NomMovMasivo> NomMovMasivos { get; set; }
        public virtual DbSet<NomMovPrestacione> NomMovPrestaciones { get; set; }
        public virtual DbSet<NomMovimientoNomina> NomMovimientoNominas { get; set; }
        public virtual DbSet<NomPeriodo> NomPeriodos { get; set; }
        public virtual DbSet<NomPersona> NomPersonas { get; set; }
        public virtual DbSet<NomPersonasMovControl> NomPersonasMovControls { get; set; }
        public virtual DbSet<NomPrestamosCajaAhorro> NomPrestamosCajaAhorros { get; set; }
        public virtual DbSet<NomPrestamosPrestacione> NomPrestamosPrestaciones { get; set; }
        public virtual DbSet<NomPromocione> NomPromociones { get; set; }
        public virtual DbSet<NomRegistroPermiso> NomRegistroPermisos { get; set; }
        public virtual DbSet<NomRelacionCargo> NomRelacionCargos { get; set; }
        public virtual DbSet<NomRetencionesAporte> NomRetencionesAportes { get; set; }
        public virtual DbSet<NomTarifasIislr> NomTarifasIislrs { get; set; }
        public virtual DbSet<NomTasasIntere> NomTasasInteres { get; set; }
        public virtual DbSet<NomTemporalNomina> NomTemporalNominas { get; set; }
        public virtual DbSet<NomTiposNomina> NomTiposNominas { get; set; }
        public virtual DbSet<NomTitulo> NomTitulos { get; set; }
        public virtual DbSet<NomTmpAcumuladoLoad> NomTmpAcumuladoLoads { get; set; }
        public virtual DbSet<NomTmpAguinaldo> NomTmpAguinaldos { get; set; }
        public virtual DbSet<NomTransactionMontoMonedum> NomTransactionMontoMoneda { get; set; }
        public virtual DbSet<NomVacacione> NomVacaciones { get; set; }
        public virtual DbSet<NomVacacionesContrato> NomVacacionesContratos { get; set; }
        public virtual DbSet<NomVacacionesDisfrutada> NomVacacionesDisfrutadas { get; set; }
        public virtual DbSet<NomVacacionesVencida> NomVacacionesVencidas { get; set; }
        public virtual DbSet<PreAnteproyecto> PreAnteproyectos { get; set; }
        public virtual DbSet<PreAsignacione> PreAsignaciones { get; set; }
        public virtual DbSet<PreCargo> PreCargos { get; set; }
        public virtual DbSet<PreCompromiso> PreCompromisos { get; set; }
        public virtual DbSet<PreCostoContCol> PreCostoContCols { get; set; }
        public virtual DbSet<PreCostoContColPuc> PreCostoContColPucs { get; set; }
        public virtual DbSet<PreDescriptiva> PreDescriptivas { get; set; }
        public virtual DbSet<PreDetalleCompromiso> PreDetalleCompromisos { get; set; }
        public virtual DbSet<PreDirectivo> PreDirectivos { get; set; }
        public virtual DbSet<PreEjecucionPresupuestarium> PreEjecucionPresupuestaria { get; set; }
        public virtual DbSet<PreEquipo> PreEquipos { get; set; }
        public virtual DbSet<PreEscala> PreEscalas { get; set; }
        public virtual DbSet<PreIdentificacione> PreIdentificaciones { get; set; }
        public virtual DbSet<PreIndiceCatPrg> PreIndiceCatPrgs { get; set; }
        public virtual DbSet<PreIngreso> PreIngresos { get; set; }
        public virtual DbSet<PreIngresosTmp> PreIngresosTmps { get; set; }
        public virtual DbSet<PreMeta> PreMetas { get; set; }
        public virtual DbSet<PreModificacion> PreModificacions { get; set; }
        public virtual DbSet<PreNivelesPuc> PreNivelesPucs { get; set; }
        public virtual DbSet<PreObjetivo> PreObjetivos { get; set; }
        public virtual DbSet<PreOefp> PreOefps { get; set; }
        public virtual DbSet<PreOrganismo> PreOrganismos { get; set; }
        public virtual DbSet<PreParticipaFinancieraOrg> PreParticipaFinancieraOrgs { get; set; }
        public virtual DbSet<PrePlanUnicoCuenta> PrePlanUnicoCuentas { get; set; }
        public virtual DbSet<PrePorcGastosMensuale> PrePorcGastosMensuales { get; set; }
        public virtual DbSet<PrePresupuesto> PrePresupuestos { get; set; }
        public virtual DbSet<PreProgramasSociale> PreProgramasSociales { get; set; }
        public virtual DbSet<PreProyecto> PreProyectos { get; set; }
        public virtual DbSet<PreProyectosInversion> PreProyectosInversions { get; set; }
        public virtual DbSet<PrePucCompromiso> PrePucCompromisos { get; set; }
        public virtual DbSet<PrePucModificacion> PrePucModificacions { get; set; }
        public virtual DbSet<PrePucSolModificacion> PrePucSolModificacions { get; set; }
        public virtual DbSet<PreRelacionCargo> PreRelacionCargos { get; set; }
        public virtual DbSet<PreSaldo> PreSaldos { get; set; }
        public virtual DbSet<PreSaldosCtrl> PreSaldosCtrls { get; set; }
        public virtual DbSet<PreSaldosDetalle> PreSaldosDetalles { get; set; }
        public virtual DbSet<PreSaldosDiario> PreSaldosDiarios { get; set; }
        public virtual DbSet<PreSaldosDiariosTmp> PreSaldosDiariosTmps { get; set; }
        public virtual DbSet<PreSaldosIngreso> PreSaldosIngresos { get; set; }
        public virtual DbSet<PreSaldosTest> PreSaldosTests { get; set; }
        public virtual DbSet<PreSaldosTmp> PreSaldosTmps { get; set; }
        public virtual DbSet<PreSolModificacion> PreSolModificacions { get; set; }
        public virtual DbSet<PreSolModificacionTmp> PreSolModificacionTmps { get; set; }
        public virtual DbSet<PreTitulo> PreTitulos { get; set; }
        public virtual DbSet<PreTmpSaldo> PreTmpSaldos { get; set; }
        public virtual DbSet<PreTransferencia> PreTransferencias { get; set; }
        public virtual DbSet<PreUnidadesEjecutora> PreUnidadesEjecutoras { get; set; }
        public virtual DbSet<RhHAdministrativo> RhHAdministrativos { get; set; }
        public virtual DbSet<RhHConcepto> RhHConceptos { get; set; }
        public virtual DbSet<RhHHistoricoNomina> RhHHistoricoNominas { get; set; }
        public virtual DbSet<RhHPeriodo> RhHPeriodos { get; set; }
        public virtual DbSet<RhHPrestamosPrestacione> RhHPrestamosPrestaciones { get; set; }
        public virtual DbSet<RhHRelacionCargo> RhHRelacionCargos { get; set; }
        public virtual DbSet<RhHistoricoVFamiliaresBec> RhHistoricoVFamiliaresBecs { get; set; }
        public virtual DbSet<RhMovNominaPrg> RhMovNominaPrgs { get; set; }
        public virtual DbSet<RhTmpAntiguedadLoad> RhTmpAntiguedadLoads { get; set; }
        public virtual DbSet<RhTmpBb> RhTmpBbs { get; set; }
        public virtual DbSet<RhTmpBecado> RhTmpBecados { get; set; }
        public virtual DbSet<RhTmpCa> RhTmpCas { get; set; }
        public virtual DbSet<RhTmpCajaAhorro> RhTmpCajaAhorros { get; set; }
        public virtual DbSet<RhTmpFideicomiso> RhTmpFideicomisos { get; set; }
        public virtual DbSet<RhTmpIslr> RhTmpIslrs { get; set; }
        public virtual DbSet<RhTmpLoad> RhTmpLoads { get; set; }
        public virtual DbSet<RhTmpMovNomina> RhTmpMovNominas { get; set; }
        public virtual DbSet<RhTmpMovPrestacione> RhTmpMovPrestaciones { get; set; }
        public virtual DbSet<RhTmpRelacionCargo> RhTmpRelacionCargos { get; set; }
        public virtual DbSet<SisDescriptiva> SisDescriptivas { get; set; }
        public virtual DbSet<SisEmpresa> SisEmpresas { get; set; }
        public virtual DbSet<Tmp> Tmps { get; set; }
        public virtual DbSet<TmpMaestroContrato> TmpMaestroContratos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server = localhost;Port=5444;Database=MM1;User Id=postgres;Password=mvc4-2014;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CargaArchivoControl>(entity =>
            {
                entity.ToTable("CargaArchivoControl");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoConcepto).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPeriodo).HasPrecision(10);

                entity.Property(e => e.CodigoTipoNomina).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.ComplementoConcepto).HasMaxLength(100);

                entity.Property(e => e.FrecuenciaId).HasPrecision(10);

                entity.Property(e => e.NombreArchivo).HasMaxLength(255);

                entity.Property(e => e.Tipo).HasMaxLength(1);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoConceptoNavigation)
                    .WithMany(p => p.CargaArchivoControls)
                    .HasForeignKey(d => d.CodigoConcepto)
                    .HasConstraintName("cargaarchivocontrolconcepto_fk");

                entity.HasOne(d => d.CodigoPeriodoNavigation)
                    .WithMany(p => p.CargaArchivoControls)
                    .HasForeignKey(d => d.CodigoPeriodo)
                    .HasConstraintName("cargaarchivocontrolperiodo_fk");

                entity.HasOne(d => d.CodigoTipoNominaNavigation)
                    .WithMany(p => p.CargaArchivoControls)
                    .HasForeignKey(d => d.CodigoTipoNomina)
                    .HasConstraintName("cargaarchivocontroltiponomina_fk");

                entity.HasOne(d => d.Frecuencia)
                    .WithMany(p => p.CargaArchivoControls)
                    .HasForeignKey(d => d.FrecuenciaId)
                    .HasConstraintName("cargaarchivocontrolfrecuencia_fk");
            });

            modelBuilder.Entity<CccTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ccc_transaction");

                entity.Property(e => e.CodigoCostoContCol).HasColumnName("codigo_costo_cont_col");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoPresupuesto).HasColumnName("codigo_presupuesto");

                entity.Property(e => e.Denominacion)
                    .HasMaxLength(2000)
                    .HasColumnName("denominacion");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasPrecision(10)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaFin).HasColumnName("fecha_fin");

                entity.Property(e => e.FechaIni).HasColumnName("fecha_ini");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.NumeroClausula)
                    .HasPrecision(10)
                    .HasColumnName("numero_clausula");

                entity.Property(e => e.TipoNomina)
                    .HasPrecision(10)
                    .HasColumnName("tipo_nomina");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<ConceptosAcumula>(entity =>
            {
                entity.ToTable("ConceptosAcumula");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoConcepto).HasPrecision(10);

                entity.Property(e => e.CodigoConceptoAsociado).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.TipoAcumuladoId).HasMaxLength(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoConceptoNavigation)
                    .WithMany(p => p.ConceptosAcumulaCodigoConceptoNavigations)
                    .HasForeignKey(d => d.CodigoConcepto)
                    .HasConstraintName("conceptosacumulacodigoconcepto_fk");

                entity.HasOne(d => d.CodigoConceptoAsociadoNavigation)
                    .WithMany(p => p.ConceptosAcumulaCodigoConceptoAsociadoNavigations)
                    .HasForeignKey(d => d.CodigoConceptoAsociado)
                    .HasConstraintName("conceptosacumulacodigoconceptoasociado_fk");
            });

            modelBuilder.Entity<NomAcumulado>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Año).HasPrecision(4);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.Compplemento1).HasMaxLength(100);

                entity.Property(e => e.Compplemento3).HasMaxLength(100);

                entity.Property(e => e.Compplemto2).HasMaxLength(100);

                entity.Property(e => e.Mes).HasPrecision(2);

                entity.Property(e => e.TipoAcumuladoId).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomAcumulados)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomacumuladospersonas_fk");

                entity.HasOne(d => d.TipoAcumulado)
                    .WithMany(p => p.NomAcumulados)
                    .HasForeignKey(d => d.TipoAcumuladoId)
                    .HasConstraintName("nomacumuladostipoacumulado_fk");
            });

            modelBuilder.Entity<NomAdministrativo>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.BancoId).HasPrecision(5);

                entity.Property(e => e.CargoId).HasPrecision(5);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.NroCuenta).HasMaxLength(20);

                entity.Property(e => e.ProfesionId).HasPrecision(5);

                entity.Property(e => e.Status).HasMaxLength(1);

                entity.Property(e => e.TipoCuentaId).HasPrecision(5);

                entity.Property(e => e.TipoPago).HasMaxLength(1);

                entity.Property(e => e.Turno).HasMaxLength(1);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.Banco)
                    .WithMany(p => p.NomAdministrativoBancos)
                    .HasForeignKey(d => d.BancoId)
                    .HasConstraintName("nomadministrativosbanco_fk");

                entity.HasOne(d => d.Cargo)
                    .WithMany(p => p.NomAdministrativoCargos)
                    .HasForeignKey(d => d.CargoId)
                    .HasConstraintName("nomadministrativoscargo_fk");

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomAdministrativos)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomadministrativospersonas_fk");

                entity.HasOne(d => d.TipoCuenta)
                    .WithMany(p => p.NomAdministrativoTipoCuenta)
                    .HasForeignKey(d => d.TipoCuentaId)
                    .HasConstraintName("nomadministrativostipocuenta_fk");
            });

            modelBuilder.Entity<NomAnticipoPrestacione>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.MotivoAnticipoId).HasPrecision(10);

                entity.Property(e => e.Observacion).HasMaxLength(1000);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomAnticipoPrestaciones)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomanticipoprestacionespersona_fk");

                entity.HasOne(d => d.MotivoAnticipo)
                    .WithMany(p => p.NomAnticipoPrestaciones)
                    .HasForeignKey(d => d.MotivoAnticipoId)
                    .HasConstraintName("nomanticipoprestacionesmotivoid_fk");
            });

            modelBuilder.Entity<NomAri>(entity =>
            {
                entity.ToTable("NomARI");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.AABs).HasColumnName("a_a_bs");

                entity.Property(e => e.ABBs).HasColumnName("a_b_bs");

                entity.Property(e => e.ACBs).HasColumnName("a_c_bs");

                entity.Property(e => e.ADBs).HasColumnName("a_d_bs");

                entity.Property(e => e.Año).HasPrecision(4);

                entity.Property(e => e.C1Bs).HasColumnName("c_1_bs");

                entity.Property(e => e.C2Bs).HasColumnName("c_2_bs");

                entity.Property(e => e.C3Bs).HasColumnName("c_3_bs");

                entity.Property(e => e.C4Bs).HasColumnName("c_4_bs");

                entity.Property(e => e.CargaFamiliar).HasPrecision(2);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.EUt).HasColumnName("e_ut");

                entity.Property(e => e.EmpresaA)
                    .HasMaxLength(100)
                    .HasColumnName("empresa_a");

                entity.Property(e => e.EmpresaB)
                    .HasMaxLength(100)
                    .HasColumnName("empresa_b");

                entity.Property(e => e.EmpresaC)
                    .HasMaxLength(100)
                    .HasColumnName("empresa_c");

                entity.Property(e => e.EmpresaD)
                    .HasMaxLength(100)
                    .HasColumnName("empresa_d");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaAri).HasColumnName("FechaARI");

                entity.Property(e => e.H1Ut).HasColumnName("h_1_ut");

                entity.Property(e => e.H3Bs).HasColumnName("h_3_bs");

                entity.Property(e => e.JPor).HasColumnName("j_por");

                entity.Property(e => e.K1Bs).HasColumnName("k_1_bs");

                entity.Property(e => e.K2Bs).HasColumnName("k_2_bs");

                entity.Property(e => e.KPor).HasColumnName("k_por");

                entity.Property(e => e.Mes).HasPrecision(2);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomAris)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("rh_aripersona_fk");
            });

            modelBuilder.Entity<NomBecado>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoFamiliar).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.CodigoTipoNomina).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.Observacion).HasMaxLength(1000);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCeacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomBecados)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nombecadosfamiliar_fk");

                entity.HasOne(d => d.CodigoPersona1)
                    .WithMany(p => p.NomBecados)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nombecadospersona_fk");

                entity.HasOne(d => d.CodigoTipoNominaNavigation)
                    .WithMany(p => p.NomBecados)
                    .HasForeignKey(d => d.CodigoTipoNomina)
                    .HasConstraintName("nombecadostiponomina_fk");
            });

            modelBuilder.Entity<NomCajaAhorro>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoBanco).HasPrecision(10);

                entity.Property(e => e.CodigoBancoLiq).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPeriodoFin).HasPrecision(10);

                entity.Property(e => e.CodigoPeriodoInicio).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.NumeroChLiq).HasPrecision(10);

                entity.Property(e => e.NumeroCuenta).HasMaxLength(20);

                entity.Property(e => e.NumeroCuentaLiq).HasMaxLength(20);

                entity.Property(e => e.TipoCuentaId).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoPeriodoFinNavigation)
                    .WithMany(p => p.NomCajaAhorroCodigoPeriodoFinNavigations)
                    .HasForeignKey(d => d.CodigoPeriodoFin)
                    .HasConstraintName("nomcajaahorrosperiodofin_fk");

                entity.HasOne(d => d.CodigoPeriodoInicioNavigation)
                    .WithMany(p => p.NomCajaAhorroCodigoPeriodoInicioNavigations)
                    .HasForeignKey(d => d.CodigoPeriodoInicio)
                    .HasConstraintName("nomcajaahorrosperiodoinicio_fk");

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomCajaAhorros)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomcajaahorrospersona_fk");

                entity.HasOne(d => d.TipoCuenta)
                    .WithMany(p => p.NomCajaAhorros)
                    .HasForeignKey(d => d.TipoCuentaId)
                    .HasConstraintName("nomcajaahorrostipocuenta_fk");
            });

            modelBuilder.Entity<NomCambioDato>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Campo).HasMaxLength(30);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.DatoNew).HasMaxLength(100);

                entity.Property(e => e.DatoOld).HasMaxLength(100);

                entity.Property(e => e.Observacion).HasMaxLength(500);

                entity.Property(e => e.Tabla).HasMaxLength(30);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomCambioDatos)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomcambiodatos_fk");
            });

            modelBuilder.Entity<NomCargaArchivo>(entity =>
            {
                entity.ToTable("NomCargaArchivo");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Cedula).HasPrecision(10);

                entity.Property(e => e.CodigoCargaArchivoControl).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoMovNomina).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoCargaArchivoControlNavigation)
                    .WithMany(p => p.NomCargaArchivos)
                    .HasForeignKey(d => d.CodigoCargaArchivoControl)
                    .HasConstraintName("nomcargaarchivocargaarchivocontrol_fk");

                entity.HasOne(d => d.CodigoMovNominaNavigation)
                    .WithMany(p => p.NomCargaArchivos)
                    .HasForeignKey(d => d.CodigoMovNomina)
                    .HasConstraintName("nomcargaarchivomovimientonomina_fk");

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomCargaArchivos)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomcargaarchivopersona_fk");
            });

            modelBuilder.Entity<NomComunicacione>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoArea).HasMaxLength(5);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Extencion).HasPrecision(5);

                entity.Property(e => e.LineaComunicacion).HasMaxLength(50);

                entity.Property(e => e.Principal).HasPrecision(1);

                entity.Property(e => e.TipoComunicacionId).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomComunicaciones)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomcomunicacionescodigopersona_fk");

                entity.HasOne(d => d.TipoComunicacion)
                    .WithMany(p => p.NomComunicaciones)
                    .HasForeignKey(d => d.TipoComunicacionId)
                    .HasConstraintName("nomcomunicacionestipocomunicacion_fk");
            });

            modelBuilder.Entity<NomConcepto>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Automatico).HasPrecision(1);

                entity.Property(e => e.Codigo).HasMaxLength(5);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPuc).HasPrecision(10);

                entity.Property(e => e.CodigoTipoNomina).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Dedusible).HasPrecision(1);

                entity.Property(e => e.Denominacion).HasMaxLength(100);

                entity.Property(e => e.Descripcion).HasMaxLength(1000);

                entity.Property(e => e.FrecuenciaId).HasPrecision(10);

                entity.Property(e => e.ModuloId).HasPrecision(10);

                entity.Property(e => e.Status).HasMaxLength(1);

                entity.Property(e => e.TipoConcepto)
                    .HasMaxLength(1)
                    .HasColumnName("Tipo_concepto");

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoTipoNominaNavigation)
                    .WithMany(p => p.NomConceptos)
                    .HasForeignKey(d => d.CodigoTipoNomina)
                    .HasConstraintName("nomconceptostiponomina_fk");

                entity.HasOne(d => d.Frecuencia)
                    .WithMany(p => p.NomConceptoFrecuencia)
                    .HasForeignKey(d => d.FrecuenciaId)
                    .HasConstraintName("nomconceptos_fk");

                entity.HasOne(d => d.Modulo)
                    .WithMany(p => p.NomConceptoModulos)
                    .HasForeignKey(d => d.ModuloId)
                    .HasConstraintName("nomconceptosmoduloid_fk");
            });

            modelBuilder.Entity<NomConceptosPuc>(entity =>
            {
                entity.ToTable("NomConceptosPuc");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoConcepto).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPresupuesto).HasPrecision(10);

                entity.Property(e => e.CodigoPuc).HasPrecision(10);

                entity.Property(e => e.Complemnto1).HasMaxLength(100);

                entity.Property(e => e.Complemnto2).HasMaxLength(100);

                entity.Property(e => e.Complemnto3).HasMaxLength(100);

                entity.Property(e => e.Complemnto4).HasMaxLength(100);

                entity.Property(e => e.Complemnto5).HasMaxLength(100);

                entity.Property(e => e.Estatus).HasPrecision(1);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoConceptoNavigation)
                    .WithMany(p => p.NomConceptosPucs)
                    .HasForeignKey(d => d.CodigoConcepto)
                    .HasConstraintName("rh_conceptos_pucconcepto_fk");

                entity.HasOne(d => d.CodigoPresupuestoNavigation)
                    .WithMany(p => p.NomConceptosPucs)
                    .HasForeignKey(d => d.CodigoPresupuesto)
                    .HasConstraintName("rh_conceptos_puc_fk");

                entity.HasOne(d => d.CodigoPucNavigation)
                    .WithMany(p => p.NomConceptosPucs)
                    .HasForeignKey(d => d.CodigoPuc)
                    .HasConstraintName("rh_conceptos_puc_codigopucfk");
            });

            modelBuilder.Entity<NomControlHorario>(entity =>
            {
                entity.ToTable("NomControlHorario");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.CodigoTipoNomina).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Horas).HasPrecision(10);

                entity.Property(e => e.TipoHoraId).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomControlHorarios)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomctrlhorariocodigopersona_fk");

                entity.HasOne(d => d.CodigoTipoNominaNavigation)
                    .WithMany(p => p.NomControlHorarios)
                    .HasForeignKey(d => d.CodigoTipoNomina)
                    .HasConstraintName("nomctrlhorariotiponomina_fk");
            });

            modelBuilder.Entity<NomControlProceso>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoTipoNomina).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.NumeroProceso).HasMaxLength(20);

                entity.Property(e => e.ProcesoId).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoTipoNominaNavigation)
                    .WithMany(p => p.NomControlProcesos)
                    .HasForeignKey(d => d.CodigoTipoNomina)
                    .HasConstraintName("nomcontrolprocesos_fk");
            });

            modelBuilder.Entity<NomDescriptiva>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Codigo).HasMaxLength(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.DescripcionPadreId).HasPrecision(10);

                entity.Property(e => e.NomTituloId).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.NomTitulo)
                    .WithMany(p => p.NomDescriptivas)
                    .HasForeignKey(d => d.NomTituloId)
                    .HasConstraintName("nomdescriptivas_fk");
            });

            modelBuilder.Entity<NomDescuentoLey>(entity =>
            {
                entity.ToTable("NomDescuentoLey");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoConcepto).HasPrecision(10);

                entity.Property(e => e.CodigoConceptoPendiente).HasPrecision(10);

                entity.Property(e => e.CodigoConceptoReintegro).HasPrecision(10);

                entity.Property(e => e.CodigoDescuentoLeyId).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoTipoNomina).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.LeyId).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoConceptoNavigation)
                    .WithMany(p => p.NomDescuentoLeys)
                    .HasForeignKey(d => d.CodigoConcepto)
                    .HasConstraintName("nomdescuentoleyconcepto_fk");

                entity.HasOne(d => d.CodigoDescuentoLey)
                    .WithMany(p => p.NomDescuentoLeyCodigoDescuentoLeys)
                    .HasForeignKey(d => d.CodigoDescuentoLeyId)
                    .HasConstraintName("nomdescuentoleycodigodescuentoleyid_fk");

                entity.HasOne(d => d.CodigoTipoNominaNavigation)
                    .WithMany(p => p.NomDescuentoLeys)
                    .HasForeignKey(d => d.CodigoTipoNomina)
                    .HasConstraintName("nomdescuentoleytiponomina_fk");

                entity.HasOne(d => d.Ley)
                    .WithMany(p => p.NomDescuentoLeyLeys)
                    .HasForeignKey(d => d.LeyId)
                    .HasConstraintName("nomdescuentoleyleyid_fk");
            });

            modelBuilder.Entity<NomDescuentoLeyTrabajador>(entity =>
            {
                entity.ToTable("NomDescuentoLeyTrabajador");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoDescuentoLey).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.Complemnto1).HasMaxLength(100);

                entity.Property(e => e.Complemnto2).HasMaxLength(100);

                entity.Property(e => e.Complemnto3).HasMaxLength(100);

                entity.Property(e => e.PorDesLeyPatrono).HasPrecision(10);

                entity.Property(e => e.PorDesLeyTrabajador).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoDescuentoLeyNavigation)
                    .WithMany(p => p.NomDescuentoLeyTrabajadors)
                    .HasForeignKey(d => d.CodigoDescuentoLey)
                    .HasConstraintName("rh_descuento_ley_trabajadordescuentoley_fk");

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomDescuentoLeyTrabajadors)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("rh_descuento_ley_trabajadorpersona_fk");
            });

            modelBuilder.Entity<NomDetalleLiquidacione>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CodigoEgreso).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.ComplementoConcepto).HasMaxLength(100);

                entity.Property(e => e.ConceptoId).HasPrecision(10);

                entity.Property(e => e.Dias).HasPrecision(10, 2);

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Observacion).HasMaxLength(100);

                entity.Property(e => e.TipoDetalle).HasMaxLength(1);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoEgresoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CodigoEgreso)
                    .HasConstraintName("nomdetalleliquidacionescodigoegreso_fk");

                entity.HasOne(d => d.Concepto)
                    .WithMany()
                    .HasForeignKey(d => d.ConceptoId)
                    .HasConstraintName("nomdetalleliquidaciones_fk");
            });

            modelBuilder.Entity<NomDireccione>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CiudadId).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.CodigoPostal).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.ComplementoDir).HasMaxLength(200);

                entity.Property(e => e.DireccionId).HasPrecision(10);

                entity.Property(e => e.EstadoId).HasPrecision(10);

                entity.Property(e => e.ManzanaId).HasPrecision(10);

                entity.Property(e => e.MunicipioId).HasPrecision(10);

                entity.Property(e => e.Nivel).HasMaxLength(20);

                entity.Property(e => e.NroVivienda).HasMaxLength(20);

                entity.Property(e => e.PaisId).HasPrecision(10);

                entity.Property(e => e.ParcelaId).HasPrecision(10);

                entity.Property(e => e.ParroquiaId).HasPrecision(10);

                entity.Property(e => e.Principal).HasPrecision(1);

                entity.Property(e => e.SectorId).HasPrecision(10);

                entity.Property(e => e.TenenciaId).HasPrecision(5);

                entity.Property(e => e.TipoNivelId).HasPrecision(10);

                entity.Property(e => e.TipoViviendaId).HasPrecision(10);

                entity.Property(e => e.UrbanizacionId).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.Property(e => e.Vialidad)
                    .HasMaxLength(100)
                    .HasColumnName("vialidad");

                entity.Property(e => e.VialidadId).HasPrecision(10);

                entity.Property(e => e.Vivienda)
                    .HasMaxLength(100)
                    .HasColumnName("vivienda");

                entity.Property(e => e.ViviendaId).HasPrecision(10);

                entity.HasOne(d => d.Ciudad)
                    .WithMany(p => p.NomDireccioneCiudads)
                    .HasForeignKey(d => d.CiudadId)
                    .HasConstraintName("nomdireccionesciudad_fk");

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomDirecciones)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomdireccionespersona_fk");

                entity.HasOne(d => d.Direccion)
                    .WithMany(p => p.NomDireccioneDireccions)
                    .HasForeignKey(d => d.DireccionId)
                    .HasConstraintName("nomdireccionesdireccion_fk");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.NomDireccioneEstados)
                    .HasForeignKey(d => d.EstadoId)
                    .HasConstraintName("nomdireccionesestado_fk");

                entity.HasOne(d => d.Manzana)
                    .WithMany(p => p.NomDireccioneManzanas)
                    .HasForeignKey(d => d.ManzanaId)
                    .HasConstraintName("nomdireccionesmanzaba_fk");

                entity.HasOne(d => d.Municipio)
                    .WithMany(p => p.NomDireccioneMunicipios)
                    .HasForeignKey(d => d.MunicipioId)
                    .HasConstraintName("nomdireccionesmunicipio_fk");

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.NomDireccionePais)
                    .HasForeignKey(d => d.PaisId)
                    .HasConstraintName("nomdireccionespais_fk");

                entity.HasOne(d => d.Parcela)
                    .WithMany(p => p.NomDireccioneParcelas)
                    .HasForeignKey(d => d.ParcelaId)
                    .HasConstraintName("nomdireccionesparcela_fk");

                entity.HasOne(d => d.Parroquia)
                    .WithMany(p => p.NomDireccioneParroquia)
                    .HasForeignKey(d => d.ParroquiaId)
                    .HasConstraintName("nomdirecciones_fk");

                entity.HasOne(d => d.Sector)
                    .WithMany(p => p.NomDireccioneSectors)
                    .HasForeignKey(d => d.SectorId)
                    .HasConstraintName("nomdireccionessector_fk");

                entity.HasOne(d => d.Tenencia)
                    .WithMany(p => p.NomDireccioneTenencia)
                    .HasForeignKey(d => d.TenenciaId)
                    .HasConstraintName("nomdireccionestenencia_fk");

                entity.HasOne(d => d.TipoNivel)
                    .WithMany(p => p.NomDireccioneTipoNivels)
                    .HasForeignKey(d => d.TipoNivelId)
                    .HasConstraintName("nomdireccionestiponivel_fk");

                entity.HasOne(d => d.TipoVivienda)
                    .WithMany(p => p.NomDireccioneTipoVivienda)
                    .HasForeignKey(d => d.TipoViviendaId)
                    .HasConstraintName("nomdireccionestipovivienda_fk");

                entity.HasOne(d => d.Urbanizacion)
                    .WithMany(p => p.NomDireccioneUrbanizacions)
                    .HasForeignKey(d => d.UrbanizacionId)
                    .HasConstraintName("nomdireccionesurbanizacion_fk");

                entity.HasOne(d => d.VialidadNavigation)
                    .WithMany(p => p.NomDireccioneVialidadNavigations)
                    .HasForeignKey(d => d.VialidadId)
                    .HasConstraintName("nomdireccionesvialidad_fk");

                entity.HasOne(d => d.ViviendaNavigation)
                    .WithMany(p => p.NomDireccioneViviendaNavigations)
                    .HasForeignKey(d => d.ViviendaId)
                    .HasConstraintName("nomdireccionesvivienda_fk");
            });

            modelBuilder.Entity<NomDocumento>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.GradoId).HasPrecision(10);

                entity.Property(e => e.NumeroDocumento).HasMaxLength(20);

                entity.Property(e => e.TipoDocumentoId).HasPrecision(10);

                entity.Property(e => e.TipoGradoId).HasPrecision(10);

                entity.Property(e => e.UsuarioActuaclizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomDocumentos)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomdocumentoscodigopersona_fk");

                entity.HasOne(d => d.Grado)
                    .WithMany(p => p.NomDocumentoGrados)
                    .HasForeignKey(d => d.GradoId)
                    .HasConstraintName("nomdocumentos_fk");

                entity.HasOne(d => d.TipoDocumento)
                    .WithMany(p => p.NomDocumentoTipoDocumentos)
                    .HasForeignKey(d => d.TipoDocumentoId)
                    .HasConstraintName("nomdocumentostipodocumento_fk");

                entity.HasOne(d => d.TipoGrado)
                    .WithMany(p => p.NomDocumentoTipoGrados)
                    .HasForeignKey(d => d.TipoGradoId)
                    .HasConstraintName("nomdocumentostipogradoid_fk");
            });

            modelBuilder.Entity<NomDocumentosDetalle>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoDocumento).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Descripcion).HasMaxLength(1000);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoDocumentoNavigation)
                    .WithMany(p => p.NomDocumentosDetalles)
                    .HasForeignKey(d => d.CodigoDocumento)
                    .HasConstraintName("nomdocumentosdetalles_fk");
            });

            modelBuilder.Entity<NomEducacion>(entity =>
            {
                entity.ToTable("NomEducacion");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.Graduado).HasMaxLength(1);

                entity.Property(e => e.LocalidadInstituto).HasMaxLength(50);

                entity.Property(e => e.MencionEspecialidadId).HasPrecision(10);

                entity.Property(e => e.NivelId).HasPrecision(10);

                entity.Property(e => e.NombreInstituto).HasMaxLength(50);

                entity.Property(e => e.ProfesionId).HasPrecision(10);

                entity.Property(e => e.TituloId).HasPrecision(10);

                entity.Property(e => e.UltimoAñoAprobado).HasPrecision(4);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomEducacions)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomeducacionpersona_fk");

                entity.HasOne(d => d.MencionEspecialidad)
                    .WithMany(p => p.NomEducacionMencionEspecialidads)
                    .HasForeignKey(d => d.MencionEspecialidadId)
                    .HasConstraintName("nomeducacionmencionespecialidad_fk");

                entity.HasOne(d => d.Nivel)
                    .WithMany(p => p.NomEducacionNivels)
                    .HasForeignKey(d => d.NivelId)
                    .HasConstraintName("nomeducacionnivel_fk");

                entity.HasOne(d => d.Profesion)
                    .WithMany(p => p.NomEducacionProfesions)
                    .HasForeignKey(d => d.ProfesionId)
                    .HasConstraintName("nomeducacionprofesion_fk");

                entity.HasOne(d => d.Titulo)
                    .WithMany(p => p.NomEducacionTitulos)
                    .HasForeignKey(d => d.TituloId)
                    .HasConstraintName("nomeducaciontitulo_fk");
            });

            modelBuilder.Entity<NomEgreso>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.CodigoRelacionCargo).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Observaciones).HasMaxLength(300);

                entity.Property(e => e.TipoEgresoId).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomEgresos)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomegresospersona_fk");

                entity.HasOne(d => d.CodigoRelacionCargoNavigation)
                    .WithMany(p => p.NomEgresos)
                    .HasForeignKey(d => d.CodigoRelacionCargo)
                    .HasConstraintName("nomegresosrelacioncargo_fk");

                entity.HasOne(d => d.TipoEgreso)
                    .WithMany(p => p.NomEgresos)
                    .HasForeignKey(d => d.TipoEgresoId)
                    .HasConstraintName("nomegresos_fk");
            });

            modelBuilder.Entity<NomEntradaSalidum>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.Complemento10).HasMaxLength(100);

                entity.Property(e => e.Complemento11).HasMaxLength(100);

                entity.Property(e => e.Complemento12).HasMaxLength(100);

                entity.Property(e => e.Complemento13).HasMaxLength(100);

                entity.Property(e => e.Complemento14).HasMaxLength(100);

                entity.Property(e => e.Complemento15).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.Complemento6).HasMaxLength(100);

                entity.Property(e => e.Complemento7).HasMaxLength(100);

                entity.Property(e => e.Complemento8).HasMaxLength(100);

                entity.Property(e => e.Complemento9).HasMaxLength(100);

                entity.Property(e => e.PersonaHorarioId).HasPrecision(10);

                entity.Property(e => e.Status).HasMaxLength(2);

                entity.Property(e => e.TipoMov).HasMaxLength(2);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomEntradaSalida)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomentradasalidapersona_fk");

                entity.HasOne(d => d.PersonaHorario)
                    .WithMany(p => p.NomEntradaSalida)
                    .HasForeignKey(d => d.PersonaHorarioId)
                    .HasConstraintName("nomentradasalidapersonahorarioid_fk");
            });

            modelBuilder.Entity<NomEscalaAguinaldo>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPeriodoAguinaldo).HasPrecision(10);

                entity.Property(e => e.CodigoPeriodoDesde).HasPrecision(10);

                entity.Property(e => e.CodigoPeriodoHasta).HasPrecision(10);

                entity.Property(e => e.CodigoTipoNomina).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.DiasAguinaldo).HasPrecision(3);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoPeriodoAguinaldoNavigation)
                    .WithMany(p => p.NomEscalaAguinaldoCodigoPeriodoAguinaldoNavigations)
                    .HasForeignKey(d => d.CodigoPeriodoAguinaldo)
                    .HasConstraintName("nomescalaaguinaldosperiodoaguinaldo_fk");

                entity.HasOne(d => d.CodigoPeriodoDesdeNavigation)
                    .WithMany(p => p.NomEscalaAguinaldoCodigoPeriodoDesdeNavigations)
                    .HasForeignKey(d => d.CodigoPeriodoDesde)
                    .HasConstraintName("nomescalaaguinaldosperiododesde_fk");

                entity.HasOne(d => d.CodigoPeriodoHastaNavigation)
                    .WithMany(p => p.NomEscalaAguinaldoCodigoPeriodoHastaNavigations)
                    .HasForeignKey(d => d.CodigoPeriodoHasta)
                    .HasConstraintName("nomescalaaguinaldosperiodohasta_fk");

                entity.HasOne(d => d.CodigoTipoNominaNavigation)
                    .WithMany(p => p.NomEscalaAguinaldos)
                    .HasForeignKey(d => d.CodigoTipoNomina)
                    .HasConstraintName("nomescalaaguinaldos_fk");
            });

            modelBuilder.Entity<NomEscalaHcm>(entity =>
            {
                entity.ToTable("NomEscalaHcm");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.AseguradoraId).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.EdadMax).HasPrecision(3);

                entity.Property(e => e.EdadMin).HasPrecision(3);

                entity.Property(e => e.Observacion).HasMaxLength(1000);

                entity.Property(e => e.ParienteId).HasPrecision(10);

                entity.Property(e => e.Sexo).HasMaxLength(1);

                entity.Property(e => e.UsuarioActuaclizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.Aseguradora)
                    .WithMany(p => p.NomEscalaHcmAseguradoras)
                    .HasForeignKey(d => d.AseguradoraId)
                    .HasConstraintName("nomescalahcmaseguradoraid_fk");

                entity.HasOne(d => d.Pariente)
                    .WithMany(p => p.NomEscalaHcmParientes)
                    .HasForeignKey(d => d.ParienteId)
                    .HasConstraintName("nomescalahcmparienteid_fk");
            });

            modelBuilder.Entity<NomEscalaHoraExtra>(entity =>
            {
                entity.ToTable("NomEscalaHoraExtra");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoTipoNomina).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.DiaHora).HasPrecision(1);

                entity.Property(e => e.PrecisionDecimal).HasPrecision(1);

                entity.Property(e => e.TipoHora)
                    .HasMaxLength(1)
                    .HasColumnName("tipo_hora");

                entity.Property(e => e.TipoSueldo)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoTipoNominaNavigation)
                    .WithMany(p => p.NomEscalaHoraExtras)
                    .HasForeignKey(d => d.CodigoTipoNomina)
                    .HasConstraintName("nomescalahoraextra_fk");
            });

            modelBuilder.Entity<NomEscalaIslr>(entity =>
            {
                entity.ToTable("NomEscalaIslr");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.NumeroTarifa).HasPrecision(10);

                entity.Property(e => e.SustraendoUt).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);
            });

            modelBuilder.Entity<NomEscalaJuguete>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoTipoNomina).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.EdadMax).HasPrecision(3);

                entity.Property(e => e.EdadMin).HasPrecision(3);

                entity.Property(e => e.ParienteId).HasPrecision(10);

                entity.Property(e => e.Sexo).HasMaxLength(1);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.Pariente)
                    .WithMany(p => p.NomEscalaJuguetes)
                    .HasForeignKey(d => d.ParienteId)
                    .HasConstraintName("nomescalajuguetes_fk");
            });

            modelBuilder.Entity<NomEscalaUtilEscolar>(entity =>
            {
                entity.ToTable("NomEscalaUtilEscolar");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoTipoNomina).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.Grado).HasPrecision(2);

                entity.Property(e => e.NivelEducativoId).HasPrecision(10);

                entity.Property(e => e.ParienteId).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoTipoNominaNavigation)
                    .WithMany(p => p.NomEscalaUtilEscolars)
                    .HasForeignKey(d => d.CodigoTipoNomina)
                    .HasConstraintName("nomescalautilescolartiponomina_fk");

                entity.HasOne(d => d.NivelEducativo)
                    .WithMany(p => p.NomEscalaUtilEscolars)
                    .HasForeignKey(d => d.NivelEducativoId)
                    .HasConstraintName("nomescalautilescolar_fk");

                entity.HasOne(d => d.Pariente)
                    .WithMany(p => p.NomEscalaUtilEscolars)
                    .HasForeignKey(d => d.ParienteId)
                    .HasConstraintName("nomescalautilescolarpariente_fk");
            });

            modelBuilder.Entity<NomEscalaVacacione>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CantidadAños).HasPrecision(10);

                entity.Property(e => e.CantidadDiasBonos).HasPrecision(10);

                entity.Property(e => e.CantidadDiasHabiles).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(500);

                entity.Property(e => e.Complemento2).HasMaxLength(500);

                entity.Property(e => e.Complemento3).HasMaxLength(500);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.Observacion).HasMaxLength(2000);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);
            });

            modelBuilder.Entity<NomExperienciaLaboral>(entity =>
            {
                entity.ToTable("NomExperienciaLaboral");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Cargo).HasMaxLength(50);

                entity.Property(e => e.CargoSupervisor).HasMaxLength(50);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Complemento4)
                    .HasMaxLength(100)
                    .HasColumnName("complemento4");

                entity.Property(e => e.Complemento5)
                    .HasMaxLength(100)
                    .HasColumnName("complemento5");

                entity.Property(e => e.Descripcion).HasMaxLength(1000);

                entity.Property(e => e.NombreEmpresa).HasMaxLength(50);

                entity.Property(e => e.RamoId).HasPrecision(5);

                entity.Property(e => e.Supervisor).HasMaxLength(50);

                entity.Property(e => e.Telefono).HasMaxLength(20);

                entity.Property(e => e.TipoEmpresa).HasMaxLength(1);

                entity.Property(e => e.UltimoSueldo).HasPrecision(16, 2);

                entity.Property(e => e.UsuarioActualizacion).HasMaxLength(10);

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(10);

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomExperienciaLaborals)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomexperiencialaboralpersona_fk");

                entity.HasOne(d => d.Ramo)
                    .WithMany(p => p.NomExperienciaLaborals)
                    .HasForeignKey(d => d.RamoId)
                    .HasConstraintName("nomexperiencialaboralramoid_fk");
            });

            modelBuilder.Entity<NomFamiliare>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Apellido).HasMaxLength(50);

                entity.Property(e => e.CedulaFamiliar).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Grado).HasPrecision(2);

                entity.Property(e => e.Nacionalidad).HasMaxLength(1);

                entity.Property(e => e.NivelEducativoId).HasPrecision(5);

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.ParienteId).HasPrecision(5);

                entity.Property(e => e.Sexo).HasMaxLength(1);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomFamiliares)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomfamiliarescodigopersona_fk");

                entity.HasOne(d => d.NivelEducativo)
                    .WithMany(p => p.NomFamiliares)
                    .HasForeignKey(d => d.NivelEducativoId)
                    .HasConstraintName("rh_familiaresniveleducativo_fk");
            });

            modelBuilder.Entity<NomFiadorCajaAhorro>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPersonaFiador).HasPrecision(10);

                entity.Property(e => e.CodigoPreCajaAho).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);
            });

            modelBuilder.Entity<NomFormulaConcepto>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoConcepto).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(500);

                entity.Property(e => e.Complemento2).HasMaxLength(500);

                entity.Property(e => e.Complemento3).HasMaxLength(500);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.TipoSueldo).HasMaxLength(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoConceptoNavigation)
                    .WithMany(p => p.NomFormulaConceptos)
                    .HasForeignKey(d => d.CodigoConcepto)
                    .HasConstraintName("rh_formula_conceptos_fk");
            });

            modelBuilder.Entity<NomHcm>(entity =>
            {
                entity.ToTable("NomHcm");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.AseguradoraId).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoFamiliar).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemnto3).HasMaxLength(100);

                entity.Property(e => e.TipoAportePatron).HasMaxLength(1);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.Aseguradora)
                    .WithMany(p => p.NomHcms)
                    .HasForeignKey(d => d.AseguradoraId)
                    .HasConstraintName("nomhcmaseguradoraid_fk");

                entity.HasOne(d => d.CodigoFamiliarNavigation)
                    .WithMany(p => p.NomHcms)
                    .HasForeignKey(d => d.CodigoFamiliar)
                    .HasConstraintName("nomhcmfamiliar_fk");

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomHcms)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomhcmpersona_fk");
            });

            modelBuilder.Entity<NomHistoricoBecado>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoBecado).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoFamiliar).HasPrecision(10);

                entity.Property(e => e.CodigoPeriodo).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.CodigoTipoNomina).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Observacion).HasMaxLength(1000);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoBecadoNavigation)
                    .WithMany(p => p.NomHistoricoBecados)
                    .HasForeignKey(d => d.CodigoBecado)
                    .HasConstraintName("rh_historico_becadosbecado_fk");

                entity.HasOne(d => d.CodigoFamiliarNavigation)
                    .WithMany(p => p.NomHistoricoBecados)
                    .HasForeignKey(d => d.CodigoFamiliar)
                    .HasConstraintName("rh_historico_becadosfamiliar_fk");

                entity.HasOne(d => d.CodigoPeriodoNavigation)
                    .WithMany(p => p.NomHistoricoBecados)
                    .HasForeignKey(d => d.CodigoPeriodo)
                    .HasConstraintName("rh_historico_becadosperiodo_fk");

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomHistoricoBecados)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("rh_historico_becadospersona_fk");

                entity.HasOne(d => d.CodigoTipoNominaNavigation)
                    .WithMany(p => p.NomHistoricoBecados)
                    .HasForeignKey(d => d.CodigoTipoNomina)
                    .HasConstraintName("rh_historico_becadostiponomoina_fk");
            });

            modelBuilder.Entity<NomHistoricoNomina>(entity =>
            {
                entity.ToTable("NomHistoricoNomina");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoConcepto).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPeriodo).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.CodigoTipoNomina).HasPrecision(10);

                entity.Property(e => e.Comlemento2).HasMaxLength(100);

                entity.Property(e => e.Comlemento3).HasMaxLength(100);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.ComplementoConcepto).HasMaxLength(100);

                entity.Property(e => e.FechaActualizacion).HasColumnName("Fecha_Actualizacion");

                entity.Property(e => e.FrecuenciaId).HasPrecision(10);

                entity.Property(e => e.Status).HasMaxLength(1);

                entity.Property(e => e.Tipo).HasMaxLength(1);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoConceptoNavigation)
                    .WithMany(p => p.NomHistoricoNominas)
                    .HasForeignKey(d => d.CodigoConcepto)
                    .HasConstraintName("nomhistoriconominacodigoconcepto_fk");

                entity.HasOne(d => d.CodigoPeriodoNavigation)
                    .WithMany(p => p.NomHistoricoNominas)
                    .HasForeignKey(d => d.CodigoPeriodo)
                    .HasConstraintName("nomhistoriconominacodigoperiodo_fk");

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomHistoricoNominas)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomhistoriconominacodigopersona_fk");

                entity.HasOne(d => d.CodigoTipoNominaNavigation)
                    .WithMany(p => p.NomHistoricoNominas)
                    .HasForeignKey(d => d.CodigoTipoNomina)
                    .HasConstraintName("nomhistoriconominatipoomina_fk");

                entity.HasOne(d => d.Frecuencia)
                    .WithMany(p => p.NomHistoricoNominas)
                    .HasForeignKey(d => d.FrecuenciaId)
                    .HasConstraintName("nomhistoriconominafrecuenciaid_fk");
            });

            modelBuilder.Entity<NomHistoricoPersonalCargo>(entity =>
            {
                entity.ToTable("NomHistoricoPersonalCargo");

                entity.HasIndex(e => e.Cedula, "nomhistoricopersonalcargo_cedula_idx");

                entity.HasIndex(e => e.CodigoPersona, "nomhistoricopersonalcargo_codigopersona_idx");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Apellido).HasMaxLength(50);

                entity.Property(e => e.BancoId).HasPrecision(5);

                entity.Property(e => e.CargoCodigo).HasMaxLength(10);

                entity.Property(e => e.Cedula).HasPrecision(10);

                entity.Property(e => e.CodigoCargo).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoIcp).HasPrecision(10);

                entity.Property(e => e.CodigoIcpUbicacion).HasPrecision(10);

                entity.Property(e => e.CodigoPeriodo).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.CodigoPrograma)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.CodigoRelacionCargo).HasPrecision(10);

                entity.Property(e => e.CodigoSector)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.CodigoTipoNomina).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.DescripcionBanco).HasMaxLength(100);

                entity.Property(e => e.DescripcionCargo).HasMaxLength(100);

                entity.Property(e => e.DescripcionNacionalidad)
                    .HasMaxLength(10)
                    .HasColumnName("Descripcion_nacionalidad");

                entity.Property(e => e.DescripcionSexo).HasMaxLength(9);

                entity.Property(e => e.DescripcionStatus).HasMaxLength(10);

                entity.Property(e => e.DescripcionTipoCuenta).HasMaxLength(100);

                entity.Property(e => e.Foto).HasMaxLength(44);

                entity.Property(e => e.FrecuenciaPagoId).HasPrecision(10);

                entity.Property(e => e.Nacionalidad).HasMaxLength(1);

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.NroCuenta).HasMaxLength(20);

                entity.Property(e => e.Sexo).HasMaxLength(1);

                entity.Property(e => e.Status).HasMaxLength(1);

                entity.Property(e => e.TipoCuentaId).HasPrecision(5);

                entity.Property(e => e.TipoNomina).HasMaxLength(100);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);
            });

            modelBuilder.Entity<NomHorario>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoTipoNomina).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Halmuerzo)
                    .HasPrecision(2)
                    .HasColumnName("HAlmuerzo");

                entity.Property(e => e.NombreHorario).HasMaxLength(100);

                entity.Property(e => e.NumeroHorario).HasMaxLength(20);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoTipoNominaNavigation)
                    .WithMany(p => p.NomHorarios)
                    .HasForeignKey(d => d.CodigoTipoNomina)
                    .HasConstraintName("rh_horarios_fk");
            });

            modelBuilder.Entity<NomHorarioPersona>(entity =>
            {
                entity.ToTable("NomHorarioPersona");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoHdom)
                    .HasPrecision(10)
                    .HasColumnName("CodigoHDom");

                entity.Property(e => e.CodigoHjue)
                    .HasPrecision(10)
                    .HasColumnName("CodigoHJue");

                entity.Property(e => e.CodigoHlun)
                    .HasPrecision(10)
                    .HasColumnName("CodigoHLun");

                entity.Property(e => e.CodigoHmar)
                    .HasPrecision(10)
                    .HasColumnName("CodigoHMar");

                entity.Property(e => e.CodigoHmie)
                    .HasPrecision(10)
                    .HasColumnName("CodigoHMie");

                entity.Property(e => e.CodigoHsab)
                    .HasPrecision(10)
                    .HasColumnName("CodigoHSab");

                entity.Property(e => e.CodigoHvie)
                    .HasPrecision(10)
                    .HasColumnName("CodigoHVie");

                entity.Property(e => e.CodigoIcp).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoHdomNavigation)
                    .WithMany(p => p.NomHorarioPersonaCodigoHdomNavigations)
                    .HasForeignKey(d => d.CodigoHdom)
                    .HasConstraintName("nomhorariopersonahorariodomingo_fk");

                entity.HasOne(d => d.CodigoHjueNavigation)
                    .WithMany(p => p.NomHorarioPersonaCodigoHjueNavigations)
                    .HasForeignKey(d => d.CodigoHjue)
                    .HasConstraintName("nomhorariopersonahorariojueves_fk");

                entity.HasOne(d => d.CodigoHlunNavigation)
                    .WithMany(p => p.NomHorarioPersonaCodigoHlunNavigations)
                    .HasForeignKey(d => d.CodigoHlun)
                    .HasConstraintName("nomhorariopersonahorariolunes_fk");

                entity.HasOne(d => d.CodigoHmarNavigation)
                    .WithMany(p => p.NomHorarioPersonaCodigoHmarNavigations)
                    .HasForeignKey(d => d.CodigoHmar)
                    .HasConstraintName("nomhorariopersonahorariomartes_fk");

                entity.HasOne(d => d.CodigoHmieNavigation)
                    .WithMany(p => p.NomHorarioPersonaCodigoHmieNavigations)
                    .HasForeignKey(d => d.CodigoHmie)
                    .HasConstraintName("nomhorariopersonahorariomiercores_fk");

                entity.HasOne(d => d.CodigoHsabNavigation)
                    .WithMany(p => p.NomHorarioPersonaCodigoHsabNavigations)
                    .HasForeignKey(d => d.CodigoHsab)
                    .HasConstraintName("nomhorariopersonahorariosabado_fk");

                entity.HasOne(d => d.CodigoHvieNavigation)
                    .WithMany(p => p.NomHorarioPersonaCodigoHvieNavigations)
                    .HasForeignKey(d => d.CodigoHvie)
                    .HasConstraintName("nomhorariopersonahorarioviernes_fk");

                entity.HasOne(d => d.CodigoIcpNavigation)
                    .WithMany(p => p.NomHorarioPersonas)
                    .HasForeignKey(d => d.CodigoIcp)
                    .HasConstraintName("nomhorariopersonacodigoicp_fk");

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomHorarioPersonas)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomhorariopersonacodigopersona_fk");
            });

            modelBuilder.Entity<NomHorasExtra>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPeriodo).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.CodigoTipoNomina).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoPeriodoNavigation)
                    .WithMany(p => p.NomHorasExtras)
                    .HasForeignKey(d => d.CodigoPeriodo)
                    .HasConstraintName("nomhorasextrasperiodo_fk");

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomHorasExtras)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomhorasextraspersona_fk");

                entity.HasOne(d => d.CodigoTipoNominaNavigation)
                    .WithMany(p => p.NomHorasExtras)
                    .HasForeignKey(d => d.CodigoTipoNomina)
                    .HasConstraintName("nomhorasextrastiponomina_fk");
            });

            modelBuilder.Entity<NomMoneda>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(500);

                entity.Property(e => e.Complemento2).HasMaxLength(500);

                entity.Property(e => e.Complemento3).HasMaxLength(500);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.Denominacion).HasMaxLength(500);

                entity.Property(e => e.TipoMonedaId).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);
            });

            modelBuilder.Entity<NomMovCajaAhorro>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoMovId).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.CodigoPreCajaAho).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoMov)
                    .WithMany(p => p.NomMovCajaAhorros)
                    .HasForeignKey(d => d.CodigoMovId)
                    .HasConstraintName("nommovcajaahorrosmovid_fk");

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomMovCajaAhorros)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nommovcajaahorrospersonas_fk");

                entity.HasOne(d => d.CodigoPreCajaAhoNavigation)
                    .WithMany(p => p.NomMovCajaAhorros)
                    .HasForeignKey(d => d.CodigoPreCajaAho)
                    .HasConstraintName("nommovcajaahorrospresupuesto_fk");
            });

            modelBuilder.Entity<NomMovMasivo>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoConcepto).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPeriodo).HasPrecision(10);

                entity.Property(e => e.CodigoTipoNomina).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.ComplementoConcepto).HasMaxLength(100);

                entity.Property(e => e.CriterioBusqueda).HasMaxLength(1000);

                entity.Property(e => e.FrecuenciaId).HasPrecision(10);

                entity.Property(e => e.OrigenMonto)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Status).HasMaxLength(1);

                entity.Property(e => e.Tipo).HasMaxLength(1);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoConceptoNavigation)
                    .WithMany(p => p.NomMovMasivos)
                    .HasForeignKey(d => d.CodigoConcepto)
                    .HasConstraintName("nommovmasivosconcepto_fk");

                entity.HasOne(d => d.CodigoPeriodoNavigation)
                    .WithMany(p => p.NomMovMasivos)
                    .HasForeignKey(d => d.CodigoPeriodo)
                    .HasConstraintName("nommovmasivosperiodo_fk");

                entity.HasOne(d => d.CodigoTipoNominaNavigation)
                    .WithMany(p => p.NomMovMasivos)
                    .HasForeignKey(d => d.CodigoTipoNomina)
                    .HasConstraintName("nommovmasivostiponomina_fk");

                entity.HasOne(d => d.Frecuencia)
                    .WithMany(p => p.NomMovMasivos)
                    .HasForeignKey(d => d.FrecuenciaId)
                    .HasConstraintName("nommovmasivosfrecuencia_fk");
            });

            modelBuilder.Entity<NomMovPrestacione>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.ComplementoConcepto).HasMaxLength(100);

                entity.Property(e => e.ConceptoId).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomMovPrestaciones)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nommovprestacionespersona_fk");

                entity.HasOne(d => d.Concepto)
                    .WithMany(p => p.NomMovPrestaciones)
                    .HasForeignKey(d => d.ConceptoId)
                    .HasConstraintName("nommovprestacionespersonaid_fk");
            });

            modelBuilder.Entity<NomMovimientoNomina>(entity =>
            {
                entity.ToTable("NomMovimientoNomina");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoConcepto).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.CodigoTipoNomina).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.ComplementoConcepto).HasMaxLength(100);

                entity.Property(e => e.FrecuenciaId).HasPrecision(10);

                entity.Property(e => e.Status).HasMaxLength(1);

                entity.Property(e => e.Tipo).HasMaxLength(1);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoConceptoNavigation)
                    .WithMany(p => p.NomMovimientoNominas)
                    .HasForeignKey(d => d.CodigoConcepto)
                    .HasConstraintName("nommovimientonominacodigoconcepto_fk");

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomMovimientoNominas)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nommovimientonominapersona_fk");

                entity.HasOne(d => d.CodigoTipoNominaNavigation)
                    .WithMany(p => p.NomMovimientoNominas)
                    .HasForeignKey(d => d.CodigoTipoNomina)
                    .HasConstraintName("premovimientonominatiponomina_fk");

                entity.HasOne(d => d.Frecuencia)
                    .WithMany(p => p.NomMovimientoNominas)
                    .HasForeignKey(d => d.FrecuenciaId)
                    .HasConstraintName("nommovimientonomina_fk");
            });

            modelBuilder.Entity<NomPeriodo>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoCuentaEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPresupuesto).HasPrecision(10);

                entity.Property(e => e.CodigoTipoNomina).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.Periodo).HasPrecision(1);

                entity.Property(e => e.TipoNomina).HasMaxLength(1);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCierre).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.Property(e => e.UsuarioPrecierre).HasPrecision(10);

                entity.Property(e => e.UsuarioPrenomina).HasPrecision(10);

                entity.HasOne(d => d.CodigoPresupuestoNavigation)
                    .WithMany(p => p.NomPeriodos)
                    .HasForeignKey(d => d.CodigoPresupuesto)
                    .HasConstraintName("nomperiodoscodigopresupuesto_fk");

                entity.HasOne(d => d.CodigoTipoNominaNavigation)
                    .WithMany(p => p.NomPeriodos)
                    .HasForeignKey(d => d.CodigoTipoNomina)
                    .HasConstraintName("nomperiodoscodigotiponomina_fk");
            });

            modelBuilder.Entity<NomPersona>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Apellido).HasMaxLength(50);

                entity.Property(e => e.Cedula).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.EstadoCivilId).HasPrecision(10);

                entity.Property(e => e.EstadoNacimientoId).HasPrecision(10);

                entity.Property(e => e.IdentificacionId).HasPrecision(10);

                entity.Property(e => e.ManoHabil).HasMaxLength(1);

                entity.Property(e => e.Nacionalidad).HasMaxLength(1);

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.NumeroGacetaNacional).HasMaxLength(20);

                entity.Property(e => e.NumeroIdentificacion).HasPrecision(10);

                entity.Property(e => e.PaisNacimientoId).HasPrecision(10);

                entity.Property(e => e.Sexo).HasMaxLength(1);

                entity.Property(e => e.Status).HasMaxLength(1);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.EstadoCivil)
                    .WithMany(p => p.NomPersonaEstadoCivils)
                    .HasForeignKey(d => d.EstadoCivilId)
                    .HasConstraintName("nompersonasestadocivilid_fk");

                entity.HasOne(d => d.EstadoNacimiento)
                    .WithMany(p => p.NomPersonaEstadoNacimientos)
                    .HasForeignKey(d => d.EstadoNacimientoId)
                    .HasConstraintName("nompersonasestadoid_fk");

                entity.HasOne(d => d.Identificacion)
                    .WithMany(p => p.NomPersonaIdentificacions)
                    .HasForeignKey(d => d.IdentificacionId)
                    .HasConstraintName("nompersonasidentificacion_fk_1");

                entity.HasOne(d => d.PaisNacimiento)
                    .WithMany(p => p.NomPersonaPaisNacimientos)
                    .HasForeignKey(d => d.PaisNacimientoId)
                    .HasConstraintName("nompersonaspais_fk");
            });

            modelBuilder.Entity<NomPersonasMovControl>(entity =>
            {
                entity.ToTable("NomPersonasMovControl");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoConcepto).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.ControlAplica).HasPrecision(1);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoConceptoNavigation)
                    .WithMany(p => p.NomPersonasMovControls)
                    .HasForeignKey(d => d.CodigoConcepto)
                    .HasConstraintName("nompersonasmovcontrolcodigoconcepto_fk");

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomPersonasMovControls)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("rh_personas_mov_controlPersonas_fk");
            });

            modelBuilder.Entity<NomPrestamosCajaAhorro>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPeriodo1erPago).HasPrecision(10);

                entity.Property(e => e.CodigoPeriodoUltPago).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.CodigoTipoNomina).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.FrecuenciaPagoId).HasPrecision(10);

                entity.Property(e => e.NumeroCuotas).HasPrecision(5);

                entity.Property(e => e.NumeroCuotasPagadas).HasPrecision(5);

                entity.Property(e => e.PorInteres).HasPrecision(5);

                entity.Property(e => e.Status).HasMaxLength(1);

                entity.Property(e => e.TipoInteresId).HasPrecision(10);

                entity.Property(e => e.TipoPrestamoId).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoPeriodo1erPagoNavigation)
                    .WithMany(p => p.NomPrestamosCajaAhorroCodigoPeriodo1erPagoNavigations)
                    .HasForeignKey(d => d.CodigoPeriodo1erPago)
                    .HasConstraintName("nomprestamoscajaahorrosperiodoprimerpago_fk");

                entity.HasOne(d => d.CodigoPeriodoUltPagoNavigation)
                    .WithMany(p => p.NomPrestamosCajaAhorroCodigoPeriodoUltPagoNavigations)
                    .HasForeignKey(d => d.CodigoPeriodoUltPago)
                    .HasConstraintName("nomprestamoscajaahorrosperiodoultpago_fk");

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomPrestamosCajaAhorros)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomprestamoscajaahorrospersonas_fk");

                entity.HasOne(d => d.CodigoTipoNominaNavigation)
                    .WithMany(p => p.NomPrestamosCajaAhorros)
                    .HasForeignKey(d => d.CodigoTipoNomina)
                    .HasConstraintName("nomprestamoscajaahorrostiponomina_fk");

                entity.HasOne(d => d.TipoPrestamo)
                    .WithMany(p => p.NomPrestamosCajaAhorroTipoPrestamos)
                    .HasForeignKey(d => d.TipoPrestamoId)
                    .HasConstraintName("nomprestamoscajaahorrostipoprestamoid_fk");
            });

            modelBuilder.Entity<NomPrestamosPrestacione>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPeriodo1erPago).HasPrecision(10);

                entity.Property(e => e.CodigoPeriodoUltPago).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.CodigoPrestamoPrestacionRen).HasPrecision(10);

                entity.Property(e => e.CodigoTipoNomina).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.FrecuenciaPagoId).HasPrecision(10);

                entity.Property(e => e.MontoCuota).HasColumnName("monto_cuota");

                entity.Property(e => e.NumeroCuotas).HasPrecision(5);

                entity.Property(e => e.NumeroCuotasPagadas).HasPrecision(5);

                entity.Property(e => e.PorInteres).HasPrecision(5);

                entity.Property(e => e.Status).HasMaxLength(1);

                entity.Property(e => e.TipoInteresId).HasPrecision(10);

                entity.Property(e => e.TipoPrestamoId).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoPeriodo1erPagoNavigation)
                    .WithMany(p => p.NomPrestamosPrestacioneCodigoPeriodo1erPagoNavigations)
                    .HasForeignKey(d => d.CodigoPeriodo1erPago)
                    .HasConstraintName("nomprestamosprestacionesperiodopimerpago_fk");

                entity.HasOne(d => d.CodigoPeriodoUltPagoNavigation)
                    .WithMany(p => p.NomPrestamosPrestacioneCodigoPeriodoUltPagoNavigations)
                    .HasForeignKey(d => d.CodigoPeriodoUltPago)
                    .HasConstraintName("nomprestamosprestacionesperiodoultimopago_fk");

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomPrestamosPrestaciones)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomprestamosprestacionespersona_fk");

                entity.HasOne(d => d.CodigoTipoNominaNavigation)
                    .WithMany(p => p.NomPrestamosPrestaciones)
                    .HasForeignKey(d => d.CodigoTipoNomina)
                    .HasConstraintName("nomprestamosprestacionestiponomina_fk");

                entity.HasOne(d => d.FrecuenciaPago)
                    .WithMany(p => p.NomPrestamosPrestacioneFrecuenciaPagos)
                    .HasForeignKey(d => d.FrecuenciaPagoId)
                    .HasConstraintName("nomprestamosprestacionesfrecuenciapago_fk");

                entity.HasOne(d => d.TipoInteres)
                    .WithMany(p => p.NomPrestamosPrestacioneTipoInteres)
                    .HasForeignKey(d => d.TipoInteresId)
                    .HasConstraintName("nomprestamosprestacionestipointeres_fk");

                entity.HasOne(d => d.TipoPrestamo)
                    .WithMany(p => p.NomPrestamosPrestacioneTipoPrestamos)
                    .HasForeignKey(d => d.TipoPrestamoId)
                    .HasConstraintName("nomprestamosprestacionesprestamoid_fk");
            });

            modelBuilder.Entity<NomPromocione>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.CodigoRelacionCargoNew).HasPrecision(10);

                entity.Property(e => e.CodigoRelacionCargoOld).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.IsuarioCreacion).HasPrecision(10);

                entity.Property(e => e.NumeroOficio).HasMaxLength(20);

                entity.Property(e => e.Observacion).HasMaxLength(500);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomPromociones)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nompromocionespersona_fk");

                entity.HasOne(d => d.CodigoRelacionCargoNewNavigation)
                    .WithMany(p => p.NomPromocioneCodigoRelacionCargoNewNavigations)
                    .HasForeignKey(d => d.CodigoRelacionCargoNew)
                    .HasConstraintName("nompromocionesrelacioncargonew_fk");

                entity.HasOne(d => d.CodigoRelacionCargoOldNavigation)
                    .WithMany(p => p.NomPromocioneCodigoRelacionCargoOldNavigations)
                    .HasForeignKey(d => d.CodigoRelacionCargoOld)
                    .HasConstraintName("nompromocionesrelacioncargoold_fk");
            });

            modelBuilder.Entity<NomRegistroPermiso>(entity =>
            {
                entity.ToTable("NomRegistroPermiso");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Motivo).HasMaxLength(500);

                entity.Property(e => e.Status).HasPrecision(1);

                entity.Property(e => e.TipoPermisoId).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasMaxLength(10);

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(10);

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomRegistroPermisos)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomregistropermisopersona_fk");

                entity.HasOne(d => d.TipoPermiso)
                    .WithMany(p => p.NomRegistroPermisos)
                    .HasForeignKey(d => d.TipoPermisoId)
                    .HasConstraintName("nomregistropermiso_fk");
            });

            modelBuilder.Entity<NomRelacionCargo>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CargoCodigo).HasMaxLength(10);

                entity.Property(e => e.CodigoCargo).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoIcp).HasPrecision(10);

                entity.Property(e => e.CodigoIcpUbicacion).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.CodigoPresupuesto).HasPrecision(10);

                entity.Property(e => e.CodigoTipoNomina).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoCargoNavigation)
                    .WithMany(p => p.NomRelacionCargos)
                    .HasForeignKey(d => d.CodigoCargo)
                    .HasConstraintName("nomrelacioncargoscargo_fk");

                entity.HasOne(d => d.CodigoIcpNavigation)
                    .WithMany(p => p.NomRelacionCargos)
                    .HasForeignKey(d => d.CodigoIcp)
                    .HasConstraintName("nomrelacioncargoscodigoicp_fk");

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomRelacionCargos)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomrelacioncargospersona_fk");

                entity.HasOne(d => d.CodigoPresupuestoNavigation)
                    .WithMany(p => p.NomRelacionCargos)
                    .HasForeignKey(d => d.CodigoPresupuesto)
                    .HasConstraintName("nomrelacioncargospresupuesto_fk");

                entity.HasOne(d => d.CodigoRelacionCargoPreNavigation)
                    .WithMany(p => p.NomRelacionCargos)
                    .HasForeignKey(d => d.CodigoRelacionCargoPre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("nomrelacioncargosrelacioncargo_fk");

                entity.HasOne(d => d.CodigoTipoNominaNavigation)
                    .WithMany(p => p.NomRelacionCargos)
                    .HasForeignKey(d => d.CodigoTipoNomina)
                    .HasConstraintName("nomrelacioncargos_fk");
            });

            modelBuilder.Entity<NomRetencionesAporte>(entity =>
            {
                entity.Property(e => e.Apellido).HasMaxLength(50);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoRetencion).HasMaxLength(5);

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCeacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomRetencionesAportes)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomretencionesaportes_fk");
            });

            modelBuilder.Entity<NomTarifasIislr>(entity =>
            {
                entity.ToTable("NomTarifasIislr");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.NumeroTarifa).HasPrecision(10);

                entity.Property(e => e.SustraendoUt).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);
            });

            modelBuilder.Entity<NomTasasIntere>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.ArticuloId).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.NumeroGacetaOficial).HasMaxLength(20);

                entity.Property(e => e.NumeroTasa).HasMaxLength(20);

                entity.Property(e => e.Tasa).HasPrecision(10, 4);

                entity.Property(e => e.TipoTasaId).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.TipoTasa)
                    .WithMany(p => p.NomTasasInteres)
                    .HasForeignKey(d => d.TipoTasaId)
                    .HasConstraintName("nomtasasinteres_fk");
            });

            modelBuilder.Entity<NomTemporalNomina>(entity =>
            {
                entity.ToTable("NomTemporalNomina");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoConcepto).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPeriodo).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.CodigoTipoNomina).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.ComplementoConcepto).HasMaxLength(100);

                entity.Property(e => e.FrecuenciaId).HasPrecision(10);

                entity.Property(e => e.Status).HasMaxLength(1);

                entity.Property(e => e.Tipo).HasMaxLength(1);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoConceptoNavigation)
                    .WithMany(p => p.NomTemporalNominas)
                    .HasForeignKey(d => d.CodigoConcepto)
                    .HasConstraintName("nomtemporalnominacodigoconcepto_fk");

                entity.HasOne(d => d.CodigoPeriodoNavigation)
                    .WithMany(p => p.NomTemporalNominas)
                    .HasForeignKey(d => d.CodigoPeriodo)
                    .HasConstraintName("nomtemporalnomina_fk");

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomTemporalNominas)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomtemporalnominapersonas_fk");

                entity.HasOne(d => d.CodigoTipoNominaNavigation)
                    .WithMany(p => p.NomTemporalNominas)
                    .HasForeignKey(d => d.CodigoTipoNomina)
                    .HasConstraintName("nomtemporalnominatiponomina_fk");

                entity.HasOne(d => d.Frecuencia)
                    .WithMany(p => p.NomTemporalNominas)
                    .HasForeignKey(d => d.FrecuenciaId)
                    .HasConstraintName("nomtemporalnominafrecuenciaid_fk");
            });

            modelBuilder.Entity<NomTiposNomina>(entity =>
            {
                entity.ToTable("NomTiposNomina");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPresupuestoActual).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.FrecuenciaPagoId).HasPrecision(10);

                entity.Property(e => e.SiglasTipoNomina).HasMaxLength(3);

                entity.Property(e => e.SueldoMinimo).HasColumnName("Sueldo_minimo");

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoPresupuestoActualNavigation)
                    .WithMany(p => p.NomTiposNominas)
                    .HasForeignKey(d => d.CodigoPresupuestoActual)
                    .HasConstraintName("nomtiposnominacodigopresupuestoactual_fk");

                entity.HasOne(d => d.FrecuenciaPago)
                    .WithMany(p => p.NomTiposNominas)
                    .HasForeignKey(d => d.FrecuenciaPagoId)
                    .HasConstraintName("nomtiposnomina_fk");
            });

            modelBuilder.Entity<NomTitulo>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoTitulo).HasMaxLength(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Titulo).HasMaxLength(100);

                entity.Property(e => e.TituloPadreId).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);
            });

            modelBuilder.Entity<NomTmpAcumuladoLoad>(entity =>
            {
                entity.HasKey(e => e.Cedula)
                    .HasName("nomtmpacumuladoload_pk");

                entity.ToTable("NomTmpAcumuladoLoad");

                entity.Property(e => e.Cedula).HasPrecision(10);

                entity.Property(e => e.Nombre).HasMaxLength(100);
            });

            modelBuilder.Entity<NomTmpAguinaldo>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPeriodo).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.CodigoTipoNomina).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Dias).HasPrecision(3);

                entity.Property(e => e.Meses).HasPrecision(2);

                entity.Property(e => e.Status).HasMaxLength(1);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoPeriodoNavigation)
                    .WithMany(p => p.NomTmpAguinaldos)
                    .HasForeignKey(d => d.CodigoPeriodo)
                    .HasConstraintName("nomtmpaguinaldosperiodo_fk");

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomTmpAguinaldos)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomtmpaguinaldospersonas_fk");

                entity.HasOne(d => d.CodigoTipoNominaNavigation)
                    .WithMany(p => p.NomTmpAguinaldos)
                    .HasForeignKey(d => d.CodigoTipoNomina)
                    .HasConstraintName("nomtmpaguinaldostiponomina_fk");
            });

            modelBuilder.Entity<NomTransactionMontoMonedum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CantidadMoneda)
                    .HasPrecision(10)
                    .HasColumnName("cantidad_moneda");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoIcp)
                    .HasPrecision(10)
                    .HasColumnName("codigo_icp");

                entity.Property(e => e.CodigoPersona)
                    .HasPrecision(10)
                    .HasColumnName("codigo_persona");

                entity.Property(e => e.MontoNeto).HasColumnName("monto_neto");

                entity.Property(e => e.ValorMoneda).HasColumnName("valor_moneda");
            });

            modelBuilder.Entity<NomVacacione>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CantidadFrecuenciaPago).HasPrecision(2);

                entity.Property(e => e.CobroAdelantoSueldo).HasMaxLength(1);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPeriodo).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.CodigoTipoNomina).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.DiasHabiles).HasPrecision(5);

                entity.Property(e => e.FrecuenciaPagoId).HasPrecision(10);

                entity.Property(e => e.PeriodoAño).HasMaxLength(10);

                entity.Property(e => e.Status).HasMaxLength(1);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoPeriodoNavigation)
                    .WithMany(p => p.NomVacaciones)
                    .HasForeignKey(d => d.CodigoPeriodo)
                    .HasConstraintName("nomvacacionesperiodo_fk");

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomVacaciones)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomvacacionespersonas_fk");

                entity.HasOne(d => d.CodigoTipoNominaNavigation)
                    .WithMany(p => p.NomVacaciones)
                    .HasForeignKey(d => d.CodigoTipoNomina)
                    .HasConstraintName("nomvacacionestiponomina_fk");

                entity.HasOne(d => d.FrecuenciaPago)
                    .WithMany(p => p.NomVacaciones)
                    .HasForeignKey(d => d.FrecuenciaPagoId)
                    .HasConstraintName("nomvacaciones_fk");
            });

            modelBuilder.Entity<NomVacacionesContrato>(entity =>
            {
                entity.ToTable("NomVacacionesContrato");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.DiasBono).HasPrecision(3);

                entity.Property(e => e.DiasHabiles).HasPrecision(3);

                entity.Property(e => e.NumeroAño).HasPrecision(2);

                entity.Property(e => e.TipoNominaId).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.TipoNomina)
                    .WithMany(p => p.NomVacacionesContratos)
                    .HasForeignKey(d => d.TipoNominaId)
                    .HasConstraintName("nomvacacionescontrato_fk");
            });

            modelBuilder.Entity<NomVacacionesDisfrutada>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CobroAdelantoSueldo).HasPrecision(1);

                entity.Property(e => e.CobroBonoVacacional).HasPrecision(1);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPeriodo).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.DiasHabiles).HasPrecision(1);

                entity.Property(e => e.NumeroOficioIncorporacion).HasMaxLength(20);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoPeriodoNavigation)
                    .WithMany(p => p.NomVacacionesDisfrutada)
                    .HasForeignKey(d => d.CodigoPeriodo)
                    .HasConstraintName("nomvacacionesdisfrutadasperiodo_fk");

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomVacacionesDisfrutada)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomvacacionesdisfrutadaspersona_fk");
            });

            modelBuilder.Entity<NomVacacionesVencida>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.AñoPeriodo).HasPrecision(4);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPersona).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.DiasDisfrutados).HasPrecision(3);

                entity.Property(e => e.DiasVencidos).HasPrecision(3);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoPersonaNavigation)
                    .WithMany(p => p.NomVacacionesVencida)
                    .HasForeignKey(d => d.CodigoPersona)
                    .HasConstraintName("nomvacacionesvencidaspersona_fk");
            });

            modelBuilder.Entity<PreAnteproyecto>(entity =>
            {
                entity.ToTable("PreAnteproyecto");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Año).HasPrecision(4);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoIcp).HasPrecision(10);

                entity.Property(e => e.CodigoPresupuesto).HasPrecision(10);

                entity.Property(e => e.CodigoPuc).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Escenario).HasPrecision(2);

                entity.Property(e => e.Laee).HasColumnName("laee");

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.PreAnteproyectos)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("preanteproyectoempresa_fk");

                entity.HasOne(d => d.CodigoIcpNavigation)
                    .WithMany(p => p.PreAnteproyectos)
                    .HasForeignKey(d => d.CodigoIcp)
                    .HasConstraintName("preanteproyectocodigoicp_fk");

                entity.HasOne(d => d.CodigoPresupuestoNavigation)
                    .WithMany(p => p.PreAnteproyectos)
                    .HasForeignKey(d => d.CodigoPresupuesto)
                    .HasConstraintName("preanteproyectopresupuesto_fk");

                entity.HasOne(d => d.CodigoPucNavigation)
                    .WithMany(p => p.PreAnteproyectos)
                    .HasForeignKey(d => d.CodigoPuc)
                    .HasConstraintName("preanteproyectocodigopuc_fk");
            });

            modelBuilder.Entity<PreAsignacione>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Año).HasPrecision(4);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoIcp).HasPrecision(10);

                entity.Property(e => e.CodigoPresupuesto).HasPrecision(10);

                entity.Property(e => e.CodigoPuc).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Escenario).HasPrecision(2);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.PreAsignaciones)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("preasignacionesempresa_fk");

                entity.HasOne(d => d.CodigoIcpNavigation)
                    .WithMany(p => p.PreAsignaciones)
                    .HasForeignKey(d => d.CodigoIcp)
                    .HasConstraintName("preasignacionescodigoicp_fk");

                entity.HasOne(d => d.CodigoPresupuestoNavigation)
                    .WithMany(p => p.PreAsignaciones)
                    .HasForeignKey(d => d.CodigoPresupuesto)
                    .HasConstraintName("preasignacionespresupuesto_fk");

                entity.HasOne(d => d.CodigoPucNavigation)
                    .WithMany(p => p.PreAsignaciones)
                    .HasForeignKey(d => d.CodigoPuc)
                    .HasConstraintName("preasignacionesplanunicocuenta_fk");
            });

            modelBuilder.Entity<PreCargo>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPresupuesto).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.Denominacion).HasMaxLength(100);

                entity.Property(e => e.Descripcion).HasMaxLength(2000);

                entity.Property(e => e.Grado).HasPrecision(5);

                entity.Property(e => e.TipoCargoId).HasPrecision(10);

                entity.Property(e => e.TipoPersonalId).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.PreCargos)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("precargos_fk");

                entity.HasOne(d => d.TipoCargo)
                    .WithMany(p => p.PreCargoTipoCargos)
                    .HasForeignKey(d => d.TipoCargoId)
                    .HasConstraintName("precargostipocargoid_fk");

                entity.HasOne(d => d.TipoPersonal)
                    .WithMany(p => p.PreCargoTipoPersonals)
                    .HasForeignKey(d => d.TipoPersonalId)
                    .HasConstraintName("precargospersonalid_fk");
            });

            modelBuilder.Entity<PreCompromiso>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Año).HasPrecision(4);

                entity.Property(e => e.CodigoDirEntrega).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPresupuesto).HasPrecision(10);

                entity.Property(e => e.CodigoProveedor).HasPrecision(10);

                entity.Property(e => e.CodigoSolicitud).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Motivo).HasMaxLength(1150);

                entity.Property(e => e.NumeroCompromiso).HasMaxLength(20);

                entity.Property(e => e.NumeroOrden).HasMaxLength(20);

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.TipoPagoId).HasPrecision(10);

                entity.Property(e => e.TipoRenglonId).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.PreCompromisos)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("precompromisos_fk");
            });

            modelBuilder.Entity<PreCostoContCol>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pre_costo_cont_col");

                entity.Property(e => e.CodigoCostoContCol)
                    .HasPrecision(10)
                    .HasColumnName("codigo_costo_cont_col");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoPresupuesto)
                    .HasPrecision(10)
                    .HasColumnName("codigo_presupuesto");

                entity.Property(e => e.Denominacion)
                    .HasMaxLength(2000)
                    .HasColumnName("denominacion");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaFin).HasColumnName("fecha_fin");

                entity.Property(e => e.FechaIni).HasColumnName("fecha_ini");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.NumeroClausula)
                    .HasPrecision(10)
                    .HasColumnName("numero_clausula");

                entity.Property(e => e.TipoNomina)
                    .HasPrecision(10)
                    .HasColumnName("tipo_nomina");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<PreCostoContColPuc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pre_costo_cont_col_puc");

                entity.Property(e => e.BaseCalculo)
                    .HasMaxLength(200)
                    .HasColumnName("base_calculo");

                entity.Property(e => e.CodigoCostoContCol)
                    .HasPrecision(10)
                    .HasColumnName("codigo_costo_cont_col");

                entity.Property(e => e.CodigoCostoContColPuc)
                    .HasPrecision(10)
                    .HasColumnName("codigo_costo_cont_col_puc");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoPresupuesto)
                    .HasPrecision(10)
                    .HasColumnName("codigo_presupuesto");

                entity.Property(e => e.CodigoPuc)
                    .HasPrecision(10)
                    .HasColumnName("codigo_puc");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.Monto).HasColumnName("monto");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<PreDescriptiva>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Codigo).HasMaxLength(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.DescripcionPadreId).HasPrecision(10);

                entity.Property(e => e.PreTituloId).HasPrecision(10);

                entity.Property(e => e.UsuarioActuualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.PreDescriptivas)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("predescriptivasempresa_fk");

                entity.HasOne(d => d.PreTitulo)
                    .WithMany(p => p.PreDescriptivas)
                    .HasForeignKey(d => d.PreTituloId)
                    .HasConstraintName("predescriptivas_fk");
            });

            modelBuilder.Entity<PreDetalleCompromiso>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pre_detalle_compromisos");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.CantidadAnulada).HasColumnName("cantidad_anulada");

                entity.Property(e => e.CodigoCompromiso)
                    .HasPrecision(10)
                    .HasColumnName("codigo_compromiso");

                entity.Property(e => e.CodigoDetalleCompromiso)
                    .HasPrecision(10)
                    .HasColumnName("codigo_detalle_compromiso");

                entity.Property(e => e.CodigoDetalleSolicitud)
                    .HasPrecision(10)
                    .HasColumnName("codigo_detalle_solicitud");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoPresupuesto)
                    .HasPrecision(10)
                    .HasColumnName("codigo_presupuesto");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(2000)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.MontoDescuento).HasColumnName("monto_descuento");

                entity.Property(e => e.MontoImpuesto).HasColumnName("monto_impuesto");

                entity.Property(e => e.PorDescuento).HasColumnName("por_descuento");

                entity.Property(e => e.PorImpuesto).HasColumnName("por_impuesto");

                entity.Property(e => e.PrecioUnitario).HasColumnName("precio_unitario");

                entity.Property(e => e.TipoImpuestoId)
                    .HasPrecision(10)
                    .HasColumnName("tipo_impuesto_id");

                entity.Property(e => e.UdmId)
                    .HasPrecision(10)
                    .HasColumnName("udm_id");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<PreDirectivo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pre_directivos");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(100)
                    .HasColumnName("apellido");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(100)
                    .HasColumnName("cargo");

                entity.Property(e => e.Cedula)
                    .HasPrecision(10)
                    .HasColumnName("cedula");

                entity.Property(e => e.CodigoDirectivo)
                    .HasPrecision(10)
                    .HasColumnName("codigo_directivo");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoIdentificacion)
                    .HasPrecision(10)
                    .HasColumnName("codigo_identificacion");

                entity.Property(e => e.CodigoPresupuesto)
                    .HasPrecision(10)
                    .HasColumnName("codigo_presupuesto");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");

                entity.Property(e => e.TipoDirectivoId)
                    .HasPrecision(10)
                    .HasColumnName("tipo_directivo_id");

                entity.Property(e => e.TituloId)
                    .HasPrecision(10)
                    .HasColumnName("titulo_id");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<PreEjecucionPresupuestarium>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pre_ejecucion_presupuestaria");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoGrupo)
                    .HasMaxLength(1)
                    .HasColumnName("codigo_grupo");

                entity.Property(e => e.CodigoNivel1)
                    .HasMaxLength(2)
                    .HasColumnName("codigo_nivel1")
                    .IsFixedLength();

                entity.Property(e => e.CodigoNivel2)
                    .HasMaxLength(2)
                    .HasColumnName("codigo_nivel2")
                    .IsFixedLength();

                entity.Property(e => e.CodigoNivel3)
                    .HasMaxLength(2)
                    .HasColumnName("codigo_nivel3")
                    .IsFixedLength();

                entity.Property(e => e.CodigoNivel4)
                    .HasMaxLength(2)
                    .HasColumnName("codigo_nivel4")
                    .IsFixedLength();

                entity.Property(e => e.CodigoPresupuesto)
                    .HasPrecision(10)
                    .HasColumnName("codigo_presupuesto");

                entity.Property(e => e.IProyectado).HasColumnName("i_proyectado");

                entity.Property(e => e.IReal).HasColumnName("i_real");

                entity.Property(e => e.IiProyectado).HasColumnName("ii_proyectado");

                entity.Property(e => e.IiReal).HasColumnName("ii_real");

                entity.Property(e => e.IiiProyectado).HasColumnName("iii_proyectado");

                entity.Property(e => e.IiiReal).HasColumnName("iii_real");

                entity.Property(e => e.IvProyectado).HasColumnName("iv_proyectado");

                entity.Property(e => e.IvReal).HasColumnName("iv_real");
            });

            modelBuilder.Entity<PreEquipo>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Año).HasPrecision(4);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoIcp).HasPrecision(10);

                entity.Property(e => e.CodigoPresupuesto).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Denominacion).HasMaxLength(1000);

                entity.Property(e => e.Escenario).HasPrecision(2);

                entity.Property(e => e.Principal).HasPrecision(1);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.PreEquipos)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("preequiposempresa_fk");

                entity.HasOne(d => d.CodigoIcpNavigation)
                    .WithMany(p => p.PreEquipos)
                    .HasForeignKey(d => d.CodigoIcp)
                    .HasConstraintName("preequiposcodigoicp_fk");

                entity.HasOne(d => d.CodigoPresupuestoNavigation)
                    .WithMany(p => p.PreEquipos)
                    .HasForeignKey(d => d.CodigoPresupuesto)
                    .HasConstraintName("preequipospresupuesto_fk");
            });

            modelBuilder.Entity<PreEscala>(entity =>
            {
                entity.ToTable("PreEscala");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Año).HasPrecision(4);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoGrupo).HasMaxLength(10);

                entity.Property(e => e.CodigoPresupuesto).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.Escenario).HasPrecision(2);

                entity.Property(e => e.NumeroEscala).HasMaxLength(5);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.PreEscalas)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("preescalaempresa_fk");

                entity.HasOne(d => d.CodigoPresupuestoNavigation)
                    .WithMany(p => p.PreEscalas)
                    .HasForeignKey(d => d.CodigoPresupuesto)
                    .HasConstraintName("preescala_fk");
            });

            modelBuilder.Entity<PreIdentificacione>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Ciudad).HasMaxLength(100);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPostal).HasMaxLength(10);

                entity.Property(e => e.CodigoPresupuesto).HasPrecision(10);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Complemnto1).HasMaxLength(100);

                entity.Property(e => e.DenominacionOmp).HasMaxLength(100);

                entity.Property(e => e.DenominacionOnp).HasMaxLength(100);

                entity.Property(e => e.DomicilioLegal).HasMaxLength(1000);

                entity.Property(e => e.Email1).HasMaxLength(100);

                entity.Property(e => e.Email2).HasMaxLength(100);

                entity.Property(e => e.Email3).HasMaxLength(100);

                entity.Property(e => e.Estado).HasMaxLength(100);

                entity.Property(e => e.Fax1).HasMaxLength(20);

                entity.Property(e => e.Fax2).HasMaxLength(20);

                entity.Property(e => e.Fax3).HasMaxLength(20);

                entity.Property(e => e.Municipio).HasMaxLength(100);

                entity.Property(e => e.Pais).HasMaxLength(100);

                entity.Property(e => e.Telefono1).HasMaxLength(20);

                entity.Property(e => e.Telefono2).HasMaxLength(20);

                entity.Property(e => e.Telefono3).HasMaxLength(20);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.PreIdentificaciones)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("preidentificacionesempresa_fk");

                entity.HasOne(d => d.CodigoPresupuestoNavigation)
                    .WithMany(p => p.PreIdentificaciones)
                    .HasForeignKey(d => d.CodigoPresupuesto)
                    .HasConstraintName("preidentificaciones_fk");
            });

            modelBuilder.Entity<PreIndiceCatPrg>(entity =>
            {
                entity.ToTable("PreIndiceCatPrg");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Año).HasPrecision(4);

                entity.Property(e => e.CodigoActividad)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoFuncionario).HasPrecision(10);

                entity.Property(e => e.CodigoOficina)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.CodigoPresupuesto).HasPrecision(10);

                entity.Property(e => e.CodigoPrograma)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.CodigoProyecto)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.CodigoSector)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.CodigoSubprograma)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Denominacion).HasMaxLength(200);

                entity.Property(e => e.Descripcion).HasMaxLength(4000);

                entity.Property(e => e.Escenario).HasPrecision(2);

                entity.Property(e => e.UnidadEjecutora).HasMaxLength(200);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.PreIndiceCatPrgs)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("preindicecatprg_fk");

                entity.HasOne(d => d.CodigoPresupuestoNavigation)
                    .WithMany(p => p.PreIndiceCatPrgs)
                    .HasForeignKey(d => d.CodigoPresupuesto)
                    .HasConstraintName("preindicecatprgcodigopresupuesto_fk");
            });

            modelBuilder.Entity<PreIngreso>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Año).HasPrecision(4);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPresupuesto).HasPrecision(10);

                entity.Property(e => e.CodigoPuc).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Escenario).HasPrecision(2);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.PreIngresos)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("preingresosempresa_fk");

                entity.HasOne(d => d.CodigoPresupuestoNavigation)
                    .WithMany(p => p.PreIngresos)
                    .HasForeignKey(d => d.CodigoPresupuesto)
                    .HasConstraintName("preingresospresupuesto_fk");

                entity.HasOne(d => d.CodigoPucNavigation)
                    .WithMany(p => p.PreIngresos)
                    .HasForeignKey(d => d.CodigoPuc)
                    .HasConstraintName("preingresoscodigopuc_fk");
            });

            modelBuilder.Entity<PreIngresosTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pre_ingresos_tmp");

                entity.Property(e => e.Ano)
                    .HasPrecision(4)
                    .HasColumnName("ano");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoIngreso)
                    .HasPrecision(10)
                    .HasColumnName("codigo_ingreso");

                entity.Property(e => e.CodigoPresupuesto)
                    .HasPrecision(10)
                    .HasColumnName("codigo_presupuesto");

                entity.Property(e => e.CodigoPuc)
                    .HasPrecision(10)
                    .HasColumnName("codigo_puc");

                entity.Property(e => e.Escenario)
                    .HasPrecision(2)
                    .HasColumnName("escenario");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.Monto).HasColumnName("monto");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<PreMeta>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CantidadCuartoTrimestre).HasPrecision(10);

                entity.Property(e => e.CantidadMeta).HasPrecision(10);

                entity.Property(e => e.CantidadPrimerTrimestre).HasPrecision(10);

                entity.Property(e => e.CantidadSegundoTrimestre).HasPrecision(10);

                entity.Property(e => e.CantidadTercerTrimestre).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPresupuesto).HasPrecision(10);

                entity.Property(e => e.CodigoProyecto).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.CostoMeta).HasPrecision(20, 2);

                entity.Property(e => e.DenominacionMeta).HasMaxLength(300);

                entity.Property(e => e.NumeroMeta).HasPrecision(5, 2);

                entity.Property(e => e.UnidadMedidaId).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.PreMeta)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("premetasempresas_fk");

                entity.HasOne(d => d.CodigoPresupuestoNavigation)
                    .WithMany(p => p.PreMeta)
                    .HasForeignKey(d => d.CodigoPresupuesto)
                    .HasConstraintName("premetascodigopresupuesto_fk");

                entity.HasOne(d => d.CodigoProyectoNavigation)
                    .WithMany(p => p.PreMeta)
                    .HasForeignKey(d => d.CodigoProyecto)
                    .HasConstraintName("premetasproyecto_fk");
            });

            modelBuilder.Entity<PreModificacion>(entity =>
            {
                entity.ToTable("PreModificacion");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Año).HasPrecision(4);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoOficio).HasMaxLength(100);

                entity.Property(e => e.CodigoPresupuesto).HasPrecision(10);

                entity.Property(e => e.CodigoSolModificacion).HasPrecision(10);

                entity.Property(e => e.CodigoSolicitante).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Motivo).HasMaxLength(1000);

                entity.Property(e => e.NroResAct).HasMaxLength(30);

                entity.Property(e => e.NumeroModificacion).HasMaxLength(20);

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.TipoModificacionId).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.PreModificacions)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("premodificacionempresa_fk");

                entity.HasOne(d => d.CodigoPresupuestoNavigation)
                    .WithMany(p => p.PreModificacions)
                    .HasForeignKey(d => d.CodigoPresupuesto)
                    .HasConstraintName("premodificacionpresupuesto_fk");

                entity.HasOne(d => d.CodigoSolModificacionNavigation)
                    .WithMany(p => p.PreModificacions)
                    .HasForeignKey(d => d.CodigoSolModificacion)
                    .HasConstraintName("premodificacioncodigosolicitudmodificacion_fk");

                entity.HasOne(d => d.TipoModificacion)
                    .WithMany(p => p.PreModificacions)
                    .HasForeignKey(d => d.TipoModificacionId)
                    .HasConstraintName("premodificaciontipomodificacion_fk");
            });

            modelBuilder.Entity<PreNivelesPuc>(entity =>
            {
                entity.ToTable("PreNivelesPuc");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Nivel1).HasMaxLength(20);

                entity.Property(e => e.Nivel2).HasMaxLength(20);

                entity.Property(e => e.Nivel3).HasMaxLength(20);

                entity.Property(e => e.Nivel4).HasMaxLength(20);

                entity.Property(e => e.Nivel5).HasMaxLength(20);

                entity.Property(e => e.Nivel6).HasMaxLength(20);

                entity.Property(e => e.UsuarioActulizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.PreNivelesPucs)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("prenivelespucempresa_fk");
            });

            modelBuilder.Entity<PreObjetivo>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoIcp).HasPrecision(10);

                entity.Property(e => e.CodigoPresupuesto).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.DenominacionObjetivo).HasMaxLength(1000);

                entity.Property(e => e.NumeroObjetivo).HasPrecision(5, 2);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.PreObjetivos)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("preobjetivosempresa_fk");

                entity.HasOne(d => d.CodigoIcpNavigation)
                    .WithMany(p => p.PreObjetivos)
                    .HasForeignKey(d => d.CodigoIcp)
                    .HasConstraintName("preobjetivoscodigoicp_fk");

                entity.HasOne(d => d.CodigoPresupuestoNavigation)
                    .WithMany(p => p.PreObjetivos)
                    .HasForeignKey(d => d.CodigoPresupuesto)
                    .HasConstraintName("preobjetivospresupuesto_fk");
            });

            modelBuilder.Entity<PreOefp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pre_oefp");

                entity.Property(e => e.Ano)
                    .HasPrecision(4)
                    .HasColumnName("ano");

                entity.Property(e => e.CodigoEspecifica)
                    .HasMaxLength(2)
                    .HasColumnName("codigo_especifica")
                    .IsFixedLength();

                entity.Property(e => e.CodigoGenerica)
                    .HasMaxLength(2)
                    .HasColumnName("codigo_generica")
                    .IsFixedLength();

                entity.Property(e => e.CodigoGrupo)
                    .HasMaxLength(1)
                    .HasColumnName("codigo_grupo");

                entity.Property(e => e.CodigoPartida)
                    .HasMaxLength(2)
                    .HasColumnName("codigo_partida")
                    .IsFixedLength();

                entity.Property(e => e.CodigoSubespecifica)
                    .HasMaxLength(2)
                    .HasColumnName("codigo_subespecifica")
                    .IsFixedLength();

                entity.Property(e => e.Denominacion)
                    .HasMaxLength(200)
                    .HasColumnName("denominacion");

                entity.Property(e => e.IProyectado).HasColumnName("i_proyectado");

                entity.Property(e => e.IReal).HasColumnName("i_real");

                entity.Property(e => e.IiProyectado).HasColumnName("ii_proyectado");

                entity.Property(e => e.IiReal).HasColumnName("ii_real");

                entity.Property(e => e.IiiProyectado).HasColumnName("iii_proyectado");

                entity.Property(e => e.IiiReal).HasColumnName("iii_real");

                entity.Property(e => e.IvProyectado).HasColumnName("iv_proyectado");

                entity.Property(e => e.IvReal).HasColumnName("iv_real");
            });

            modelBuilder.Entity<PreOrganismo>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Actividad).HasMaxLength(200);

                entity.Property(e => e.Año).HasPrecision(4);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPresupuesto).HasPrecision(10);

                entity.Property(e => e.Complemeto1).HasMaxLength(100);

                entity.Property(e => e.Complemeto2).HasMaxLength(100);

                entity.Property(e => e.Complemeto3).HasMaxLength(100);

                entity.Property(e => e.Denominacion).HasMaxLength(300);

                entity.Property(e => e.NumeroRegistro).HasMaxLength(100);

                entity.Property(e => e.TipoOrganismoId).HasPrecision(10);

                entity.Property(e => e.UbicacionGeografica).HasMaxLength(500);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.PreOrganismos)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("preorganismosempresa_fk");

                entity.HasOne(d => d.CodigoPresupuestoNavigation)
                    .WithMany(p => p.PreOrganismos)
                    .HasForeignKey(d => d.CodigoPresupuesto)
                    .HasConstraintName("preorganismospresupuesto_fk");

                entity.HasOne(d => d.TipoOrganismo)
                    .WithMany(p => p.PreOrganismos)
                    .HasForeignKey(d => d.TipoOrganismoId)
                    .HasConstraintName("preorganismostipoorganismo_fk");
            });

            modelBuilder.Entity<PreParticipaFinancieraOrg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pre_participa_financiera_org");

                entity.Property(e => e.Ano)
                    .HasPrecision(4)
                    .HasColumnName("ano");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoIcp)
                    .HasPrecision(10)
                    .HasColumnName("codigo_icp");

                entity.Property(e => e.CodigoOrganismo)
                    .HasPrecision(10)
                    .HasColumnName("codigo_organismo");

                entity.Property(e => e.CodigoParticipaFinancOrg)
                    .HasPrecision(10)
                    .HasColumnName("codigo_participa_financ_org");

                entity.Property(e => e.CodigoPresupuesto)
                    .HasPrecision(10)
                    .HasColumnName("codigo_presupuesto");

                entity.Property(e => e.CodigoPuc)
                    .HasPrecision(10)
                    .HasColumnName("codigo_puc");

                entity.Property(e => e.CuotaParticipacion).HasColumnName("cuota_participacion");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(1000)
                    .HasColumnName("observaciones");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<PrePlanUnicoCuenta>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoGrupo).HasMaxLength(1);

                entity.Property(e => e.CodigoNivel1)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.CodigoNivel2)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.CodigoNivel3)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.CodigoNivel4)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.CodigoNivel5)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.CodigoNivel6)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.CodigoPresupuesto).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Denominacion).HasMaxLength(200);

                entity.Property(e => e.Descripcion).HasMaxLength(2500);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.PrePlanUnicoCuenta)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("preplanunicocuentasempresa_fk");
            });

            modelBuilder.Entity<PrePorcGastosMensuale>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pre_porc_gastos_mensuales");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoIcp)
                    .HasPrecision(10)
                    .HasColumnName("codigo_icp");

                entity.Property(e => e.CodigoPorGastosMes)
                    .HasPrecision(10)
                    .HasColumnName("codigo_por_gastos_mes");

                entity.Property(e => e.CodigoPuc)
                    .HasPrecision(10)
                    .HasColumnName("codigo_puc");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.MesInicial)
                    .HasPrecision(10)
                    .HasColumnName("mes_inicial");

                entity.Property(e => e.Por10Mes)
                    .HasPrecision(10)
                    .HasColumnName("por_10_mes");

                entity.Property(e => e.Por11Mes)
                    .HasPrecision(10)
                    .HasColumnName("por_11_mes");

                entity.Property(e => e.Por12Mes)
                    .HasPrecision(10)
                    .HasColumnName("por_12_mes");

                entity.Property(e => e.Por1Mes)
                    .HasPrecision(10)
                    .HasColumnName("por_1_mes");

                entity.Property(e => e.Por2Mes)
                    .HasPrecision(10)
                    .HasColumnName("por_2_mes");

                entity.Property(e => e.Por3Mes)
                    .HasPrecision(10)
                    .HasColumnName("por_3_mes");

                entity.Property(e => e.Por4Mes)
                    .HasPrecision(10)
                    .HasColumnName("por_4_mes");

                entity.Property(e => e.Por5Mes)
                    .HasPrecision(10)
                    .HasColumnName("por_5_mes");

                entity.Property(e => e.Por6Mes)
                    .HasPrecision(10)
                    .HasColumnName("por_6_mes");

                entity.Property(e => e.Por7Mes)
                    .HasPrecision(10)
                    .HasColumnName("por_7_mes");

                entity.Property(e => e.Por8Mes)
                    .HasPrecision(10)
                    .HasColumnName("por_8_mes");

                entity.Property(e => e.Por9Mes)
                    .HasPrecision(10)
                    .HasColumnName("por_9_mes");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<PrePresupuesto>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Año).HasPrecision(4);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.Denominacion).HasMaxLength(100);

                entity.Property(e => e.Descripcion).HasMaxLength(1000);

                entity.Property(e => e.NumeroOrdenanza).HasMaxLength(20);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.PrePresupuestos)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("prepresupuestosempresa_fk");
            });

            modelBuilder.Entity<PreProgramasSociale>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pre_programas_sociales");

                entity.Property(e => e.Ano)
                    .HasPrecision(4)
                    .HasColumnName("ano");

                entity.Property(e => e.AsignacionAnual)
                    .HasPrecision(15)
                    .HasColumnName("asignacion_anual");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoIcp)
                    .HasPrecision(10)
                    .HasColumnName("codigo_icp");

                entity.Property(e => e.CodigoPresupuesto)
                    .HasPrecision(10)
                    .HasColumnName("codigo_presupuesto");

                entity.Property(e => e.CodigoPrgSocial)
                    .HasPrecision(10)
                    .HasColumnName("codigo_prg_social");

                entity.Property(e => e.Denominacion)
                    .HasMaxLength(300)
                    .HasColumnName("denominacion");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.OrganismoId)
                    .HasPrecision(10)
                    .HasColumnName("organismo_id");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<PreProyecto>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoIcp).HasPrecision(10);

                entity.Property(e => e.CodigoPresupuesto).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.DenominacionProyecto).HasMaxLength(1000);

                entity.Property(e => e.NumeroProyecto).HasPrecision(5, 2);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.PreProyectos)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("preproyectosempresa_fk");

                entity.HasOne(d => d.CodigoIcpNavigation)
                    .WithMany(p => p.PreProyectos)
                    .HasForeignKey(d => d.CodigoIcp)
                    .HasConstraintName("preproyectoscodigoicp_fk");

                entity.HasOne(d => d.CodigoPresupuestoNavigation)
                    .WithMany(p => p.PreProyectos)
                    .HasForeignKey(d => d.CodigoPresupuesto)
                    .HasConstraintName("preproyectospresupuesto_fk");
            });

            modelBuilder.Entity<PreProyectosInversion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pre_proyectos_inversion");

                entity.Property(e => e.Ano)
                    .HasPrecision(4)
                    .HasColumnName("ano");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoFuncionario)
                    .HasPrecision(10)
                    .HasColumnName("codigo_funcionario");

                entity.Property(e => e.CodigoIcp)
                    .HasPrecision(10)
                    .HasColumnName("codigo_icp");

                entity.Property(e => e.CodigoObra)
                    .HasMaxLength(20)
                    .HasColumnName("codigo_obra");

                entity.Property(e => e.CodigoPresupuesto)
                    .HasPrecision(10)
                    .HasColumnName("codigo_presupuesto");

                entity.Property(e => e.CodigoProyectoInv)
                    .HasPrecision(10)
                    .HasColumnName("codigo_proyecto_inv");

                entity.Property(e => e.CompromisoAnterior).HasColumnName("compromiso_anterior");

                entity.Property(e => e.CompromisoVigente).HasColumnName("compromiso_vigente");

                entity.Property(e => e.Costo).HasColumnName("costo");

                entity.Property(e => e.Denominacion)
                    .HasMaxLength(1000)
                    .HasColumnName("denominacion");

                entity.Property(e => e.EjecutadoAnterior).HasColumnName("ejecutado_anterior");

                entity.Property(e => e.EjecutadoVigente).HasColumnName("ejecutado_vigente");

                entity.Property(e => e.Escenario)
                    .HasPrecision(2)
                    .HasColumnName("escenario");

                entity.Property(e => e.EstimadaPosterior).HasColumnName("estimada_posterior");

                entity.Property(e => e.EstimadaPresupuesto).HasColumnName("estimada_presupuesto");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaFin).HasColumnName("fecha_fin");

                entity.Property(e => e.FechaIni).HasColumnName("fecha_ini");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.FinanciadoId)
                    .HasPrecision(10)
                    .HasColumnName("financiado_id");

                entity.Property(e => e.Funcionario)
                    .HasMaxLength(100)
                    .HasColumnName("funcionario");

                entity.Property(e => e.SituacionId)
                    .HasPrecision(10)
                    .HasColumnName("situacion_id");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<PrePucCompromiso>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pre_puc_compromisos");

                entity.Property(e => e.CodigoDetalleCompromiso)
                    .HasPrecision(10)
                    .HasColumnName("codigo_detalle_compromiso");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoFinanciado)
                    .HasPrecision(10)
                    .HasColumnName("codigo_financiado");

                entity.Property(e => e.CodigoIcp)
                    .HasPrecision(10)
                    .HasColumnName("codigo_icp");

                entity.Property(e => e.CodigoPresupuesto)
                    .HasPrecision(10)
                    .HasColumnName("codigo_presupuesto");

                entity.Property(e => e.CodigoPuc)
                    .HasPrecision(10)
                    .HasColumnName("codigo_puc");

                entity.Property(e => e.CodigoPucCompromiso)
                    .HasPrecision(10)
                    .HasColumnName("codigo_puc_compromiso");

                entity.Property(e => e.CodigoPucSolicitud)
                    .HasPrecision(10)
                    .HasColumnName("codigo_puc_solicitud");

                entity.Property(e => e.CodigoSaldo)
                    .HasPrecision(10)
                    .HasColumnName("codigo_saldo");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.FinanciadoId)
                    .HasPrecision(10)
                    .HasColumnName("financiado_id");

                entity.Property(e => e.Monto).HasColumnName("monto");

                entity.Property(e => e.MontoAnulado).HasColumnName("monto_anulado");

                entity.Property(e => e.MontoCausado).HasColumnName("monto_causado");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<PrePucModificacion>(entity =>
            {
                entity.ToTable("PrePucModificacion");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoIcp).HasPrecision(10);

                entity.Property(e => e.CodigoModificacion).HasPrecision(10);

                entity.Property(e => e.CodigoPresupuesto).HasPrecision(10);

                entity.Property(e => e.CodigoPuc).HasPrecision(10);

                entity.Property(e => e.CodigoPucSolModificacion).HasPrecision(10);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.DePara).HasMaxLength(2);

                entity.Property(e => e.FinanciadoId).HasMaxLength(100);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.PrePucModificacions)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("prepucmodificacionempresa_fk");

                entity.HasOne(d => d.CodigoIcpNavigation)
                    .WithMany(p => p.PrePucModificacions)
                    .HasForeignKey(d => d.CodigoIcp)
                    .HasConstraintName("prepucmodificacioncodigoicp_fk");

                entity.HasOne(d => d.CodigoModificacionNavigation)
                    .WithMany(p => p.PrePucModificacions)
                    .HasForeignKey(d => d.CodigoModificacion)
                    .HasConstraintName("prepucmodificacioncodigomodificacion_fk");

                entity.HasOne(d => d.CodigoPresupuestoNavigation)
                    .WithMany(p => p.PrePucModificacions)
                    .HasForeignKey(d => d.CodigoPresupuesto)
                    .HasConstraintName("prepucmodificacioncodigopresupuesto_fk");

                entity.HasOne(d => d.CodigoPucNavigation)
                    .WithMany(p => p.PrePucModificacions)
                    .HasForeignKey(d => d.CodigoPuc)
                    .HasConstraintName("prepucmodificacioncodigopuc_fk");

                entity.HasOne(d => d.CodigoPucSolModificacionNavigation)
                    .WithMany(p => p.PrePucModificacions)
                    .HasForeignKey(d => d.CodigoPucSolModificacion)
                    .HasConstraintName("prepucmodificacionpucsolicitudmodificacion_fk");
            });

            modelBuilder.Entity<PrePucSolModificacion>(entity =>
            {
                entity.ToTable("PrePucSolModificacion");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoIcp).HasPrecision(10);

                entity.Property(e => e.CodigoPresupuesto).HasPrecision(10);

                entity.Property(e => e.CodigoPuc).HasPrecision(10);

                entity.Property(e => e.CodigoSolModificacion).HasPrecision(10);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.DePara).HasMaxLength(2);

                entity.Property(e => e.FinanciadoId).HasMaxLength(100);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.PrePucSolModificacions)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("prepucsolmodificacionempresa_fk");

                entity.HasOne(d => d.CodigoIcpNavigation)
                    .WithMany(p => p.PrePucSolModificacions)
                    .HasForeignKey(d => d.CodigoIcp)
                    .HasConstraintName("prepucsolmodificacioncodigoicp_fk");

                entity.HasOne(d => d.CodigoPresupuestoNavigation)
                    .WithMany(p => p.PrePucSolModificacions)
                    .HasForeignKey(d => d.CodigoPresupuesto)
                    .HasConstraintName("prepucsolmodificacioncodigopresupuesto_fk");

                entity.HasOne(d => d.CodigoPucNavigation)
                    .WithMany(p => p.PrePucSolModificacions)
                    .HasForeignKey(d => d.CodigoPuc)
                    .HasConstraintName("prepucsolmodificacioncodigopuc_fk");

                entity.HasOne(d => d.CodigoSolModificacionNavigation)
                    .WithMany(p => p.PrePucSolModificacions)
                    .HasForeignKey(d => d.CodigoSolModificacion)
                    .HasConstraintName("prepucsolmodificacionsolicitudmodificacion_fk");
            });

            modelBuilder.Entity<PreRelacionCargo>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Año).HasPrecision(4);

                entity.Property(e => e.Cantidad).HasPrecision(10);

                entity.Property(e => e.CodigoCargo).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoIcp).HasPrecision(10);

                entity.Property(e => e.CodigoPresupuesto).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Escenario).HasPrecision(2);

                entity.Property(e => e.FechaActualizacion).HasColumnName("Fecha_Actualizacion");

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoCargoNavigation)
                    .WithMany(p => p.PreRelacionCargos)
                    .HasForeignKey(d => d.CodigoCargo)
                    .HasConstraintName("prerelacioncargoscodigocargo_fk");

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.PreRelacionCargos)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("prerelacioncargosempresa_fk");

                entity.HasOne(d => d.CodigoPresupuestoNavigation)
                    .WithMany(p => p.PreRelacionCargos)
                    .HasForeignKey(d => d.CodigoPresupuesto)
                    .HasConstraintName("prerelacioncargoscodigopresupuesto_fk");
            });

            modelBuilder.Entity<PreSaldo>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Año).HasPrecision(4);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoFinanciado).HasPrecision(10);

                entity.Property(e => e.CodigoIcp).HasPrecision(10);

                entity.Property(e => e.CodigoPresupuesto).HasPrecision(10);

                entity.Property(e => e.CodigoPuc).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemeto2).HasMaxLength(100);

                entity.Property(e => e.Complemeto3).HasMaxLength(100);

                entity.Property(e => e.FinanciadoId).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.PreSaldos)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("presaldosempresa_fk");

                entity.HasOne(d => d.CodigoIcpNavigation)
                    .WithMany(p => p.PreSaldos)
                    .HasForeignKey(d => d.CodigoIcp)
                    .HasConstraintName("presaldoscodigoicp_fk");

                entity.HasOne(d => d.CodigoPucNavigation)
                    .WithMany(p => p.PreSaldos)
                    .HasForeignKey(d => d.CodigoPuc)
                    .HasConstraintName("presaldosplanunicocuenta_fk");

                entity.HasOne(d => d.Financiado)
                    .WithMany(p => p.PreSaldos)
                    .HasForeignKey(d => d.FinanciadoId)
                    .HasConstraintName("presaldosfinanciadoid_fk");

                entity.HasOne(d => d.PresupuestadoNavigation)
                    .WithMany(p => p.PreSaldos)
                    .HasForeignKey(d => d.Presupuestado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("presaldoscodigopresupuesto_fk");
            });

            modelBuilder.Entity<PreSaldosCtrl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pre_saldos_ctrl");

                entity.Property(e => e.Ajustado).HasColumnName("ajustado");

                entity.Property(e => e.Ano)
                    .HasPrecision(4)
                    .HasColumnName("ano");

                entity.Property(e => e.Asignacion).HasColumnName("asignacion");

                entity.Property(e => e.Bloqueado).HasColumnName("bloqueado");

                entity.Property(e => e.Causado).HasColumnName("causado");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoFinanciado)
                    .HasPrecision(10)
                    .HasColumnName("codigo_financiado");

                entity.Property(e => e.CodigoIcp)
                    .HasPrecision(10)
                    .HasColumnName("codigo_icp");

                entity.Property(e => e.CodigoPresupuesto)
                    .HasPrecision(10)
                    .HasColumnName("codigo_presupuesto");

                entity.Property(e => e.CodigoPuc)
                    .HasPrecision(10)
                    .HasColumnName("codigo_puc");

                entity.Property(e => e.CodigoSaldo)
                    .HasPrecision(10)
                    .HasColumnName("codigo_saldo");

                entity.Property(e => e.CodigoSaldoCtrl)
                    .HasPrecision(10)
                    .HasColumnName("codigo_saldo_ctrl");

                entity.Property(e => e.Comprometido).HasColumnName("comprometido");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.FinanciadoId)
                    .HasPrecision(10)
                    .HasColumnName("financiado_id");

                entity.Property(e => e.Modificado).HasColumnName("modificado");

                entity.Property(e => e.Pagado).HasColumnName("pagado");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<PreSaldosDetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pre_saldos_detalle");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoPresupuesto)
                    .HasPrecision(10)
                    .HasColumnName("codigo_presupuesto");

                entity.Property(e => e.CodigoSaldo)
                    .HasPrecision(10)
                    .HasColumnName("codigo_saldo");

                entity.Property(e => e.CodigoSaldoDetalle)
                    .HasPrecision(10)
                    .HasColumnName("codigo_saldo_detalle");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaAsignacion).HasColumnName("fecha_asignacion");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.Monto).HasColumnName("monto");

                entity.Property(e => e.PorcentajeAsignacion).HasColumnName("porcentaje_asignacion");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<PreSaldosDiario>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pre_saldos_diarios");

                entity.Property(e => e.Ajustado).HasColumnName("ajustado");

                entity.Property(e => e.Asignacion).HasColumnName("asignacion");

                entity.Property(e => e.Bloqueado).HasColumnName("bloqueado");

                entity.Property(e => e.Causado).HasColumnName("causado");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoPresupuesto)
                    .HasPrecision(10)
                    .HasColumnName("codigo_presupuesto");

                entity.Property(e => e.CodigoSaldo)
                    .HasPrecision(10)
                    .HasColumnName("codigo_saldo");

                entity.Property(e => e.CodigoSaldoDiario)
                    .HasPrecision(10)
                    .HasColumnName("codigo_saldo_diario");

                entity.Property(e => e.Comprometido).HasColumnName("comprometido");

                entity.Property(e => e.Extra1).HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaSaldo).HasColumnName("fecha_saldo");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.Modificado).HasColumnName("modificado");

                entity.Property(e => e.Pagado).HasColumnName("pagado");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<PreSaldosDiariosTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pre_saldos_diarios_tmp");

                entity.Property(e => e.Ajustado).HasColumnName("ajustado");

                entity.Property(e => e.Asignacion).HasColumnName("asignacion");

                entity.Property(e => e.Bloqueado).HasColumnName("bloqueado");

                entity.Property(e => e.Causado).HasColumnName("causado");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoPresupuesto)
                    .HasPrecision(10)
                    .HasColumnName("codigo_presupuesto");

                entity.Property(e => e.CodigoSaldo)
                    .HasPrecision(10)
                    .HasColumnName("codigo_saldo");

                entity.Property(e => e.CodigoSaldoDiario)
                    .HasPrecision(10)
                    .HasColumnName("codigo_saldo_diario");

                entity.Property(e => e.Comprometido).HasColumnName("comprometido");

                entity.Property(e => e.Extra1).HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaSaldo).HasColumnName("fecha_saldo");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.Modificado).HasColumnName("modificado");

                entity.Property(e => e.Pagado).HasColumnName("pagado");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<PreSaldosIngreso>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pre_saldos_ingresos");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoPresupuesto)
                    .HasPrecision(10)
                    .HasColumnName("codigo_presupuesto");

                entity.Property(e => e.CodigoPuc)
                    .HasPrecision(10)
                    .HasColumnName("codigo_puc");

                entity.Property(e => e.CodigoSaldoIngreso)
                    .HasPrecision(10)
                    .HasColumnName("codigo_saldo_ingreso");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.Presupuestado).HasColumnName("presupuestado");

                entity.Property(e => e.Recaudado).HasColumnName("recaudado");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<PreSaldosTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pre_saldos_test");

                entity.Property(e => e.Ajustado).HasColumnName("ajustado");

                entity.Property(e => e.Ano)
                    .HasPrecision(4)
                    .HasColumnName("ano");

                entity.Property(e => e.Asignacion).HasColumnName("asignacion");

                entity.Property(e => e.Bloqueado).HasColumnName("bloqueado");

                entity.Property(e => e.Causado).HasColumnName("causado");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoFinanciado)
                    .HasPrecision(10)
                    .HasColumnName("codigo_financiado");

                entity.Property(e => e.CodigoIcp)
                    .HasPrecision(10)
                    .HasColumnName("codigo_icp");

                entity.Property(e => e.CodigoPresupuesto)
                    .HasPrecision(10)
                    .HasColumnName("codigo_presupuesto");

                entity.Property(e => e.CodigoPuc)
                    .HasPrecision(10)
                    .HasColumnName("codigo_puc");

                entity.Property(e => e.CodigoSaldo)
                    .HasPrecision(10)
                    .HasColumnName("codigo_saldo");

                entity.Property(e => e.Comprometido).HasColumnName("comprometido");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.FinanciadoId)
                    .HasPrecision(10)
                    .HasColumnName("financiado_id");

                entity.Property(e => e.Modificado).HasColumnName("modificado");

                entity.Property(e => e.Pagado).HasColumnName("pagado");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<PreSaldosTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pre_saldos_tmp");

                entity.Property(e => e.Ajustado).HasColumnName("ajustado");

                entity.Property(e => e.Ano)
                    .HasPrecision(4)
                    .HasColumnName("ano");

                entity.Property(e => e.Asignacion).HasColumnName("asignacion");

                entity.Property(e => e.Bloqueado).HasColumnName("bloqueado");

                entity.Property(e => e.Causado).HasColumnName("causado");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoFinanciado)
                    .HasPrecision(10)
                    .HasColumnName("codigo_financiado");

                entity.Property(e => e.CodigoIcp)
                    .HasPrecision(10)
                    .HasColumnName("codigo_icp");

                entity.Property(e => e.CodigoPresupuesto)
                    .HasPrecision(10)
                    .HasColumnName("codigo_presupuesto");

                entity.Property(e => e.CodigoPuc)
                    .HasPrecision(10)
                    .HasColumnName("codigo_puc");

                entity.Property(e => e.CodigoSaldo)
                    .HasPrecision(10)
                    .HasColumnName("codigo_saldo");

                entity.Property(e => e.Comprometido).HasColumnName("comprometido");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.FinanciadoId)
                    .HasPrecision(10)
                    .HasColumnName("financiado_id");

                entity.Property(e => e.Modificado).HasColumnName("modificado");

                entity.Property(e => e.Pagado).HasColumnName("pagado");

                entity.Property(e => e.Presupuestado).HasColumnName("presupuestado");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<PreSolModificacion>(entity =>
            {
                entity.ToTable("PreSolModificacion");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Año).HasPrecision(4);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoOficio).HasMaxLength(100);

                entity.Property(e => e.CodigoPresupuesto).HasPrecision(10);

                entity.Property(e => e.CodigoSolicitante).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Motivo).HasMaxLength(1000);

                entity.Property(e => e.NumeroCorrelativo).HasPrecision(10);

                entity.Property(e => e.NumeroSolModificacion).HasMaxLength(20);

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.TipoModificacionId).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.PreSolModificacions)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("presolmodificacionempresa_fk");

                entity.HasOne(d => d.CodigoPresupuestoNavigation)
                    .WithMany(p => p.PreSolModificacions)
                    .HasForeignKey(d => d.CodigoPresupuesto)
                    .HasConstraintName("presolmodificacioncodigopresupuesto_fk");

                entity.HasOne(d => d.TipoModificacion)
                    .WithMany(p => p.PreSolModificacions)
                    .HasForeignKey(d => d.TipoModificacionId)
                    .HasConstraintName("presolmodificaciontipomodificacionid_fk");
            });

            modelBuilder.Entity<PreSolModificacionTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pre_sol_modificacion_tmp");

                entity.Property(e => e.Ano)
                    .HasPrecision(4)
                    .HasColumnName("ano");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoOficio)
                    .HasMaxLength(100)
                    .HasColumnName("codigo_oficio");

                entity.Property(e => e.CodigoPresupuesto)
                    .HasPrecision(10)
                    .HasColumnName("codigo_presupuesto");

                entity.Property(e => e.CodigoSolModificacion)
                    .HasPrecision(10)
                    .HasColumnName("codigo_sol_modificacion");

                entity.Property(e => e.CodigoSolicitante)
                    .HasPrecision(10)
                    .HasColumnName("codigo_solicitante");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaSolicitud).HasColumnName("fecha_solicitud");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(1000)
                    .HasColumnName("motivo");

                entity.Property(e => e.NumeroCorrelativo)
                    .HasPrecision(10)
                    .HasColumnName("numero_correlativo");

                entity.Property(e => e.NumeroSolModificacion)
                    .HasMaxLength(20)
                    .HasColumnName("numero_sol_modificacion");

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .HasColumnName("status")
                    .IsFixedLength();

                entity.Property(e => e.TipoModificacionId)
                    .HasPrecision(10)
                    .HasColumnName("tipo_modificacion_id");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<PreTitulo>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Codigo).HasMaxLength(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Titulo).HasMaxLength(100);

                entity.Property(e => e.TituloPadreId).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.PreTitulos)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("pretitulosempresa_fk");
            });

            modelBuilder.Entity<PreTmpSaldo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pre_tmp_saldos");

                entity.Property(e => e.Ajustado).HasColumnName("ajustado");

                entity.Property(e => e.Ano)
                    .HasPrecision(4)
                    .HasColumnName("ano");

                entity.Property(e => e.Asignacion).HasColumnName("asignacion");

                entity.Property(e => e.Bloqueado).HasColumnName("bloqueado");

                entity.Property(e => e.Causado).HasColumnName("causado");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoFinanciado)
                    .HasPrecision(10)
                    .HasColumnName("codigo_financiado");

                entity.Property(e => e.CodigoIcp)
                    .HasPrecision(10)
                    .HasColumnName("codigo_icp");

                entity.Property(e => e.CodigoPresupuesto)
                    .HasPrecision(10)
                    .HasColumnName("codigo_presupuesto");

                entity.Property(e => e.CodigoPuc)
                    .HasPrecision(10)
                    .HasColumnName("codigo_puc");

                entity.Property(e => e.CodigoSaldo)
                    .HasPrecision(10)
                    .HasColumnName("codigo_saldo");

                entity.Property(e => e.Comprometido).HasColumnName("comprometido");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.FinanciadoId)
                    .HasPrecision(10)
                    .HasColumnName("financiado_id");

                entity.Property(e => e.Modificado).HasColumnName("modificado");

                entity.Property(e => e.Pagado).HasColumnName("pagado");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<PreTransferencia>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Año).HasPrecision(4);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoIcp).HasPrecision(10);

                entity.Property(e => e.CodigoPresupuesto).HasPrecision(10);

                entity.Property(e => e.CodigoPuc).HasPrecision(10);

                entity.Property(e => e.Complemeto1).HasMaxLength(100);

                entity.Property(e => e.Complemeto2).HasMaxLength(100);

                entity.Property(e => e.Complemeto3).HasMaxLength(100);

                entity.Property(e => e.Denominacion).HasMaxLength(300);

                entity.Property(e => e.Monto).HasPrecision(15);

                entity.Property(e => e.TipoMontoId).HasPrecision(10);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.PreTransferencia)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("pretransferenciasempresa_fk");

                entity.HasOne(d => d.CodigoIcpNavigation)
                    .WithMany(p => p.PreTransferencia)
                    .HasForeignKey(d => d.CodigoIcp)
                    .HasConstraintName("pretransferenciascodigoicp_fk");

                entity.HasOne(d => d.CodigoPresupuestoNavigation)
                    .WithMany(p => p.PreTransferencia)
                    .HasForeignKey(d => d.CodigoPresupuesto)
                    .HasConstraintName("pretransferenciascodigopresupuesto_fk");

                entity.HasOne(d => d.CodigoPucNavigation)
                    .WithMany(p => p.PreTransferencia)
                    .HasForeignKey(d => d.CodigoPuc)
                    .HasConstraintName("pretransferenciascodigopuc_fk");

                entity.HasOne(d => d.TipoMonto)
                    .WithMany(p => p.PreTransferencia)
                    .HasForeignKey(d => d.TipoMontoId)
                    .HasConstraintName("pretransferenciastipomontoid_fk");
            });

            modelBuilder.Entity<PreUnidadesEjecutora>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.CodigoPresupuesto).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Denominacion).HasMaxLength(200);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.PreUnidadesEjecutoras)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("preunidadesejecutorasempresa_fk");

                entity.HasOne(d => d.CodigoPresupuestoNavigation)
                    .WithMany(p => p.PreUnidadesEjecutoras)
                    .HasForeignKey(d => d.CodigoPresupuesto)
                    .HasConstraintName("preunidadesejecutoraspresupuesto_fk");
            });

            modelBuilder.Entity<RhHAdministrativo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rh_h_administrativos");

                entity.Property(e => e.BancoId)
                    .HasPrecision(5)
                    .HasColumnName("banco_id");

                entity.Property(e => e.CargoId)
                    .HasPrecision(5)
                    .HasColumnName("cargo_id");

                entity.Property(e => e.CodigoAdministrativo)
                    .HasPrecision(10)
                    .HasColumnName("codigo_administrativo");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoHAdministrativo)
                    .HasPrecision(10)
                    .HasColumnName("codigo_h_administrativo");

                entity.Property(e => e.CodigoPersona)
                    .HasPrecision(10)
                    .HasColumnName("codigo_persona");

                entity.Property(e => e.FechaHIns).HasColumnName("fecha_h_ins");

                entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.NoCuenta)
                    .HasMaxLength(20)
                    .HasColumnName("no_cuenta");

                entity.Property(e => e.ProfesionId)
                    .HasPrecision(5)
                    .HasColumnName("profesion_id");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasColumnName("status");

                entity.Property(e => e.TipoCuentaId)
                    .HasPrecision(5)
                    .HasColumnName("tipo_cuenta_id");

                entity.Property(e => e.TipoPago)
                    .HasMaxLength(1)
                    .HasColumnName("tipo_pago");

                entity.Property(e => e.Turno)
                    .HasMaxLength(1)
                    .HasColumnName("turno");

                entity.Property(e => e.UsuarioHIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_h_ins");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<RhHConcepto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rh_h_conceptos");

                entity.Property(e => e.Automatico)
                    .HasPrecision(1)
                    .HasColumnName("automatico");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(5)
                    .HasColumnName("codigo");

                entity.Property(e => e.CodigoConcepto)
                    .HasPrecision(10)
                    .HasColumnName("codigo_concepto");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoHConcepto)
                    .HasPrecision(10)
                    .HasColumnName("codigo_h_concepto");

                entity.Property(e => e.CodigoPuc)
                    .HasPrecision(10)
                    .HasColumnName("codigo_puc");

                entity.Property(e => e.CodigoTipoNomina)
                    .HasPrecision(10)
                    .HasColumnName("codigo_tipo_nomina");

                entity.Property(e => e.Dedusible)
                    .HasPrecision(1)
                    .HasColumnName("dedusible");

                entity.Property(e => e.Denominacion)
                    .HasMaxLength(100)
                    .HasColumnName("denominacion");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(1000)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaInsH).HasColumnName("fecha_ins_h");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.FrecuenciaId)
                    .HasPrecision(10)
                    .HasColumnName("frecuencia_id");

                entity.Property(e => e.Maquina)
                    .HasMaxLength(100)
                    .HasColumnName("maquina");

                entity.Property(e => e.ModuloId)
                    .HasPrecision(10)
                    .HasColumnName("modulo_id");

                entity.Property(e => e.OsUsuario)
                    .HasMaxLength(100)
                    .HasColumnName("os_usuario");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasColumnName("status");

                entity.Property(e => e.TipoConcepto)
                    .HasMaxLength(1)
                    .HasColumnName("tipo_concepto");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioInsH)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins_h");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<RhHHistoricoNomina>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rh_h_historico_nomina");

                entity.Property(e => e.CodigoConcepto)
                    .HasPrecision(10)
                    .HasColumnName("codigo_concepto");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoHHistoricoNom)
                    .HasPrecision(10)
                    .HasColumnName("codigo_h_historico_nom");

                entity.Property(e => e.CodigoHistoricoNomina)
                    .HasPrecision(10)
                    .HasColumnName("codigo_historico_nomina");

                entity.Property(e => e.CodigoPeriodo)
                    .HasPrecision(10)
                    .HasColumnName("codigo_periodo");

                entity.Property(e => e.CodigoPersona)
                    .HasPrecision(10)
                    .HasColumnName("codigo_persona");

                entity.Property(e => e.CodigoTipoNomina)
                    .HasPrecision(10)
                    .HasColumnName("codigo_tipo_nomina");

                entity.Property(e => e.ComplementoConcepto)
                    .HasMaxLength(100)
                    .HasColumnName("complemento_concepto");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaInsHHistoricoNom).HasColumnName("fecha_ins_h_historico_nom");

                entity.Property(e => e.FechaNomina).HasColumnName("fecha_nomina");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.FrecuenciaId)
                    .HasPrecision(10)
                    .HasColumnName("frecuencia_id");

                entity.Property(e => e.Monto).HasColumnName("monto");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasColumnName("status");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .HasColumnName("tipo");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioInsHHistoricoNom)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins_h_historico_nom");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<RhHPeriodo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rh_h_periodos");

                entity.Property(e => e.CodigoCuentaEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_cuenta_empresa");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoHPeriodo)
                    .HasPrecision(10)
                    .HasColumnName("codigo_h_periodo");

                entity.Property(e => e.CodigoPeriodo)
                    .HasPrecision(10)
                    .HasColumnName("codigo_periodo");

                entity.Property(e => e.CodigoPresupuesto)
                    .HasPrecision(10)
                    .HasColumnName("codigo_presupuesto");

                entity.Property(e => e.CodigoTipoNomina)
                    .HasPrecision(10)
                    .HasColumnName("codigo_tipo_nomina");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaCierre).HasColumnName("fecha_cierre");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaInsH).HasColumnName("fecha_ins_h");

                entity.Property(e => e.FechaNomina).HasColumnName("fecha_nomina");

                entity.Property(e => e.FechaPrecierre).HasColumnName("fecha_precierre");

                entity.Property(e => e.FechaPrenomina).HasColumnName("fecha_prenomina");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.Periodo)
                    .HasPrecision(1)
                    .HasColumnName("periodo");

                entity.Property(e => e.TipoNomina)
                    .HasMaxLength(1)
                    .HasColumnName("tipo_nomina");

                entity.Property(e => e.UsuarioCierre)
                    .HasPrecision(10)
                    .HasColumnName("usuario_cierre");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioInsH)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins_h");

                entity.Property(e => e.UsuarioPrecierre)
                    .HasPrecision(10)
                    .HasColumnName("usuario_precierre");

                entity.Property(e => e.UsuarioPrenomina)
                    .HasPrecision(10)
                    .HasColumnName("usuario_prenomina");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<RhHPrestamosPrestacione>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rh_h_prestamos_prestaciones");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoHPrestamoPrestacion)
                    .HasPrecision(10)
                    .HasColumnName("codigo_h_prestamo_prestacion");

                entity.Property(e => e.CodigoPeriodo1erpago)
                    .HasPrecision(10)
                    .HasColumnName("codigo_periodo_1erpago");

                entity.Property(e => e.CodigoPeriodoUltpago)
                    .HasPrecision(10)
                    .HasColumnName("codigo_periodo_ultpago");

                entity.Property(e => e.CodigoPersona)
                    .HasPrecision(10)
                    .HasColumnName("codigo_persona");

                entity.Property(e => e.CodigoPrestamoPrestacion)
                    .HasPrecision(10)
                    .HasColumnName("codigo_prestamo_prestacion");

                entity.Property(e => e.CodigoPrestamoPrestacionRen)
                    .HasPrecision(10)
                    .HasColumnName("codigo_prestamo_prestacion_ren");

                entity.Property(e => e.CodigoTipoNomina)
                    .HasPrecision(10)
                    .HasColumnName("codigo_tipo_nomina");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaHIns).HasColumnName("fecha_h_ins");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaPrestamo).HasColumnName("fecha_prestamo");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.FrecuenciaPagoId)
                    .HasPrecision(10)
                    .HasColumnName("frecuencia_pago_id");

                entity.Property(e => e.InteresPagado).HasColumnName("interes_pagado");

                entity.Property(e => e.MontoCuota).HasColumnName("monto_cuota");

                entity.Property(e => e.MontoPagado).HasColumnName("monto_pagado");

                entity.Property(e => e.MontoPrestamo).HasColumnName("monto_prestamo");

                entity.Property(e => e.MontoRenovado).HasColumnName("monto_renovado");

                entity.Property(e => e.NumeroCuotas)
                    .HasPrecision(5)
                    .HasColumnName("numero_cuotas");

                entity.Property(e => e.NumeroCuotasPagadas)
                    .HasPrecision(5)
                    .HasColumnName("numero_cuotas_pagadas");

                entity.Property(e => e.PorInteres)
                    .HasPrecision(5)
                    .HasColumnName("por_interes");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasColumnName("status");

                entity.Property(e => e.TipoInteresId)
                    .HasPrecision(10)
                    .HasColumnName("tipo_interes_id");

                entity.Property(e => e.TipoPrestamoId)
                    .HasPrecision(10)
                    .HasColumnName("tipo_prestamo_id");

                entity.Property(e => e.UsuarioHIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_h_ins");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<RhHRelacionCargo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rh_h_relacion_cargos");

                entity.Property(e => e.CargoCodigo)
                    .HasMaxLength(10)
                    .HasColumnName("cargo_codigo");

                entity.Property(e => e.CodigoCargo)
                    .HasPrecision(10)
                    .HasColumnName("codigo_cargo");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoHRelacionCargo)
                    .HasPrecision(10)
                    .HasColumnName("codigo_h_relacion_cargo");

                entity.Property(e => e.CodigoIcp)
                    .HasPrecision(10)
                    .HasColumnName("codigo_icp");

                entity.Property(e => e.CodigoIcpUbicacion)
                    .HasPrecision(10)
                    .HasColumnName("codigo_icp_ubicacion");

                entity.Property(e => e.CodigoPersona)
                    .HasPrecision(10)
                    .HasColumnName("codigo_persona");

                entity.Property(e => e.CodigoPresupuesto)
                    .HasPrecision(10)
                    .HasColumnName("codigo_presupuesto");

                entity.Property(e => e.CodigoRelacionCargo)
                    .HasPrecision(10)
                    .HasColumnName("codigo_relacion_cargo");

                entity.Property(e => e.CodigoRelacionCargoPre).HasColumnName("codigo_relacion_cargo_pre");

                entity.Property(e => e.CodigoTipoNomina)
                    .HasPrecision(10)
                    .HasColumnName("codigo_tipo_nomina");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaFin).HasColumnName("fecha_fin");

                entity.Property(e => e.FechaFinVigencia).HasColumnName("fecha_fin_vigencia");

                entity.Property(e => e.FechaIni).HasColumnName("fecha_ini");

                entity.Property(e => e.FechaIniVigencia).HasColumnName("fecha_ini_vigencia");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaInsH).HasColumnName("fecha_ins_h");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.Sueldo).HasColumnName("sueldo");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioInsH)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins_h");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<RhHistoricoVFamiliaresBec>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rh_historico_v_familiares_bec");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .HasColumnName("apellido");

                entity.Property(e => e.CedulaFamiliar)
                    .HasPrecision(10)
                    .HasColumnName("cedula_familiar");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoFamiliar)
                    .HasPrecision(10)
                    .HasColumnName("codigo_familiar");

                entity.Property(e => e.CodigoHistoricoFamBec)
                    .HasPrecision(10)
                    .HasColumnName("codigo_historico_fam_bec");

                entity.Property(e => e.CodigoPeriodo)
                    .HasPrecision(10)
                    .HasColumnName("codigo_periodo");

                entity.Property(e => e.CodigoPersona)
                    .HasPrecision(10)
                    .HasColumnName("codigo_persona");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaNacimiento).HasColumnName("fecha_nacimiento");

                entity.Property(e => e.FechaNomina).HasColumnName("fecha_nomina");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.Grado)
                    .HasPrecision(2)
                    .HasColumnName("grado");

                entity.Property(e => e.Nacionalidad)
                    .HasMaxLength(1)
                    .HasColumnName("nacionalidad");

                entity.Property(e => e.NivelEducativo)
                    .HasMaxLength(100)
                    .HasColumnName("nivel_educativo");

                entity.Property(e => e.NivelEducativoId)
                    .HasPrecision(10)
                    .HasColumnName("nivel_educativo_id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.Pariente)
                    .HasMaxLength(100)
                    .HasColumnName("pariente");

                entity.Property(e => e.ParienteId)
                    .HasPrecision(10)
                    .HasColumnName("pariente_id");

                entity.Property(e => e.Sexo)
                    .HasMaxLength(1)
                    .HasColumnName("sexo");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<RhMovNominaPrg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rh_mov_nomina_prg");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoMovNomina)
                    .HasPrecision(10)
                    .HasColumnName("codigo_mov_nomina");

                entity.Property(e => e.CodigoMovNominaPrg)
                    .HasPrecision(10)
                    .HasColumnName("codigo_mov_nomina_prg");

                entity.Property(e => e.CodigoPeriodo)
                    .HasPrecision(10)
                    .HasColumnName("codigo_periodo");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<RhTmpAntiguedadLoad>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rh_tmp_antiguedad_load");

                entity.Property(e => e.Anticipo1).HasColumnName("anticipo1");

                entity.Property(e => e.Anticipo2).HasColumnName("anticipo2");

                entity.Property(e => e.Anticipo3).HasColumnName("anticipo3");

                entity.Property(e => e.Anticipo4).HasColumnName("anticipo4");

                entity.Property(e => e.Anticipo5).HasColumnName("anticipo5");

                entity.Property(e => e.Antiguedad).HasColumnName("antiguedad");

                entity.Property(e => e.Cedula)
                    .HasPrecision(10)
                    .HasColumnName("cedula");

                entity.Property(e => e.Dias)
                    .HasPrecision(5)
                    .HasColumnName("dias");

                entity.Property(e => e.Fecha1).HasColumnName("fecha1");

                entity.Property(e => e.Fecha2).HasColumnName("fecha2");

                entity.Property(e => e.Fecha3).HasColumnName("fecha3");

                entity.Property(e => e.Fecha4).HasColumnName("fecha4");

                entity.Property(e => e.Fecha5).HasColumnName("fecha5");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<RhTmpBb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rh_tmp_bb");

                entity.Property(e => e.Cedula)
                    .HasPrecision(10)
                    .HasColumnName("cedula");

                entity.Property(e => e.Monto).HasColumnName("monto");
            });

            modelBuilder.Entity<RhTmpBecado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rh_tmp_becados");

                entity.Property(e => e.CodigoBecado)
                    .HasPrecision(10)
                    .HasColumnName("codigo_becado");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoFamiliar)
                    .HasPrecision(10)
                    .HasColumnName("codigo_familiar");

                entity.Property(e => e.CodigoPeriodo)
                    .HasPrecision(10)
                    .HasColumnName("codigo_periodo");

                entity.Property(e => e.CodigoPersona)
                    .HasPrecision(10)
                    .HasColumnName("codigo_persona");

                entity.Property(e => e.CodigoTipoNomina)
                    .HasPrecision(10)
                    .HasColumnName("codigo_tipo_nomina");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaNomina).HasColumnName("fecha_nomina");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.Monto).HasColumnName("monto");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(1000)
                    .HasColumnName("observacion");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<RhTmpCa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rh_tmp_ca");

                entity.Property(e => e.Cedula)
                    .HasPrecision(10)
                    .HasColumnName("cedula");

                entity.Property(e => e.Monto).HasColumnName("monto");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<RhTmpCajaAhorro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rh_tmp_caja_ahorro");

                entity.Property(e => e.CodigoBanco)
                    .HasPrecision(10)
                    .HasColumnName("codigo_banco");

                entity.Property(e => e.CodigoBancoLiq)
                    .HasPrecision(10)
                    .HasColumnName("codigo_banco_liq");

                entity.Property(e => e.CodigoCajaAhorro)
                    .HasPrecision(10)
                    .HasColumnName("codigo_caja_ahorro");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoPeriodoFin)
                    .HasPrecision(10)
                    .HasColumnName("codigo_periodo_fin");

                entity.Property(e => e.CodigoPeriodoInicio)
                    .HasPrecision(10)
                    .HasColumnName("codigo_periodo_inicio");

                entity.Property(e => e.CodigoPersona)
                    .HasPrecision(10)
                    .HasColumnName("codigo_persona");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaEgreso).HasColumnName("fecha_egreso");

                entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaLiq).HasColumnName("fecha_liq");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.MontoLiq).HasColumnName("monto_liq");

                entity.Property(e => e.NumeroChLiq)
                    .HasPrecision(10)
                    .HasColumnName("numero_ch_liq");

                entity.Property(e => e.NumeroCuenta)
                    .HasMaxLength(20)
                    .HasColumnName("numero_cuenta");

                entity.Property(e => e.NumeroCuentaLiq)
                    .HasMaxLength(20)
                    .HasColumnName("numero_cuenta_liq");

                entity.Property(e => e.PorAportePatron)
                    .HasPrecision(5)
                    .HasColumnName("por_aporte_patron");

                entity.Property(e => e.PorAporteTrabajador)
                    .HasPrecision(5)
                    .HasColumnName("por_aporte_trabajador");

                entity.Property(e => e.SaldoDeuda).HasColumnName("saldo_deuda");

                entity.Property(e => e.SaldoHaber).HasColumnName("saldo_haber");

                entity.Property(e => e.TipoCuentaId)
                    .HasPrecision(10)
                    .HasColumnName("tipo_cuenta_id");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<RhTmpFideicomiso>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rh_tmp_fideicomiso");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(100)
                    .HasColumnName("apellidos");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(12)
                    .HasColumnName("cedula");

                entity.Property(e => e.CodigoPersona)
                    .HasPrecision(10)
                    .HasColumnName("codigo_persona");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(100)
                    .HasColumnName("nombres");

                entity.Property(e => e.NumeroCuenta)
                    .HasMaxLength(20)
                    .HasColumnName("numero_cuenta");
            });

            modelBuilder.Entity<RhTmpIslr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rh_tmp_islr");

                entity.Property(e => e.Cedula).HasColumnName("cedula");

                entity.Property(e => e.NombresApellidos)
                    .HasMaxLength(200)
                    .HasColumnName("nombres_apellidos");

                entity.Property(e => e.Rif)
                    .HasMaxLength(10)
                    .HasColumnName("rif");
            });

            modelBuilder.Entity<RhTmpLoad>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rh_tmp_load");

                entity.Property(e => e.Cedula)
                    .HasPrecision(10)
                    .HasColumnName("cedula");

                entity.Property(e => e.Monto).HasColumnName("monto");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<RhTmpMovNomina>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rh_tmp_mov_nomina");

                entity.Property(e => e.CodigoConcepto)
                    .HasPrecision(10)
                    .HasColumnName("codigo_concepto");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoMovNomina)
                    .HasPrecision(10)
                    .HasColumnName("codigo_mov_nomina");

                entity.Property(e => e.CodigoPersona)
                    .HasPrecision(10)
                    .HasColumnName("codigo_persona");

                entity.Property(e => e.CodigoTipoNomina)
                    .HasPrecision(10)
                    .HasColumnName("codigo_tipo_nomina");

                entity.Property(e => e.ComplementoConcepto)
                    .HasMaxLength(100)
                    .HasColumnName("complemento_concepto");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.FrecuenciaId)
                    .HasPrecision(10)
                    .HasColumnName("frecuencia_id");

                entity.Property(e => e.Monto).HasColumnName("monto");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasColumnName("status");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .HasColumnName("tipo");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<RhTmpMovPrestacione>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rh_tmp_mov_prestaciones");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoMovPrestacion)
                    .HasPrecision(10)
                    .HasColumnName("codigo_mov_prestacion");

                entity.Property(e => e.CodigoPersona)
                    .HasPrecision(10)
                    .HasColumnName("codigo_persona");

                entity.Property(e => e.ComplementoConcepto)
                    .HasMaxLength(100)
                    .HasColumnName("complemento_concepto");

                entity.Property(e => e.ConceptoId)
                    .HasPrecision(10)
                    .HasColumnName("concepto_id");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.Fecha).HasColumnName("fecha");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.Monto).HasColumnName("monto");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<RhTmpRelacionCargo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rh_tmp_relacion_cargo");

                entity.Property(e => e.CargoCodigo)
                    .HasMaxLength(5)
                    .HasColumnName("cargo_codigo");

                entity.Property(e => e.CodigoCargo)
                    .HasPrecision(10)
                    .HasColumnName("codigo_cargo");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoIcp)
                    .HasPrecision(10)
                    .HasColumnName("codigo_icp");

                entity.Property(e => e.CodigoIcpUbicacion)
                    .HasPrecision(10)
                    .HasColumnName("codigo_icp_ubicacion");

                entity.Property(e => e.CodigoPersona)
                    .HasPrecision(10)
                    .HasColumnName("codigo_persona");

                entity.Property(e => e.CodigoPresupuesto)
                    .HasPrecision(10)
                    .HasColumnName("codigo_presupuesto");

                entity.Property(e => e.CodigoRelacionCargo)
                    .HasPrecision(10)
                    .HasColumnName("codigo_relacion_cargo");

                entity.Property(e => e.CodigoRelacionCargoPre).HasColumnName("codigo_relacion_cargo_pre");

                entity.Property(e => e.CodigoTipoNomina)
                    .HasPrecision(10)
                    .HasColumnName("codigo_tipo_nomina");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaFin).HasColumnName("fecha_fin");

                entity.Property(e => e.FechaIni).HasColumnName("fecha_ini");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.Sueldo).HasColumnName("sueldo");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            modelBuilder.Entity<SisDescriptiva>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Codigo).HasMaxLength(100);

                entity.Property(e => e.CodigoEmpresa).HasPrecision(10);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.DescripcionPadreId).HasPrecision(10);

                entity.Property(e => e.Estatus).HasPrecision(1);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);
            });

            modelBuilder.Entity<SisEmpresa>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CodigoEstadoCtaFiscal).HasMaxLength(5);

                entity.Property(e => e.CodigoMunicipioCtaFiscal).HasMaxLength(5);

                entity.Property(e => e.Complemento1).HasMaxLength(100);

                entity.Property(e => e.Complemento10).HasMaxLength(100);

                entity.Property(e => e.Complemento11).HasMaxLength(100);

                entity.Property(e => e.Complemento12).HasMaxLength(100);

                entity.Property(e => e.Complemento13).HasMaxLength(100);

                entity.Property(e => e.Complemento14).HasMaxLength(100);

                entity.Property(e => e.Complemento15).HasMaxLength(100);

                entity.Property(e => e.Complemento2).HasMaxLength(100);

                entity.Property(e => e.Complemento3).HasMaxLength(100);

                entity.Property(e => e.Complemento4).HasMaxLength(100);

                entity.Property(e => e.Complemento5).HasMaxLength(100);

                entity.Property(e => e.Complemento6).HasMaxLength(100);

                entity.Property(e => e.Complemento7).HasMaxLength(100);

                entity.Property(e => e.Complemento8).HasMaxLength(100);

                entity.Property(e => e.Complemento9).HasMaxLength(100);

                entity.Property(e => e.DirectorioPrincipal).HasMaxLength(20);

                entity.Property(e => e.DirectorioPrivado).HasMaxLength(20);

                entity.Property(e => e.DirectorioPublico).HasMaxLength(20);

                entity.Property(e => e.DondeEstoy).HasPrecision(1);

                entity.Property(e => e.Gerencial).HasPrecision(1);

                entity.Property(e => e.IdentificacionId).HasPrecision(10);

                entity.Property(e => e.MarcaServidorId).HasPrecision(10);

                entity.Property(e => e.NombreEmpresa).HasMaxLength(100);

                entity.Property(e => e.NombreServidor).HasMaxLength(20);

                entity.Property(e => e.NumeroIdentificacion).HasMaxLength(20);

                entity.Property(e => e.Separator).HasMaxLength(10);

                entity.Property(e => e.SistemaOperativoId).HasPrecision(10);

                entity.Property(e => e.TipoEmpresaId).HasPrecision(10);

                entity.Property(e => e.UnidadInstalacion).HasMaxLength(20);

                entity.Property(e => e.UsuarioActualizacion).HasPrecision(10);

                entity.Property(e => e.UsuarioCreacion).HasPrecision(10);

                entity.Property(e => e.VersionSistemaId).HasPrecision(10);

                entity.HasOne(d => d.Identificacion)
                    .WithMany(p => p.SisEmpresaIdentificacions)
                    .HasForeignKey(d => d.IdentificacionId)
                    .HasConstraintName("sisempresasidentificacionid_fk");

                entity.HasOne(d => d.MarcaServidor)
                    .WithMany(p => p.SisEmpresaMarcaServidors)
                    .HasForeignKey(d => d.MarcaServidorId)
                    .HasConstraintName("sisempresasmarcaservidorid_fk");

                entity.HasOne(d => d.SistemaOperativo)
                    .WithMany(p => p.SisEmpresaSistemaOperativos)
                    .HasForeignKey(d => d.SistemaOperativoId)
                    .HasConstraintName("sisempresassistemaoperativoid_fk");

                entity.HasOne(d => d.TipoEmpresa)
                    .WithMany(p => p.SisEmpresaTipoEmpresas)
                    .HasForeignKey(d => d.TipoEmpresaId)
                    .HasConstraintName("sisempresastipoempresaid_fk");

                entity.HasOne(d => d.VersionSistema)
                    .WithMany(p => p.SisEmpresaVersionSistemas)
                    .HasForeignKey(d => d.VersionSistemaId)
                    .HasConstraintName("sisempresasversionsistemaid_fk");
            });

            modelBuilder.Entity<Tmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp");

                entity.Property(e => e.CodigoSaldo)
                    .HasPrecision(10)
                    .HasColumnName("codigo_saldo");

                entity.Property(e => e.Monto).HasColumnName("monto");

                entity.Property(e => e.MontoSaldo).HasColumnName("monto_saldo");
            });

            modelBuilder.Entity<TmpMaestroContrato>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_maestro_contrato");

                entity.Property(e => e.CodigoCostoContCol)
                    .HasPrecision(10)
                    .HasColumnName("codigo_costo_cont_col");

                entity.Property(e => e.CodigoEmpresa)
                    .HasPrecision(10)
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoPresupuesto)
                    .HasPrecision(10)
                    .HasColumnName("codigo_presupuesto");

                entity.Property(e => e.Denominacion)
                    .HasMaxLength(2000)
                    .HasColumnName("denominacion");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(100)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(100)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3)
                    .HasMaxLength(100)
                    .HasColumnName("extra3");

                entity.Property(e => e.FechaFin).HasColumnName("fecha_fin");

                entity.Property(e => e.FechaIni).HasColumnName("fecha_ini");

                entity.Property(e => e.FechaIns).HasColumnName("fecha_ins");

                entity.Property(e => e.FechaUpd).HasColumnName("fecha_upd");

                entity.Property(e => e.NumeroClausula)
                    .HasPrecision(10)
                    .HasColumnName("numero_clausula");

                entity.Property(e => e.TipoNomina)
                    .HasPrecision(10)
                    .HasColumnName("tipo_nomina");

                entity.Property(e => e.UsuarioIns)
                    .HasPrecision(10)
                    .HasColumnName("usuario_ins");

                entity.Property(e => e.UsuarioUpd)
                    .HasPrecision(10)
                    .HasColumnName("usuario_upd");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
*/