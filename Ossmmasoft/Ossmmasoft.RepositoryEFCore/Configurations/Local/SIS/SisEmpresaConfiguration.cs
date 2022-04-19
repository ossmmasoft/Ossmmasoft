using Ossmmasoft.Entities.Local.POCOs.SIS;

namespace Ossmmasoft.RepositoryEFCore.Configurations.Local.SIS
{
    internal class SisEmpesaConfiguration : IEntityTypeConfiguration<SisEmpresa>
    {
        public void Configure(EntityTypeBuilder<SisEmpresa> builder)
        {
            builder.Property(e => e.Id).HasPrecision(10);

            builder.Property(e => e.CodigoEstadoCtaFiscal).HasMaxLength(5);

            builder.Property(e => e.CodigoMunicipioCtaFiscal).HasMaxLength(5);

            builder.Property(e => e.Complemento1).HasMaxLength(100);

            builder.Property(e => e.Complemento10).HasMaxLength(100);

            builder.Property(e => e.Complemento11).HasMaxLength(100);

            builder.Property(e => e.Complemento12).HasMaxLength(100);

            builder.Property(e => e.Complemento13).HasMaxLength(100);

            builder.Property(e => e.Complemento14).HasMaxLength(100);

            builder.Property(e => e.Complemento15).HasMaxLength(100);

            builder.Property(e => e.Complemento2).HasMaxLength(100);

            builder.Property(e => e.Complemento3).HasMaxLength(100);

            builder.Property(e => e.Complemento4).HasMaxLength(100);

            builder.Property(e => e.Complemento5).HasMaxLength(100);

            builder.Property(e => e.Complemento6).HasMaxLength(100);

            builder.Property(e => e.Complemento7).HasMaxLength(100);

            builder.Property(e => e.Complemento8).HasMaxLength(100);

            builder.Property(e => e.Complemento9).HasMaxLength(100);

            builder.Property(e => e.DirectorioPrincipal).HasMaxLength(20);

            builder.Property(e => e.DirectorioPrivado).HasMaxLength(20);

            builder.Property(e => e.DirectorioPublico).HasMaxLength(20);

            builder.Property(e => e.DondeEstoy).HasPrecision(1);

            builder.Property(e => e.Gerencial).HasPrecision(1);

            builder.Property(e => e.IdentificacionId).HasPrecision(10);

            builder.Property(e => e.MarcaServidorId).HasPrecision(10);

            builder.Property(e => e.NombreEmpresa).HasMaxLength(100);

            builder.Property(e => e.NombreServidor).HasMaxLength(20);

            builder.Property(e => e.NumeroIdentificacion).HasMaxLength(20);

            builder.Property(e => e.Separator).HasMaxLength(10);

            builder.Property(e => e.SistemaOperativoId).HasPrecision(10);

            builder.Property(e => e.TipoEmpresaId).HasPrecision(10);

            builder.Property(e => e.UnidadInstalacion).HasMaxLength(20);

            builder.Property(e => e.UsuarioActualizacion).HasPrecision(10);

            builder.Property(e => e.UsuarioCreacion).HasPrecision(10);

            builder.Property(e => e.VersionSistemaId).HasPrecision(10);

            builder.HasOne(d => d.Identificacion)
                .WithMany(p => p.SisEmpresaIdentificacions)
                .HasForeignKey(d => d.IdentificacionId)
                .HasConstraintName("sisempresasidentificacionid_fk");

            builder.HasOne(d => d.MarcaServidor)
                .WithMany(p => p.SisEmpresaMarcaServidors)
                .HasForeignKey(d => d.MarcaServidorId)
                .HasConstraintName("sisempresasmarcaservidorid_fk");

            builder.HasOne(d => d.SistemaOperativo)
                .WithMany(p => p.SisEmpresaSistemaOperativos)
                .HasForeignKey(d => d.SistemaOperativoId)
                .HasConstraintName("sisempresassistemaoperativoid_fk");

            builder.HasOne(d => d.TipoEmpresa)
                .WithMany(p => p.SisEmpresaTipoEmpresas)
                .HasForeignKey(d => d.TipoEmpresaId)
                .HasConstraintName("sisempresastipoempresaid_fk");

            builder.HasOne(d => d.VersionSistema)
                .WithMany(p => p.SisEmpresaVersionSistemas)
                .HasForeignKey(d => d.VersionSistemaId)
                .HasConstraintName("sisempresasversionsistemaid_fk");
        }

    }
}
