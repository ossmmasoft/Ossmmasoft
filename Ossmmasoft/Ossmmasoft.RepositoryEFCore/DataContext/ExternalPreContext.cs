using Ossmmasoft.Entities.External.POCOs.PRE;

namespace Ossmmasoft.RepositoryEFCore.DataContext
{
    public class ExternalPreContext : DbContext
    {

        public ExternalPreContext(DbContextOptions<ExternalPreContext> options) : base(options)
        {

        }

        public DbSet<PRE_TITULOS> PRE_TITULOS { get; set; }
        public DbSet<PRE_DESCRIPTIVAS> PRE_DESCRIPTIVAS { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            /*base.OnModelCreating(modelBuilder);

            modelBuilder
            .Entity<PRE_TITULOS>(builder =>
            {
                builder.HasNoKey();
                builder.ToTable("PRE_TITULOS");
            });*/


        }
    }
}
