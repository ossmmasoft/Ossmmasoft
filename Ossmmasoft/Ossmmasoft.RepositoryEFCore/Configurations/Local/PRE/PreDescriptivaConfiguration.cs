namespace Ossmmasoft.RepositoryEFCore.Configurations.Local
{
    internal class PreDescriptivaConfiguration : IEntityTypeConfiguration<PreDescriptiva>
    {
        public void Configure(EntityTypeBuilder<PreDescriptiva> builder)
        {
            builder.Property(e => e.Id).HasPrecision(10);

            builder.Property(e => e.Codigo).HasMaxLength(10);

            builder.Property(e => e.CodigoEmpresa).HasPrecision(10);

            builder.Property(e => e.Complemento1).HasMaxLength(100);

            builder.Property(e => e.Complemento2).HasMaxLength(100);

            builder.Property(e => e.Complemento3).HasMaxLength(100);

            builder.Property(e => e.Complemento4).HasMaxLength(100);

            builder.Property(e => e.Complemento5).HasMaxLength(100);

            builder.Property(e => e.Descripcion).HasMaxLength(100);

            builder.Property(e => e.DescripcionPadreId).HasPrecision(10);

            builder.Property(e => e.PreTituloId).HasPrecision(10);

            builder.Property(e => e.UsuarioActualizacion).HasPrecision(10);

            builder.Property(e => e.UsuarioCreacion).HasPrecision(10);

            builder.HasOne(d => d.PreTitulo)
                .WithMany(p => p.PreDescriptivas)
                .HasForeignKey(d => d.PreTituloId)
                .HasConstraintName("predescriptivas_fk"); ;
        }
    }
}
