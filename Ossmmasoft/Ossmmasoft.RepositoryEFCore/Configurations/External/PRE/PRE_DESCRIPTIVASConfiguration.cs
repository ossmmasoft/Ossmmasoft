using Ossmmasoft.Entities.External.POCOs.PRE;

namespace Ossmmasoft.RepositoryEFCore.Configurations.External.PRE
{

    internal class PRE_DESCRIPTIVASConfiguration : IEntityTypeConfiguration<PRE_DESCRIPTIVAS>
    {
        public void Configure(EntityTypeBuilder<PRE_DESCRIPTIVAS> builder)
        {
            builder.HasNoKey();

        }
    }

}
