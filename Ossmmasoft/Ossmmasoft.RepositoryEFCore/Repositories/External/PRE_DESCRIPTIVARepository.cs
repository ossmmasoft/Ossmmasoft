

using Ossmmasoft.Entities.External.Interfaces.PRE;
using Ossmmasoft.Entities.External.POCOs.PRE;

namespace Ossmmasoft.RepositoryEFCore.Repositories.External
{
    public class PRE_DESCRIPTIVARepository : IPRE_DESCRIPTIVARepository
    {
        readonly ExternalPreContext _context;

        public PRE_DESCRIPTIVARepository(ExternalPreContext context) =>
            _context = context;



        public IQueryable<PRE_DESCRIPTIVAS> GetAllPreDescriptivas()
        {
            try
            {
                var result = _context.PRE_DESCRIPTIVAS.AsQueryable();
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
