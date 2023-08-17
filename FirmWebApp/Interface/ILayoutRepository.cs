using FirmWebApp.Models;

namespace FirmWebApp.Interface
{
    public interface ILayoutRepository
    {
        Task<IEnumerable<Layout>> GetAll();
        Task<Layout> GetByIdAsync(int id);
        bool Add(Layout layout);
        bool Update(Layout layout);
        bool Delete(Layout layout);
        bool Save();
        bool Exist(int id);
    }
}
