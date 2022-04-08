namespace Ossmmasoft.RepositoryEFCore.Repositories.Local
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly OssmmasoftContext _context;

        public UnitOfWork(OssmmasoftContext context) =>
            _context = context;

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }


    }
}
