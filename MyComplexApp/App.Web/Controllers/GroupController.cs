using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using App.Data.Context;
using App.Data.Domain.DomainModels.Concrete;

namespace App.Web.Controllers
{
    public class GroupController : Controller
    {
        private readonly MyAppContext _context;

        public GroupController(MyAppContext context)
        {
            _context = context;
        }

        // GET: Group
        public async Task<IActionResult> Index()
        {
            return View(await _context.Groups.ToListAsync());
        }

        // GET: Group/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @group = await _context.Groups
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@group == null)
            {
                return NotFound();
            }

            return View(@group);
        }

        // GET: Group/Create
        public IActionResult AddOrEdit(int id=0)
        {
            if (id == 0)
                return View(new Group());
            else
                return View(_context.Groups.Find(id));
        }

        // POST: Group/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("Name,StartDate,Id")] Group @group)
        {
            if (ModelState.IsValid)
            {
                if (group.Id == 0)
                    _context.Add(group);
                else
                    _context.Update(group);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@group);
        }

        // GET: Group/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @group = await _context.Groups
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@group == null)
            {
                return NotFound();
            }

            return View(@group);
        }

        // POST: Group/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var @group = await _context.Groups.FindAsync(id);
            _context.Groups.Remove(@group);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GroupExists(long id)
        {
            return _context.Groups.Any(e => e.Id == id);
        }
    }
}
