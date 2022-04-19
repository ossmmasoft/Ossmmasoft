

namespace Ossmmasoft.Entities.Local.Interfaces
{
    public interface IPreDescriptivaRepository
    {
        void CreatePreDescriptiva(PreDescriptiva preDescriptiva);
        void UpdatePreDescriptiva(PreDescriptiva preDescriptiva);
        void UpdateRangePreDescriptiva(List<PreDescriptiva> preDescriptiva);
        Task<PreDescriptiva> GetById(int id);
        Task DeletePreDescriptiva(int id);
        Task DeleteAllPreDescriptiva();
        IQueryable<PreDescriptiva> GetAllPreDescriptivas();
        Task<int> NextId();

    }
}
