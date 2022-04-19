using Ossmmasoft.Entities.External.POCOs.PRE;

namespace Ossmmasoft.Entities.External.Interfaces.PRE
{
    public interface IPRE_DESCRIPTIVARepository
    {

        IQueryable<PRE_DESCRIPTIVAS> GetAllPreDescriptivas();
    }
}
