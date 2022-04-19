

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
            var result = await _context.PreTitulos.Where(p => p.Id == id).FirstOrDefaultAsync();

            return result;

        }

        public void UpdatePreTitulo(PreTitulo preTitulo)
        {
            _context.PreTitulos.Update(preTitulo);

        }


        public void UpdateRangePreTitulo(List<PreTitulo> preTitulos)
        {
            _context.PreTitulos.UpdateRange(preTitulos);
        }

        public async Task DeletePreTitulo(int id)
        {
            var preTitulo = await GetById(id);
            _context.PreTitulos.Remove(preTitulo);

        }
        public async Task DeleteAllPreTitulo()
        {
            var preTitulo = await _context.PreTitulos.ToListAsync();
            _context.PreTitulos.RemoveRange(preTitulo);

        }

        public async Task<int> NextId()
        {
            int nextId = 0;
            var last = await _context.PreTitulos.OrderByDescending(d => d.Id).FirstOrDefaultAsync();
            if (last != null)
            {
                nextId = last.Id + 1;
            }
            else
            {
                nextId = 1;

            }
            return nextId;
        }
    }
}
