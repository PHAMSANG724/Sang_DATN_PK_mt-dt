using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LKDT.Models;
using AspNetCoreHero.ToastNotification.Abstractions;

namespace LKDT.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PhanQuyensController : Controller
    {
        private readonly LinhKienDienTuContext _context;
        public INotyfService _notyfService { get; }
        public PhanQuyensController(LinhKienDienTuContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }
        // GET: Admin/PhanQuyens
        public async Task<IActionResult> Index()
        {
            return View(await _context.PhanQuyens.ToListAsync());
        }

        // GET: Admin/PhanQuyens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phanQuyen = await _context.PhanQuyens
                .FirstOrDefaultAsync(m => m.MaQuyen == id);
            if (phanQuyen == null)
            {
                return NotFound();
            }

            return View(phanQuyen);
        }

        // GET: Admin/PhanQuyens/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/PhanQuyens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaQuyen,TenQuyen,MoTa")] PhanQuyen phanQuyen)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phanQuyen);
                await _context.SaveChangesAsync();
                _notyfService.Success("Tạo mới thành công");
                return RedirectToAction(nameof(Index));
            }
            return View(phanQuyen);
        }

        // GET: Admin/PhanQuyens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phanQuyen = await _context.PhanQuyens.FindAsync(id);
            if (phanQuyen == null)
            {
                return NotFound();
            }
            return View(phanQuyen);
        }

        // POST: Admin/PhanQuyens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaQuyen,TenQuyen,MoTa")] PhanQuyen phanQuyen)
        {
            if (id != phanQuyen.MaQuyen)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phanQuyen);
                    await _context.SaveChangesAsync();
                    _notyfService.Success("Cập nhật thành công");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhanQuyenExists(phanQuyen.MaQuyen))
                    {
                        _notyfService.Success("Có lỗi xảy ra");
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(phanQuyen);
        }

        // GET: Admin/PhanQuyens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phanQuyen = await _context.PhanQuyens
                .FirstOrDefaultAsync(m => m.MaQuyen == id);
            if (phanQuyen == null)
            {
                return NotFound();
            }

            return View(phanQuyen);
        }

        // POST: Admin/PhanQuyens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phanQuyen = await _context.PhanQuyens.FindAsync(id);
            _context.PhanQuyens.Remove(phanQuyen);
            await _context.SaveChangesAsync();
            _notyfService.Success("Xóa quyền truy cập thành công");
            return RedirectToAction(nameof(Index));
        }

        private bool PhanQuyenExists(int id)
        {
            return _context.PhanQuyens.Any(e => e.MaQuyen == id);
        }
    }
}
