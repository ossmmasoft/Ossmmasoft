

using Ossmmasoft.Entities.External.Interfaces.PRE;
using Ossmmasoft.Entities.External.POCOs.PRE;

namespace Ossmmasoft.RepositoryEFCore.Repositories.External
{
    public class PRE_TITULOSRepository : IPRE_TITULOSRepository
    {
        readonly ExternalPreContext _context;

        public PRE_TITULOSRepository(ExternalPreContext context) =>
            _context = context;




        IQueryable<PRE_TITULOS> IPRE_TITULOSRepository.GetAllPreTitulos()
        {
            try
            {
                var result = _context.PRE_TITULOS.AsQueryable();
                return result;
            }
            catch (Exception ex)
            {
                return null;
                throw;
            }

        }
    }
}
