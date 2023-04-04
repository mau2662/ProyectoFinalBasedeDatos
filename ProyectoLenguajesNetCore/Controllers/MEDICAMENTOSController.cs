using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoLenguajesNetCore.Data;
using ProyectoLenguajesNetCore.Models;

namespace ProyectoLenguajesNetCore.Controllers
{
    public class MEDICAMENTOSController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MEDICAMENTOSController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MEDICAMENTOS
        public async Task<IActionResult> Index()
        {
              return _context.MEDICAMENTO != null ? 
                          View(await _context.MEDICAMENTO.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.MEDICAMENTO'  is null.");
        }

        // GET: MEDICAMENTOS/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MEDICAMENTO == null)
            {
                return NotFound();
            }

            var mEDICAMENTO = await _context.MEDICAMENTO
                .FirstOrDefaultAsync(m => m.ID_MEDICAMENTO == id);
            if (mEDICAMENTO == null)
            {
                return NotFound();
            }

            return View(mEDICAMENTO);
        }

        // GET: MEDICAMENTOS/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MEDICAMENTOS/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID_MEDICAMENTO,NOMBRE,FARMACEUTICA,FECHA_INGRESO,FECHA_VENCIMIENTO")] MEDICAMENTO mEDICAMENTO)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mEDICAMENTO);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mEDICAMENTO);
        }

        // GET: MEDICAMENTOS/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MEDICAMENTO == null)
            {
                return NotFound();
            }

            var mEDICAMENTO = await _context.MEDICAMENTO.FindAsync(id);
            if (mEDICAMENTO == null)
            {
                return NotFound();
            }
            return View(mEDICAMENTO);
        }

        // POST: MEDICAMENTOS/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID_MEDICAMENTO,NOMBRE,FARMACEUTICA,FECHA_INGRESO,FECHA_VENCIMIENTO")] MEDICAMENTO mEDICAMENTO)
        {
            if (id != mEDICAMENTO.ID_MEDICAMENTO)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mEDICAMENTO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MEDICAMENTOExists(mEDICAMENTO.ID_MEDICAMENTO))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(mEDICAMENTO);
        }

        // GET: MEDICAMENTOS/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MEDICAMENTO == null)
            {
                return NotFound();
            }

            var mEDICAMENTO = await _context.MEDICAMENTO
                .FirstOrDefaultAsync(m => m.ID_MEDICAMENTO == id);
            if (mEDICAMENTO == null)
            {
                return NotFound();
            }

            return View(mEDICAMENTO);
        }

        // POST: MEDICAMENTOS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MEDICAMENTO == null)
            {
                return Problem("Entity set 'ApplicationDbContext.MEDICAMENTO'  is null.");
            }
            var mEDICAMENTO = await _context.MEDICAMENTO.FindAsync(id);
            if (mEDICAMENTO != null)
            {
                _context.MEDICAMENTO.Remove(mEDICAMENTO);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MEDICAMENTOExists(int id)
        {
          return (_context.MEDICAMENTO?.Any(e => e.ID_MEDICAMENTO == id)).GetValueOrDefault();
        }
    }
}
