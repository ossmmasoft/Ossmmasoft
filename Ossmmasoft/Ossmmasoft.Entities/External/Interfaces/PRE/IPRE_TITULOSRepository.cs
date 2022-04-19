using Ossmmasoft.Entities.External.POCOs.PRE;

namespace Ossmmasoft.Entities.External.Interfaces.PRE
{
    public interface IPRE_TITULOSRepository
    {

        IQueryable<PRE_TITULOS> GetAllPreTitulos();
    }
}
