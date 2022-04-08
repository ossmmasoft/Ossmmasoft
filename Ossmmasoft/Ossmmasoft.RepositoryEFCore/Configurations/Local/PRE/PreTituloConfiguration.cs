

namespace Ossmmasoft.RepositoryEFCore.Configurations.Local.PRE
{
    internal class PreTituloConfiguration : IEntityTypeConfiguration<PreTitulo>
    {
        public void Configure(EntityTypeBuilder<PreTitulo> builder)
        {
            builder.Property(e => e.Id).HasPrecision(10);

            builder.Property(e => e.TituloPadreId).HasPrecision(10);

            builder.Property(e => e.Codigo).HasMaxLength(10);

            builder.Property(e => e.CodigoEmpresa).HasPrecision(10);

            builder.Property(e => e.Complemento1).HasMaxLength(100);

            builder.Property(e => e.Complemento2).HasMaxLength(100);

            builder.Property(e => e.Complemento3).HasMaxLength(100);

            builder.Property(e => e.Titulo).HasMaxLength(100);

            builder.Property(e => e.UsuarioActualizacion).HasPrecision(10);

            builder.Property(e => e.UsuarioCreacion).HasPrecision(10);
        }
    }
}
