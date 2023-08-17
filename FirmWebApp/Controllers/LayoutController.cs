using FirmWebApp.Data;
using FirmWebApp.Interface;
using FirmWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirmWebApp.Controllers
{
    public class LayoutController : Controller
    {
        private ApplicationDbContext _context;

        private readonly ILayoutRepository _layoutRepository;
        public LayoutController(ILayoutRepository layoutRepository, ApplicationDbContext context)
        {
            _layoutRepository = layoutRepository;
            _context = context;
        }

        // For The index page of the layout
        public IActionResult Index()
        {
            List<Layout> layouts = _context.Layouts.ToList();
            /*IEnumerable<Layout> layouts = await _layoutRepository.GetAll();*/
            return View(layouts);
        }

        // For adding a new Layout
        public IActionResult CreateModal()
        {
            //return PartialView("CreateEdit", new Layout());
            return PartialView(new Layout());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateModal(Layout layout)
        {
            if (ModelState.IsValid)
            {
                /*_context.Add(layout);
                await _context.SaveChangesAsync();*/
                _layoutRepository.Add(layout);
                return RedirectToAction(nameof(Index));
            }
            //return PartialView("CreateEdit", layout);
            return PartialView(layout);
        }

        // For editing a layout
        public async Task<IActionResult> EditModal(int id)
        {
            //var layout = await _context.Layouts.FindAsync(id);
            Layout layout = await _layoutRepository.GetByIdAsync(id);
            if (layout == null)
            {
                return NotFound();
            }
            //return PartialView("CreateEdit", layout);
            return PartialView(layout);
        }
        private bool LayoutExists(int id)
        {
            //return _context.Layouts.Any(e => e.Oid == id);
            return _layoutRepository.Exist(id);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditModal(int id, Layout layout)
        {
            if (layout == null)
            {
                return NotFound();
            }

            if (layout.Oid == id) // Vérification de l'égalité entre layout.Oid et id
            {
                if (ModelState.IsValid)
                {
                    _context.Update(layout);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            else
            {
                return NotFound(); // Id et layout.Oid ne sont pas égaux
            }

            return PartialView(layout);
        }


        // For delete action
        public async Task<IActionResult> DeleteModal(int id)
        {
            /*var layout = await _context.Layouts.FindAsync(id);*/
            Layout layout = await _layoutRepository.GetByIdAsync(id);
            if (layout == null)
            {
                return NotFound();
            }

            //return PartialView("Delete", layout);
            return PartialView(layout.Oid);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            /*var layout = await _context.Layouts.FindAsync(id);
            _context.Layouts.Remove(layout);
            await _context.SaveChangesAsync();*/
            Layout layout = await _layoutRepository.GetByIdAsync(id);
            _layoutRepository.Delete(layout);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Cancel()
        {
            return RedirectToAction(nameof(Index));
        }


    }
}
