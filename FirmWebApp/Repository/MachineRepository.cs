using FirmWebApp.Data;
using FirmWebApp.Interface;
using FirmWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FirmWebApp.Repository
{
    public class MachineRepository : IMachineRepository
    {
        private readonly ApplicationDbContext _context;

        public MachineRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Machine machine)
        {
            _context.Add(machine);
            return Save();
        }
        public bool Update(Machine machine)
        {
            _context.Update(machine);
            return Save();
        }
        public bool Delete(Machine machine)
        {
            _context.Remove(machine);
            return Save();
        }
        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
        public bool Exist(int id)
        {
            return _context.Machines.Any(e => e.Oid == id);
        }

        public async Task<IEnumerable<Machine>> GetAll()
        {
            return await _context.Machines.Include(layout => layout.Layout).ToListAsync();
        }

        public async Task<Machine> GetByIdAsync(int id)
        {
            return await _context.Machines.Include(layout => layout.Layout).FirstOrDefaultAsync(i => i.Oid == id);
        }

    }
}
