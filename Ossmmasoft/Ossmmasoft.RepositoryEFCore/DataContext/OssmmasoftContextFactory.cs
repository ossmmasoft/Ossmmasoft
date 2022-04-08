using Microsoft.EntityFrameworkCore.Design;

namespace Ossmmasoft.RepositoryEFCore.DataContext
{
    class OssmmasoftContextFactory :
        IDesignTimeDbContextFactory<OssmmasoftContext>
    {
        public OssmmasoftContext CreateDbContext(string[] args)
        {
            var OptionsBuilder =
                new DbContextOptionsBuilder<OssmmasoftContext>();
            OptionsBuilder.UseNpgsql("Server = localhost;Port=5444;Database=MM;User Id=postgres;Password=mvc4-2014;");
            return new OssmmasoftContext(OptionsBuilder.Options);
        }

        //add-migration InitialCreate -p Ossmmasoft.RepositoryEFCore -c OssmmasoftContext -o Migrations -s Ossmmasoft.RepositoryEFCore
        //update-database -p Ossmmasoft.RepositoryEFCore -Context OssmmasoftContext  -s Ossmmasoft.RepositoryEFCore

    }
}
