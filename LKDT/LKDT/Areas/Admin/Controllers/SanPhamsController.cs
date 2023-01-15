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
    public class SanPhamsController : Controller
    {
        private readonly LinhKienDienTuContext _context;
        public INotyfService _notyfService { get; }
        public SanPhamsController(LinhKienDienTuContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        // GET: Admin/SanPhams
        public IActionResult Index(int page = 1, int CatID = 0)
        {
            var pageNumber = page;
            var pageSize = 20;

            List<SanPham> lsProducts = new List<SanPham>();
            if (CatID != 0)
            {
                lsProducts = _context.SanPhams
                .AsNoTracking()
                .Where(x => x.MaDm == CatID)
                .Include(x => x.MaDmNavigation)
                .OrderBy(x => x.MaSp).ToList();
            }
            else
            {
                lsProducts = _context.SanPhams
                .AsNoTracking()
                .Include(x => x.MaDmNavigation)
                .OrderBy(x => x.MaSp).ToList();
            }

            PagedList<SanPham> models = new PagedList<SanPham>(lsProducts.AsQueryable(), pageNumber, pageSize);
            ViewBag.CurrentCateID = CatID;

            ViewBag.CurrentPage = pageNumber;
            ViewData["DanhMuc"] = new SelectList(_context.DanhMucs, "MaDm", "TenDm");

            return View(models);
        }
        public IActionResult Filtter(int CatID = 0)
        {
            var url = $"/Admin/SanPhams?CatID={CatID}";
            if (CatID == 0)
            {
                url = $"/Admin/SanPhams";
            }
            return Json(new { status = "success", redirectUrl = url });
        }

        // GET: Admin/SanPhams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPham = await _context.SanPhams
                .Include(s => s.MaDmNavigation)
                .FirstOrDefaultAsync(m => m.MaSp == id);
            if (sanPham == null)
            {
                return NotFound();
            }

            return View(sanPham);
        }

        // GET: Admin/SanPhams/Create
        public IActionResult Create()
        {
            ViewData["DanhMuc"] = new SelectList(_context.DanhMucs, "MaDm", "TenDm");
            return View();
        }

        // POST: Admin/SanPhams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaSp,TenSp,MotaNgan,MotaDai,MaDm,DonGia,Avatar,NgayTao,NgayChinhSua,TrangThai")] SanPham sanPham, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (ModelState.IsValid)
            {
                sanPham.TenSp = Utilities.ToTitleCase(sanPham.TenSp);
                if (fThumb != null)
                {
                    string extension = Path.GetExtension(fThumb.FileName);
                    string image = Utilities.SEOUrl(sanPham.TenSp) + extension;
                    sanPham.Avatar = await Utilities.UploadFile(fThumb, @"products", image.ToLower());
                }
                if (string.IsNullOrEmpty(sanPham.Avatar)) sanPham.Avatar = "default.jpg";
                sanPham.Url = Utilities.SEOUrl(sanPham.TenSp);
                sanPham.NgayChinhSua = DateTime.Now;
                sanPham.NgayTao = DateTime.Now;

                _context.Add(sanPham);
                await _context.SaveChangesAsync();
                _notyfService.Success("Thêm thành công");
                return RedirectToAction(nameof(Index));
            }
            ViewData["DanhMuc"] = new SelectList(_context.DanhMucs, "MaDm", "TenDm", sanPham.MaDm);
            return View(sanPham);
        }

        // GET: Admin/SanPhams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPham = await _context.SanPhams.FindAsync(id);
            if (sanPham == null)
            {
                return NotFound();
            }
            ViewData["DanhMuc"] = new SelectList(_context.DanhMucs, "MaDm", "TenDm", sanPham.MaDm);
            return View(sanPham);
        }

        // POST: Admin/SanPhams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaSp,TenSp,MotaNgan,MotaDai,MaDm,DonGia,Avatar,NgayTao,NgayChinhSua,TrangThai")] SanPham sanPham, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (id != sanPham.MaSp)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    sanPham.TenSp = Utilities.ToTitleCase(sanPham.TenSp);
                    if (fThumb != null)
                    {
                        string extension = Path.GetExtension(fThumb.FileName);
                        string image = Utilities.SEOUrl(sanPham.TenSp) + extension;
                        sanPham.Avatar = await Utilities.UploadFile(fThumb, @"products", image.ToLower());
                    }
                    if (string.IsNullOrEmpty(sanPham.Avatar)) sanPham.Avatar = "default.jpg";
                    sanPham.Url = Utilities.SEOUrl(sanPham.TenSp);
                    sanPham.NgayChinhSua = DateTime.Now;

                    _context.Update(sanPham);
                    await _context.SaveChangesAsync();
                    _notyfService.Success("Cập nhật thành công");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SanPhamExists(sanPham.MaSp))
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
            ViewData["DanhMuc"] = new SelectList(_context.DanhMucs, "MaDm", "TenDm", sanPham.MaDm);
            return View(sanPham);
        }

        // GET: Admin/SanPhams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPham = await _context.SanPhams
                .Include(s => s.MaDmNavigation)
                .FirstOrDefaultAsync(m => m.MaSp == id);
            if (sanPham == null)
            {
                return NotFound();
            }

            return View(sanPham);
        }

        // POST: Admin/SanPhams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sanPham = await _context.SanPhams.FindAsync(id);
            _context.SanPhams.Remove(sanPham);
            await _context.SaveChangesAsync();
            _notyfService.Success("Xóa sản phẩm thành công");
            return RedirectToAction(nameof(Index));
        }

        private bool SanPhamExists(int id)
        {
            return _context.SanPhams.Any(e => e.MaSp == id);
        }
    }
}
