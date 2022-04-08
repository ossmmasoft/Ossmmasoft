namespace Ossmmasoft.Entities.Local.Interfaces
{
    public interface IUnitOfWork
    {

        Task<int> SaveChangesAsync();

    }
}
