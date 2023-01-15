using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LKDT.Models;
using AspNetCoreHero.ToastNotification.Abstractions;
using PagedList.Core;

namespace LKDT.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DonHangsController : Controller
    {
        private readonly LinhKienDienTuContext _context;
        public INotyfService _notyfService { get; }
        public DonHangsController(LinhKienDienTuContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        // GET: Admin/DonHangs
        public IActionResult Index(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 20;
            var Orders = _context.DonHangs.Include(o => o.MaKhNavigation).Include(o => o.MaTrangThaiNavigation)
                .AsNoTracking()
                .OrderBy(x => x.NgayMua);
            PagedList<DonHang> models = new PagedList<DonHang>(Orders, pageNumber, pageSize);

            ViewBag.CurrentPage = pageNumber;



            return View(models);
        }

        // GET: Admin/DonHangs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donHang = await _context.DonHangs
                .Include(d => d.MaKhNavigation)
                .Include(d => d.MaShipperNavigation)
                .Include(d => d.MaTrangThaiNavigation)
                .FirstOrDefaultAsync(m => m.MaDh == id);
            if (donHang == null)
            {
                return NotFound();
            }
            var Chitietdonhang = _context.ChiTietDonHangs
                .Include(x => x.MaSpNavigation)
                .AsNoTracking()
                .Where(x => x.MaDh == donHang.MaDh)
                .OrderBy(x => x.MaCtdh)
                .ToList();
            ViewBag.ChiTiet = Chitietdonhang;
            return View(donHang);
        }
        public async Task<IActionResult> ChangeStatus(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.DonHangs
                .AsNoTracking()
                .Include(x => x.MaKhNavigation)
                .Include(x => x.MaShipperNavigation)
                .Include(x => x.MaTrangThaiNavigation)
                .FirstOrDefaultAsync(x => x.MaDh == id);
            if (order == null)
            {
                return NotFound();
            }
            ViewData["Trangthai"] = new SelectList(_context.TrangThaiDonHangs, "MaTrangThai", "TenTrangThai", order.MaTrangThai);
            ViewData["Shipper"] = new SelectList(_context.Shippers, "MaShipper", "TenShipper", order.MaShipper);
            return PartialView("ChangeStatus", order);
        }
        [HttpPost]
        public async Task<IActionResult> ChangeStatus(int id, [Bind("MaDh,MaKh,NgayMua,NgayGiao,MaTrangThai,ThanhToan,NgayThanhToan,GhiChu,MaShipper,DiaChi,TongTien,DiachiGiaoHang")] DonHang donHang)
        {
            if (id != donHang.MaDh)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    var donhang = await _context.DonHangs.AsNoTracking().Include(x => x.MaKhNavigation).FirstOrDefaultAsync(x => x.MaDh == id);
                    if (donhang != null)
                    {
                        donhang.MaShipper = donhang.MaShipper;
                        donhang.MaTrangThai = donHang.MaTrangThai;
                        if (donhang.MaTrangThai == 4) donhang.NgayGiao = DateTime.Now;
                    }
                    _context.Update(donhang);
                    await _context.SaveChangesAsync();
                    _notyfService.Success("Cập nhật đơn hàng thành công");

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DonHangExists(donHang.MaDh))
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
            ViewData["Trangthai"] = new SelectList(_context.TrangThaiDonHangs, "MaTrangThai", "TenTrangThai", donHang.MaTrangThai);
            ViewData["Shipper"] = new SelectList(_context.Shippers, "MaShipper", "TenShipper", donHang.MaShipper);
            return PartialView("ChangeStatus", donHang);
        }

        // GET: Admin/DonHangs/Create
        public IActionResult Create()
        {
            ViewData["MaKh"] = new SelectList(_context.KhachHangs, "MaKh", "HoTen");
            ViewData["MaShipper"] = new SelectList(_context.Shippers, "MaShipper", "TenShipper");
            ViewData["MaTrangThai"] = new SelectList(_context.TrangThaiDonHangs, "MaTrangThai", "TenTrangThai");
            return View();
        }

        // POST: Admin/DonHangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaDh,MaKh,NgayMua,NgayGiao,MaTrangThai,ThanhToan,NgayThanhToan,GhiChu,MaShipper,DiaChi,TongTien,DiachiGiaoHang")] DonHang donHang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(donHang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaKh"] = new SelectList(_context.KhachHangs, "MaKh", "HoTen", donHang.MaKh);
            ViewData["MaShipper"] = new SelectList(_context.Shippers, "MaShipper", "TenShipper", donHang.MaShipper);
            ViewData["MaTrangThai"] = new SelectList(_context.TrangThaiDonHangs, "MaTrangThai", "TenTrangThai", donHang.MaTrangThai);
            return View(donHang);
        }

        // GET: Admin/DonHangs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donHang = await _context.DonHangs.FindAsync(id);
            if (donHang == null)
            {
                return NotFound();
            }
            ViewData["MaKh"] = new SelectList(_context.KhachHangs, "MaKh", "HoTen", donHang.MaKh);
            ViewData["MaShipper"] = new SelectList(_context.Shippers, "MaShipper", "TenShipper", donHang.MaShipper);
            ViewData["MaTrangThai"] = new SelectList(_context.TrangThaiDonHangs, "MaTrangThai", "TenTrangThai", donHang.MaTrangThai);
            return View(donHang);
        }

        // POST: Admin/DonHangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaDh,MaKh,NgayMua,NgayGiao,MaTrangThai,ThanhToan,NgayThanhToan,GhiChu,MaShipper,DiaChi,TongTien,DiachiGiaoHang")] DonHang donHang)
        {
            if (id != donHang.MaDh)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(donHang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DonHangExists(donHang.MaDh))
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
            ViewData["MaKh"] = new SelectList(_context.KhachHangs, "MaKh", "HoTen", donHang.MaKh);
            ViewData["MaShipper"] = new SelectList(_context.Shippers, "MaShipper", "TenShipper", donHang.MaShipper);
            ViewData["MaTrangThai"] = new SelectList(_context.TrangThaiDonHangs, "MaTrangThai", "TenTrangThai", donHang.MaTrangThai);
            return View(donHang);
        }

        // GET: Admin/DonHangs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donHang = await _context.DonHangs
                .Include(d => d.MaKhNavigation)
                .Include(d => d.MaShipperNavigation)
                .Include(d => d.MaTrangThaiNavigation)
                .FirstOrDefaultAsync(m => m.MaDh == id);
            if (donHang == null)
            {
                return NotFound();
            }
            var Chitietdonhang = _context.ChiTietDonHangs
                .Include(x => x.MaSpNavigation)
                .AsNoTracking()
                .Where(x => x.MaDh == donHang.MaDh)
                .OrderBy(x => x.MaCtdh)
                .ToList();
            ViewBag.ChiTiet = Chitietdonhang;
            return View(donHang);
        }

        // POST: Admin/DonHangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var donHang = await _context.DonHangs.FindAsync(id);
            _context.DonHangs.Remove(donHang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DonHangExists(int id)
        {
            return _context.DonHangs.Any(e => e.MaDh == id);
        }
    }
}
