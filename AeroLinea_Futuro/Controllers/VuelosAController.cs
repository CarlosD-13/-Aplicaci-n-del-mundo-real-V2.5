using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AeroLinea_Futuro.Models;

namespace AeroLinea_Futuro.Controllers
{
    public class VuelosAController : Controller
    {
        private readonly VuelosContext _context;

        public VuelosAController(VuelosContext context)
        {
            _context = context;
        }

        // GET: VuelosA
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vuelos.ToListAsync());
        }

        // GET: VuelosA/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vuelos = await _context.Vuelos
                .FirstOrDefaultAsync(m => m.Id_Vuelos == id);
            if (vuelos == null)
            {
                return NotFound();
            }

            return View(vuelos);
        }

        // GET: VuelosA/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VuelosA/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Vuelos,Escala,Tanda,Categoria,Fecha")] Vuelos vuelos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vuelos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vuelos);
        }

        // GET: VuelosA/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vuelos = await _context.Vuelos.FindAsync(id);
            if (vuelos == null)
            {
                return NotFound();
            }
            return View(vuelos);
        }

        // POST: VuelosA/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Vuelos,Escala,Tanda,Categoria,Fecha")] Vuelos vuelos)
        {
            if (id != vuelos.Id_Vuelos)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vuelos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VuelosExists(vuelos.Id_Vuelos))
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
            return View(vuelos);
        }

        // GET: VuelosA/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vuelos = await _context.Vuelos
                .FirstOrDefaultAsync(m => m.Id_Vuelos == id);
            if (vuelos == null)
            {
                return NotFound();
            }

            return View(vuelos);
        }

        // POST: VuelosA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vuelos = await _context.Vuelos.FindAsync(id);
            _context.Vuelos.Remove(vuelos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VuelosExists(int id)
        {
            return _context.Vuelos.Any(e => e.Id_Vuelos == id);
        }
    }
}
