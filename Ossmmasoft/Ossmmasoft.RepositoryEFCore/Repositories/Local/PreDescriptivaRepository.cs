

namespace Ossmmasoft.RepositoryEFCore.Repositories.Local
{
    public class PreDescriptivaRepository : IPreDescriptivaRepository
    {
        readonly OssmmasoftContext _context;

        public PreDescriptivaRepository(OssmmasoftContext context) =>
            _context = context;


        public void CreatePreDescriptiva(PreDescriptiva preDescriptiva)
        {
            _context.PreDescriptiva.Add(preDescriptiva);
        }


        public IQueryable<PreDescriptiva> GetAllPreDescriptivas()
        {
            return _context.PreDescriptiva.AsQueryable();
        }

        public async Task<PreDescriptiva> GetById(int id)
        {
            var result = await _context.PreDescriptiva.Where(p => p.Id == id).FirstOrDefaultAsync();

            return result;

        }

        public void UpdatePreDescriptiva(PreDescriptiva preDescriptiva)
        {
            _context.PreDescriptiva.Update(preDescriptiva);

        }


        public void UpdateRangePreDescriptiva(List<PreDescriptiva> preDescriptivas)
        {
            _context.PreDescriptiva.UpdateRange(preDescriptivas);
        }

        public async Task DeletePreDescriptiva(int id)
        {
            var preDescriptiva = await GetById(id);
            _context.PreDescriptiva.Remove(preDescriptiva);

        }
        public async Task DeleteAllPreDescriptiva()
        {
            var preDescriptiva = await _context.PreDescriptiva.ToListAsync();
            _context.PreDescriptiva.RemoveRange(preDescriptiva);

        }

        public async Task<int> NextId()
        {
            int nextId = 0;
            var last = await _context.PreDescriptiva.OrderByDescending(d => d.Id).FirstOrDefaultAsync();
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
