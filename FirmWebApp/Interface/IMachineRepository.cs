using FirmWebApp.Models;

namespace FirmWebApp.Interface
{
    public interface IMachineRepository
    {
        Task<IEnumerable<Machine>> GetAll();
        Task<Machine> GetByIdAsync(int id);
        bool Add(Machine machine);
        bool Update(Machine machine);
        bool Delete(Machine machine);
        bool Save();
        bool Exist(int id);
    }
}
