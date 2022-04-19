using Ossmmasoft.Entities.External.POCOs.PRE;

namespace Ossmmasoft.RepositoryEFCore.Configurations.External.PRE
{


    internal class PRE_TITULOConfiguration : IEntityTypeConfiguration<PRE_TITULOS>
    {
        public void Configure(EntityTypeBuilder<PRE_TITULOS> builder)
        {
            builder.HasNoKey();

        }
    }

}
