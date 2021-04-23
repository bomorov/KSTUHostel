using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebUI.Data;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class CoateRecordsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CoateRecordsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CoateRecords
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CoateRecord.Include(c => c.Parent);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CoateRecords/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coateRecord = await _context.CoateRecord
                .Include(c => c.Parent)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (coateRecord == null)
            {
                return NotFound();
            }

            return View(coateRecord);
        }

        // GET: CoateRecords/Create
        public IActionResult Create()
        {
            ViewData["ParentId"] = new SelectList(_context.CoateRecord, "Id", "Id");
            return View();
        }

        // POST: CoateRecords/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Code,CoateType,ParentId,Order,CreatedBy,Created,LastModifiedBy,LastModified,Id")] CoateRecord coateRecord)
        {
            if (ModelState.IsValid)
            {
                _context.Add(coateRecord);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ParentId"] = new SelectList(_context.CoateRecord, "Id", "Id", coateRecord.ParentId);
            return View(coateRecord);
        }

        // GET: CoateRecords/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coateRecord = await _context.CoateRecord.FindAsync(id);
            if (coateRecord == null)
            {
                return NotFound();
            }
            ViewData["ParentId"] = new SelectList(_context.CoateRecord, "Id", "Id", coateRecord.ParentId);
            return View(coateRecord);
        }

        // POST: CoateRecords/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Code,CoateType,ParentId,Order,CreatedBy,Created,LastModifiedBy,LastModified,Id")] CoateRecord coateRecord)
        {
            if (id != coateRecord.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(coateRecord);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoateRecordExists(coateRecord.Id))
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
            ViewData["ParentId"] = new SelectList(_context.CoateRecord, "Id", "Id", coateRecord.ParentId);
            return View(coateRecord);
        }

        // GET: CoateRecords/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coateRecord = await _context.CoateRecord
                .Include(c => c.Parent)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (coateRecord == null)
            {
                return NotFound();
            }

            return View(coateRecord);
        }

        // POST: CoateRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var coateRecord = await _context.CoateRecord.FindAsync(id);
            _context.CoateRecord.Remove(coateRecord);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CoateRecordExists(int id)
        {
            return _context.CoateRecord.Any(e => e.Id == id);
        }
    }
}
