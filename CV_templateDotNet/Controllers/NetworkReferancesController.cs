using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CV_templateDotNet.Data;
using CV_templateDotNet.Models;

namespace CV_templateDotNet.Controllers
{
    public class NetworkReferancesController : Controller
    {
        private readonly CVtemplateDotNetContext _context;

        public NetworkReferancesController(CVtemplateDotNetContext context)
        {
            _context = context;
        }

        // GET: NetworkReferances
        public async Task<IActionResult> Index()
        {
              return _context.NetworkReferances != null ? 
                          View(await _context.NetworkReferances.ToListAsync()) :
                          Problem("Entity set 'CVtemplateDotNetContext.NetworkReferances'  is null.");
        }

        // GET: NetworkReferances/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.NetworkReferances == null)
            {
                return NotFound();
            }

            var networkReferances = await _context.NetworkReferances
                .FirstOrDefaultAsync(m => m.Id == id);
            if (networkReferances == null)
            {
                return NotFound();
            }

            return View(networkReferances);
        }

        // GET: NetworkReferances/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NetworkReferances/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Name,PhoneNumber,Email")] NetworkReferances networkReferances)
        {
            if (ModelState.IsValid)
            {
                _context.Add(networkReferances);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(networkReferances);
        }

        // GET: NetworkReferances/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.NetworkReferances == null)
            {
                return NotFound();
            }

            var networkReferances = await _context.NetworkReferances.FindAsync(id);
            if (networkReferances == null)
            {
                return NotFound();
            }
            return View(networkReferances);
        }

        // POST: NetworkReferances/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Name,PhoneNumber,Email")] NetworkReferances networkReferances)
        {
            if (id != networkReferances.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(networkReferances);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NetworkReferancesExists(networkReferances.Id))
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
            return View(networkReferances);
        }

        // GET: NetworkReferances/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.NetworkReferances == null)
            {
                return NotFound();
            }

            var networkReferances = await _context.NetworkReferances
                .FirstOrDefaultAsync(m => m.Id == id);
            if (networkReferances == null)
            {
                return NotFound();
            }

            return View(networkReferances);
        }

        // POST: NetworkReferances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.NetworkReferances == null)
            {
                return Problem("Entity set 'CVtemplateDotNetContext.NetworkReferances'  is null.");
            }
            var networkReferances = await _context.NetworkReferances.FindAsync(id);
            if (networkReferances != null)
            {
                _context.NetworkReferances.Remove(networkReferances);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NetworkReferancesExists(int id)
        {
          return (_context.NetworkReferances?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
