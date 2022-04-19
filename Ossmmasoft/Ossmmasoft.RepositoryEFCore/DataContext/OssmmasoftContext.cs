//add-migration InitialCreate -p Ossmmasoft.RepositoryEFCore -c OssmmasoftContext -o Migrations -s Ossmmasoft.RepositoryEFCore
//update - database - p Ossmmasoft.RepositoryEFCore - s Ossmmasoft.RepositoryEFCore


namespace Ossmmasoft.RepositoryEFCore.DataContext
{
    public class OssmmasoftContext : DbContext
    {
        public OssmmasoftContext(DbContextOptions<OssmmasoftContext> options) : base(options)
        {

        }

        public DbSet<PreTitulo> PreTitulos { get; set; }
        public DbSet<PreDescriptiva> PreDescriptiva { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
