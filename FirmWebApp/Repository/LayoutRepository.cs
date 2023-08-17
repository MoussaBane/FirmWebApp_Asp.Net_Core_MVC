using FirmWebApp.Data;
using FirmWebApp.Interface;
using FirmWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FirmWebApp.Repository
{
    public class LayoutRepository : ILayoutRepository
    {
        private readonly ApplicationDbContext _context;

        public LayoutRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Layout layout)
        {
            //throw new NotImplementedException();
            _context.Add(layout);
            return Save();
        }

        public bool Delete(Layout layout)
        {
            //throw new NotImplementedException();
            _context.Remove(layout);
            return Save();
        }

        public async Task<IEnumerable<Layout>> GetAll()
        {
            //throw new NotImplementedException();
            return await _context.Layouts.ToListAsync();
        }

        public async Task<Layout> GetByIdAsync(int id)
        {
            //throw new NotImplementedException();
            return await _context.Layouts.FirstOrDefaultAsync(i => i.Oid == id);
        }

        public bool Save()
        {
            //throw new NotImplementedException();
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Layout layout)
        {
            //throw new NotImplementedException();
            _context.Update(layout);
            return Save();
        }

        public bool Exist(int id)
        {
            return _context.Layouts.Any(e => e.Oid == id);
        }
    }
}
