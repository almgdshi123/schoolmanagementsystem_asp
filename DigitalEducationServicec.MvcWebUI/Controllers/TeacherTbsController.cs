using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.MvcWebUI.Controllers
{
    public class TeacherTbsController : Controller
    {
        private readonly DigitalEducationServiceDbnContext _context;

        public TeacherTbsController(DigitalEducationServiceDbnContext context)
        {
            _context = context;
        }

        // GET: TeacherTbs
        public async Task<IActionResult> Index()
        {
            var digitalEducationServiceDbnContext = _context.TeacherTbs.Include(t => t.Qualification).Include(t => t.Specialization).Include(t => t.User);
            return View(await digitalEducationServiceDbnContext.ToListAsync());
        }

        // GET: TeacherTbs/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.TeacherTbs == null)
            {
                return NotFound();
            }

            var teacherTb = await _context.TeacherTbs
                .Include(t => t.Qualification)
                .Include(t => t.Specialization)
                .Include(t => t.User)
                .FirstOrDefaultAsync(m => m.TeacherId == id);
            if (teacherTb == null)
            {
                return NotFound();
            }

            return View(teacherTb);
        }

        // GET: TeacherTbs/Create
        public IActionResult Create()
        {
            ViewData["QualificationId"] = new SelectList(_context.QualificationTbs, "QualificationId", "QualificationId");
            ViewData["SpecializationId"] = new SelectList(_context.SpecializationTbs, "SpecializationId", "SpecializationId");
            ViewData["UserId"] = new SelectList(_context.UserDataTbs, "UserId", "UserId");
            return View();
        }

        // POST: TeacherTbs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TeacherId,TeacherName,Address,SpecializationId,QualificationId,UserId,Gender")] TeacherTb teacherTb)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teacherTb);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["QualificationId"] = new SelectList(_context.QualificationTbs, "QualificationId", "QualificationId", teacherTb.QualificationId);
            ViewData["SpecializationId"] = new SelectList(_context.SpecializationTbs, "SpecializationId", "SpecializationId", teacherTb.SpecializationId);
            ViewData["UserId"] = new SelectList(_context.UserDataTbs, "UserId", "UserId", teacherTb.UserId);
            return View(teacherTb);
        }

        // GET: TeacherTbs/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.TeacherTbs == null)
            {
                return NotFound();
            }

            var teacherTb = await _context.TeacherTbs.FindAsync(id);
            if (teacherTb == null)
            {
                return NotFound();
            }
            ViewData["QualificationId"] = new SelectList(_context.QualificationTbs, "QualificationId", "QualificationId", teacherTb.QualificationId);
            ViewData["SpecializationId"] = new SelectList(_context.SpecializationTbs, "SpecializationId", "SpecializationId", teacherTb.SpecializationId);
            ViewData["UserId"] = new SelectList(_context.UserDataTbs, "UserId", "UserId", teacherTb.UserId);
            return View(teacherTb);
        }

        // POST: TeacherTbs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("TeacherId,TeacherName,Address,SpecializationId,QualificationId,UserId,Gender")] TeacherTb teacherTb)
        {
            if (id != teacherTb.TeacherId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teacherTb);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeacherTbExists(teacherTb.TeacherId))
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
            ViewData["QualificationId"] = new SelectList(_context.QualificationTbs, "QualificationId", "QualificationId", teacherTb.QualificationId);
            ViewData["SpecializationId"] = new SelectList(_context.SpecializationTbs, "SpecializationId", "SpecializationId", teacherTb.SpecializationId);
            ViewData["UserId"] = new SelectList(_context.UserDataTbs, "UserId", "UserId", teacherTb.UserId);
            return View(teacherTb);
        }

        // GET: TeacherTbs/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.TeacherTbs == null)
            {
                return NotFound();
            }

            var teacherTb = await _context.TeacherTbs
                .Include(t => t.Qualification)
                .Include(t => t.Specialization)
                .Include(t => t.User)
                .FirstOrDefaultAsync(m => m.TeacherId == id);
            if (teacherTb == null)
            {
                return NotFound();
            }

            return View(teacherTb);
        }

        // POST: TeacherTbs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.TeacherTbs == null)
            {
                return Problem("Entity set 'DigitalEducationServiceDbnContext.TeacherTbs'  is null.");
            }
            var teacherTb = await _context.TeacherTbs.FindAsync(id);
            if (teacherTb != null)
            {
                _context.TeacherTbs.Remove(teacherTb);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeacherTbExists(long id)
        {
          return (_context.TeacherTbs?.Any(e => e.TeacherId == id)).GetValueOrDefault();
        }
    }
}
