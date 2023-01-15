using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LKDT.Models;
using PagedList.Core;
using AspNetCoreHero.ToastNotification.Abstractions;
using LKDT.Helpper;
using System.IO;

namespace LKDT.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TinTucsController : Controller
    {
        private readonly LinhKienDienTuContext _context;
        public INotyfService _notyfService { get; }
        public TinTucsController(LinhKienDienTuContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        // GET: Admin/TinTucs
        public IActionResult Index(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 20;
            var lsTinTucs = _context.TinTucs
                .AsNoTracking()
                .OrderBy(x => x.MaTinTuc);
            PagedList<TinTuc> models = new PagedList<TinTuc>(lsTinTucs, pageNumber, pageSize);

            ViewBag.CurrentPage = pageNumber;
            return View(models);
        }

        //var linhKienDienTuContext = _context.TinTucs.Include(t => t.MaDmNavigation).Include(t => t.MaTkNavigation);
        // GET: Admin/TinTucs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinTuc = await _context.TinTucs
                .Include(t => t.MaDmNavigation)
                .Include(t => t.MaTkNavigation)
                .FirstOrDefaultAsync(m => m.MaTinTuc == id);
            if (tinTuc == null)
            {
                return NotFound();
            }

            return View(tinTuc);
        }

        // GET: Admin/TinTucs/Create
        public IActionResult Create()
        {
            ViewData["MaDm"] = new SelectList(_context.DanhMucs, "MaDm", "MaDm");
            ViewData["MaTk"] = new SelectList(_context.TaiKhoans, "MaTk", "MaTk");
            return View();
        }

        // POST: Admin/TinTucs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaTinTuc,TieuDe,NoiDung,Avatar,TrangThai,Url,NgayTao,TacGia,MaTk,MaDm,TinHot,LuotXem")] TinTuc tinTuc, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (ModelState.IsValid)
            {
                tinTuc.TieuDe = Utilities.ToTitleCase(tinTuc.TieuDe);
                if (fThumb != null)
                {
                    string extension = Path.GetExtension(fThumb.FileName);
                    string image = Utilities.SEOUrl(tinTuc.TieuDe) + extension;
                    tinTuc.Avatar = await Utilities.UploadFile(fThumb, @"news", image.ToLower());
                }
                if (string.IsNullOrEmpty(tinTuc.Avatar)) tinTuc.Avatar = "default.jpg";
                tinTuc.Url = Utilities.SEOUrl(tinTuc.TieuDe);
                tinTuc.NgayTao = DateTime.Now;

                _context.Add(tinTuc);
                await _context.SaveChangesAsync();
                _notyfService.Success("Thêm thành công");
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaDm"] = new SelectList(_context.DanhMucs, "MaDm", "MaDm", tinTuc.MaDm);
            ViewData["MaTk"] = new SelectList(_context.TaiKhoans, "MaTk", "MaTk", tinTuc.MaTk);
            return View(tinTuc);
        }

        // GET: Admin/TinTucs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinTuc = await _context.TinTucs.FindAsync(id);
            if (tinTuc == null)
            {
                return NotFound();
            }
            ViewData["MaDm"] = new SelectList(_context.DanhMucs, "MaDm", "MaDm", tinTuc.MaDm);
            ViewData["MaTk"] = new SelectList(_context.TaiKhoans, "MaTk", "MaTk", tinTuc.MaTk);
            return View(tinTuc);
        }

        // POST: Admin/TinTucs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaTinTuc,TieuDe,NoiDung,Avatar,TrangThai,Url,NgayTao,TacGia,MaTk,MaDm,TinHot,LuotXem")] TinTuc tinTuc, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (id != tinTuc.MaTinTuc)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    tinTuc.TieuDe = Utilities.ToTitleCase(tinTuc.TieuDe);
                    if (fThumb != null)
                    {
                        string extension = Path.GetExtension(fThumb.FileName);
                        string image = Utilities.SEOUrl(tinTuc.TieuDe) + extension;
                        tinTuc.Avatar = await Utilities.UploadFile(fThumb, @"news", image.ToLower());
                    }
                    if (string.IsNullOrEmpty(tinTuc.Avatar)) tinTuc.Avatar = "default.jpg";
                    tinTuc.Url = Utilities.SEOUrl(tinTuc.TieuDe);
                    tinTuc.NgayTao = DateTime.Now;

                    _context.Update(tinTuc);
                    await _context.SaveChangesAsync();
                    _notyfService.Success("Cập nhật thành công");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TinTucExists(tinTuc.MaTinTuc))
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
            ViewData["MaDm"] = new SelectList(_context.DanhMucs, "MaDm", "MaDm", tinTuc.MaDm);
            ViewData["MaTk"] = new SelectList(_context.TaiKhoans, "MaTk", "MaTk", tinTuc.MaTk);
            return View(tinTuc);
        }

        // GET: Admin/TinTucs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinTuc = await _context.TinTucs
                .Include(t => t.MaDmNavigation)
                .Include(t => t.MaTkNavigation)
                .FirstOrDefaultAsync(m => m.MaTinTuc == id);
            if (tinTuc == null)
            {
                return NotFound();
            }

            return View(tinTuc);
        }

        // POST: Admin/TinTucs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tinTuc = await _context.TinTucs.FindAsync(id);
            _context.TinTucs.Remove(tinTuc);
            await _context.SaveChangesAsync();
            _notyfService.Success("Xóa tin thành công");
            return RedirectToAction(nameof(Index));
        }

        private bool TinTucExists(int id)
        {
            return _context.TinTucs.Any(e => e.MaTinTuc == id);
        }
    }
}
