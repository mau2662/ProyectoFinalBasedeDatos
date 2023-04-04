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
    public class FacturasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FacturasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Facturas
        public async Task<IActionResult> Index()
        {
              return _context.FACTURA != null ? 
                          View(await _context.FACTURA.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.FACTURA'  is null.");
        }

        // GET: Facturas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.FACTURA == null)
            {
                return NotFound();
            }

            var fACTURA = await _context.FACTURA
                .FirstOrDefaultAsync(m => m.ID_FACTURA == id);
            if (fACTURA == null)
            {
                return NotFound();
            }

            return View(fACTURA);
        }

        // GET: Facturas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Facturas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID_FACTURA,NOMBRE,APELLIDO,CORREO,DIRECCION,TELEFONO,PRODUCTOS,TOTAL")] FACTURA fACTURA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fACTURA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fACTURA);
        }

        // GET: Facturas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.FACTURA == null)
            {
                return NotFound();
            }

            var fACTURA = await _context.FACTURA.FindAsync(id);
            if (fACTURA == null)
            {
                return NotFound();
            }
            return View(fACTURA);
        }

        // POST: Facturas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID_FACTURA,NOMBRE,APELLIDO,CORREO,DIRECCION,TELEFONO,PRODUCTOS,TOTAL")] FACTURA fACTURA)
        {
            if (id != fACTURA.ID_FACTURA)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fACTURA);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FACTURAExists(fACTURA.ID_FACTURA))
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
            return View(fACTURA);
        }

        // GET: Facturas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.FACTURA == null)
            {
                return NotFound();
            }

            var fACTURA = await _context.FACTURA
                .FirstOrDefaultAsync(m => m.ID_FACTURA == id);
            if (fACTURA == null)
            {
                return NotFound();
            }

            return View(fACTURA);
        }

        // POST: Facturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.FACTURA == null)
            {
                return Problem("Entity set 'ApplicationDbContext.FACTURA'  is null.");
            }
            var fACTURA = await _context.FACTURA.FindAsync(id);
            if (fACTURA != null)
            {
                _context.FACTURA.Remove(fACTURA);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FACTURAExists(int id)
        {
          return (_context.FACTURA?.Any(e => e.ID_FACTURA == id)).GetValueOrDefault();
        }
    }
}
