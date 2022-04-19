
namespace Ossmmasoft.Entities.Local.Interfaces
{
    public interface IPreTituloRepository
    {
        void CreatePreTitulo(PreTitulo preTitulo);
        void UpdatePreTitulo(PreTitulo preTitulo);
        void UpdateRangePreTitulo(List<PreTitulo> preTitulos);
        Task<PreTitulo> GetById(int id);
        Task DeletePreTitulo(int id);
        Task DeleteAllPreTitulo();
        IQueryable<PreTitulo> GetAllPreTitulos();
        Task<int> NextId();
    }
}
