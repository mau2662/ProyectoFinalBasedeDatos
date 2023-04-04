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
    public class AlmacenesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AlmacenesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Almacenes
        public async Task<IActionResult> Index()
        {
              return _context.ALMACEN != null ? 
                          View(await _context.ALMACEN.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.ALMACEN'  is null.");
        }

        // GET: Almacenes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ALMACEN == null)
            {
                return NotFound();
            }

            var aLMACEN = await _context.ALMACEN
                .FirstOrDefaultAsync(m => m.ID_ESTANTE == id);
            if (aLMACEN == null)
            {
                return NotFound();
            }

            return View(aLMACEN);
        }

        // GET: Almacenes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Almacenes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID_ESTANTE,NOMBRE_ESTANTE")] ALMACEN aLMACEN)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aLMACEN);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aLMACEN);
        }

        // GET: Almacenes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ALMACEN == null)
            {
                return NotFound();
            }

            var aLMACEN = await _context.ALMACEN.FindAsync(id);
            if (aLMACEN == null)
            {
                return NotFound();
            }
            return View(aLMACEN);
        }

        // POST: Almacenes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID_ESTANTE,NOMBRE_ESTANTE")] ALMACEN aLMACEN)
        {
            if (id != aLMACEN.ID_ESTANTE)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aLMACEN);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ALMACENExists(aLMACEN.ID_ESTANTE))
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
            return View(aLMACEN);
        }

        // GET: Almacenes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ALMACEN == null)
            {
                return NotFound();
            }

            var aLMACEN = await _context.ALMACEN
                .FirstOrDefaultAsync(m => m.ID_ESTANTE == id);
            if (aLMACEN == null)
            {
                return NotFound();
            }

            return View(aLMACEN);
        }

        // POST: Almacenes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ALMACEN == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ALMACEN'  is null.");
            }
            var aLMACEN = await _context.ALMACEN.FindAsync(id);
            if (aLMACEN != null)
            {
                _context.ALMACEN.Remove(aLMACEN);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ALMACENExists(int id)
        {
          return (_context.ALMACEN?.Any(e => e.ID_ESTANTE == id)).GetValueOrDefault();
        }
    }
}
