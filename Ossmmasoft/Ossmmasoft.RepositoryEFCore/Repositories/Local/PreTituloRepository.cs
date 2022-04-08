

namespace Ossmmasoft.RepositoryEFCore.Repositories.Local
{
    public class PreTituloRepository : IPreTituloRepository
    {
        readonly OssmmasoftContext _context;

        public PreTituloRepository(OssmmasoftContext context) =>
            _context = context;


        public void CreatePreTitulo(PreTitulo preTitulo)
        {
            _context.Add(preTitulo);
        }


        public IQueryable<PreTitulo> GetAllPreTitulos()
        {
            return _context.PreTitulos.AsQueryable();
        }

        public async Task<PreTitulo> GetById(int id)
        {
            return await _context.PreTitulos.FindAsync(id);
        }

        public void UpdatePreTitulo(PreTitulo preTitulo)
        {
            _context.Update(preTitulo);

        }

        public void UpdateRangePreTitulo(List<PreTitulo> preTitulos)
        {
            _context.UpdateRange(preTitulos);
        }
    }
}
