using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DBATool.Data;
using DBATool.Data.Models;

namespace DBAToolV2.Controllers
{
    public class DatabasesController : Controller
    {
        private readonly DBAToolDbContext _context;

        public DatabasesController(DBAToolDbContext context)
        {
            _context = context;
        }

        // GET: Databases
        public async Task<IActionResult> Index()
        {
            return View(await _context.Databases.ToListAsync());
        }

        // GET: Databases/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var database = await _context.Databases
                .FirstOrDefaultAsync(m => m.Id == id);
            if (database == null)
            {
                return NotFound();
            }

            return View(database);
        }

        // GET: Databases/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Databases/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Size,NumberOfUsers")] Database database)
        {
            if (ModelState.IsValid)
            {
                _context.Add(database);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(database);
        }

        // GET: Databases/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var database = await _context.Databases.FindAsync(id);
            if (database == null)
            {
                return NotFound();
            }
            return View(database);
        }

        // POST: Databases/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Size,NumberOfUsers")] Database database)
        {
            if (id != database.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(database);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DatabaseExists(database.Id))
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
            return View(database);
        }

        // GET: Databases/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var database = await _context.Databases
                .FirstOrDefaultAsync(m => m.Id == id);
            if (database == null)
            {
                return NotFound();
            }

            return View(database);
        }

        // POST: Databases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var database = await _context.Databases.FindAsync(id);
            _context.Databases.Remove(database);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DatabaseExists(int id)
        {
            return _context.Databases.Any(e => e.Id == id);
        }
    }
}
