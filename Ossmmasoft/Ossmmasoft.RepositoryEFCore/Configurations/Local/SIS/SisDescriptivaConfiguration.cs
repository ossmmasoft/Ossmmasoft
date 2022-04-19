using Ossmmasoft.Entities.Local.POCOs.SIS;

namespace Ossmmasoft.RepositoryEFCore.Configurations.Local.SIS
{
    internal class SisDescriptivaConfiguration : IEntityTypeConfiguration<SisDescriptiva>
    {
        public void Configure(EntityTypeBuilder<SisDescriptiva> builder)
        {
            builder.Property(e => e.Id).HasPrecision(10);

            builder.Property(e => e.Codigo).HasMaxLength(100);

            builder.Property(e => e.CodigoEmpresa).HasPrecision(10);

            builder.Property(e => e.Complemento1).HasMaxLength(100);

            builder.Property(e => e.Complemento2).HasMaxLength(100);

            builder.Property(e => e.Complemento3).HasMaxLength(100);

            builder.Property(e => e.Descripcion).HasMaxLength(100);

            builder.Property(e => e.DescripcionPadreId).HasPrecision(10);

            builder.Property(e => e.Estatus).HasPrecision(1);

            builder.Property(e => e.UsuarioActualizacion).HasPrecision(10);

            builder.Property(e => e.UsuarioCreacion).HasPrecision(10);
        }

    }
}
