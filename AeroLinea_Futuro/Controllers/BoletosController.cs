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
    public class BoletosController : Controller
    {
        private readonly BoletosContext _context;

        public BoletosController(BoletosContext context)
        {
            _context = context;
        }

        // GET: Boletos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Boletos.ToListAsync());
        }

        // GET: Boletos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boletos = await _context.Boletos
                .FirstOrDefaultAsync(m => m.BoletosID == id);
            if (boletos == null)
            {
                return NotFound();
            }

            return View(boletos);
        }

        // GET: Boletos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Boletos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BoletosID,Nombre,Precio,Fecha,Reserva")] Boletos boletos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(boletos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(boletos);
        }

        // GET: Boletos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boletos = await _context.Boletos.FindAsync(id);
            if (boletos == null)
            {
                return NotFound();
            }
            return View(boletos);
        }

        // POST: Boletos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BoletosID,Nombre,Precio,Fecha,Reserva")] Boletos boletos)
        {
            if (id != boletos.BoletosID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(boletos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BoletosExists(boletos.BoletosID))
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
            return View(boletos);
        }

        // GET: Boletos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boletos = await _context.Boletos
                .FirstOrDefaultAsync(m => m.BoletosID == id);
            if (boletos == null)
            {
                return NotFound();
            }

            return View(boletos);
        }

        // POST: Boletos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var boletos = await _context.Boletos.FindAsync(id);
            _context.Boletos.Remove(boletos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BoletosExists(int id)
        {
            return _context.Boletos.Any(e => e.BoletosID == id);
        }
    }
}
