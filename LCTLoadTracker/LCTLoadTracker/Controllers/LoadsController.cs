using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LCTLoadTracker.Data;
using LCTLoadTracker.Models;

namespace LCTLoadTracker.Controllers
{
    public class LoadsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoadsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Loads
        public async Task<IActionResult> Index()
        {
              return _context.Loads != null ? 
                          View(await _context.Loads.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Loads'  is null.");
        }

        // GET: Loads/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Loads == null)
            {
                return NotFound();
            }

            var load = await _context.Loads
                .FirstOrDefaultAsync(m => m.LoadID == id);
            if (load == null)
            {
                return NotFound();
            }

            return View(load);
        }

        // GET: Loads/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Loads/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LoadID,Driver,Date,LoadCount,BOL,TerminalLoaded,CustomerUnloaded,Product1,Gallons1,Product2,Gallons2,Product3,Gallons3,Product4,Gallons4,Product5,Gallons5,Split,Pump,Comment")] Load load)
        {
            if (ModelState.IsValid)
            {
                load.LoadID = Guid.NewGuid();
                _context.Add(load);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(load);
        }

        // GET: Loads/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Loads == null)
            {
                return NotFound();
            }

            var load = await _context.Loads.FindAsync(id);
            if (load == null)
            {
                return NotFound();
            }
            return View(load);
        }

        // POST: Loads/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("LoadID,Driver,Date,LoadCount,BOL,TerminalLoaded,CustomerUnloaded,Product1,Gallons1,Product2,Gallons2,Product3,Gallons3,Product4,Gallons4,Product5,Gallons5,Split,Pump,Comment")] Load load)
        {
            if (id != load.LoadID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(load);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoadExists(load.LoadID))
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
            return View(load);
        }

        // GET: Loads/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Loads == null)
            {
                return NotFound();
            }

            var load = await _context.Loads
                .FirstOrDefaultAsync(m => m.LoadID == id);
            if (load == null)
            {
                return NotFound();
            }

            return View(load);
        }

        // POST: Loads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Loads == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Loads'  is null.");
            }
            var load = await _context.Loads.FindAsync(id);
            if (load != null)
            {
                _context.Loads.Remove(load);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoadExists(Guid id)
        {
          return (_context.Loads?.Any(e => e.LoadID == id)).GetValueOrDefault();
        }
    }
}
