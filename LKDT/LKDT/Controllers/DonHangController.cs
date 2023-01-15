using AspNetCoreHero.ToastNotification.Abstractions;
using LKDT.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LKDT.ModelView;

namespace LKDT.Controllers
{
	public class DonHangController : Controller
	{
        private readonly LinhKienDienTuContext _context;
        public INotyfService _notyfService { get; }
        public DonHangController(LinhKienDienTuContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }
        [HttpPost]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            try
            {
                var taikhoanID = HttpContext.Session.GetString("MaKh");
                if (string.IsNullOrEmpty(taikhoanID)) return RedirectToAction("Login", "Accounts");
                var khachhang = _context.KhachHangs.AsNoTracking().SingleOrDefault(x => x.MaKh == Convert.ToInt32(taikhoanID));
                if (khachhang == null) return NotFound();
                var donhang = await _context.DonHangs
                    .Include(x => x.MaTrangThaiNavigation)
                    .FirstOrDefaultAsync(m => m.MaDh == id && Convert.ToInt32(taikhoanID) == m.MaKh);
                if (donhang == null) return NotFound();

                var chitietdonhang = _context.ChiTietDonHangs
                    .Include(x => x.MaSpNavigation)
                    .AsNoTracking()
                    .Where(x => x.MaDh == id)
                    .OrderBy(x => x.MaCtdh)
                    .ToList();
                XemDonHang donHang = new XemDonHang();
                donHang.DonHang = donhang;
                donHang.ChiTietDonHang = chitietdonhang;
                return PartialView("Details", donHang);

            }
            catch
            {
                return NotFound();
            }
        }
    }
}

