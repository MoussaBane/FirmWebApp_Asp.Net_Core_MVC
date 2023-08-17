using FirmWebApp.Data;
using FirmWebApp.Interface;
using FirmWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirmWebApp.Controllers
{
    public class MachineController : Controller
    {
        private ApplicationDbContext _context;
        private IMachineRepository _machineRepository;

        public MachineController(ApplicationDbContext context, IMachineRepository machineRepository)
        {
            _context = context;
            _machineRepository = machineRepository;
        }

        public IActionResult Index()
        {
            var viewModel = new MachineLayoutViewModel
            {
                MachineModel = new Machine(),
                ListOfMachines = _context.Machines.Include(l => l.Layout).ToList(),
                ListOfLayouts = _context.Layouts.ToList()
            };

            /*List<Machine> machines = _context.Machines.Include(l => l.Layout).ToList();*/

            return View(viewModel);
        }

        // For adding a new Layout
        public IActionResult CreateModal()
        {
            var viewModel = new MachineLayoutViewModel
            {
                MachineModel = new Machine(),
                ListOfLayouts = _context.Layouts.ToList()
            };


            return PartialView(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateModal(MachineLayoutViewModel viewModel)
        {

            if (viewModel.MachineModel == null)
            {
                viewModel.ListOfLayouts = _context.Layouts.ToList();
                return PartialView(viewModel);

            }
            _machineRepository.Add(viewModel.MachineModel);
            return RedirectToAction(nameof(Index));


            /* if (ModelState.IsValid)
             {
                 *//*_context.Add(layout);
                 await _context.SaveChangesAsync();*//*

                 _machineRepository.Add(viewModel.MachineModel);
                 return RedirectToAction(nameof(Index));
             }
             viewModel.ListOfLayouts = _context.Layouts.ToList();
             return PartialView(viewModel);*/

        }

        // For delete action
        public async Task<IActionResult> DeleteModal(int id)
        {
            /*var layout = await _context.Layouts.FindAsync(id);*/
            Machine machine = await _machineRepository.GetByIdAsync(id);
            if (machine == null)
            {
                return NotFound();
            }

            //return PartialView("Delete", layout);
            return PartialView(machine.Oid);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Machine machine = await _machineRepository.GetByIdAsync(id);
            _machineRepository.Delete(machine);
            return RedirectToAction(nameof(Index));
        }

        // For editing a layout
        public async Task<IActionResult> EditModal(int id)
        {
            MachineLayoutViewModel viewModel = new MachineLayoutViewModel
            {
                MachineModel = await _machineRepository.GetByIdAsync(id),
                ListOfLayouts = _context.Layouts.ToList(),
                ListOfMachines = _context.Machines.ToList()
            };
            /*Machine machine = await _machineRepository.GetByIdAsync(id);*/
            if (viewModel.MachineModel == null)
            {
                return NotFound();
            }
            return PartialView(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditModal(int id, MachineLayoutViewModel viewModel)
        {
            if (viewModel.MachineModel == null)
            {
                return NotFound();
            }

            if (viewModel.MachineModel.Oid == id) // Vérification de l'égalité entre layout.Oid et id
            {
                /*if (ModelState.IsValid)*/
                if (viewModel.MachineModel != null)
                {
                    _context.Update(viewModel.MachineModel);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            else
            {
                return NotFound(); // Id et layout.Oid ne sont pas égaux
            }

            return PartialView(viewModel);
        }

        // For showing a new Layout
        public async Task<IActionResult> ShowModal(int id)
        {
            MachineLayoutViewModel viewModel = new MachineLayoutViewModel
            {
                MachineModel = await _machineRepository.GetByIdAsync(id),
                ListOfLayouts = _context.Layouts.ToList(),
                ListOfMachines = _context.Machines.ToList()
            };
            /*Machine machine = await _machineRepository.GetByIdAsync(id);*/
            if (viewModel.MachineModel == null)
            {
                return NotFound();
            }
            return PartialView(viewModel);
        }
    }
}
