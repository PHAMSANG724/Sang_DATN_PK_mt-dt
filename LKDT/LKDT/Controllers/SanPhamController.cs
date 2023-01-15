using LKDT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LKDT.Controllers
{
	public class SanPhamController : Controller
	{
		private readonly LinhKienDienTuContext _context;
		public SanPhamController(LinhKienDienTuContext context)
		{
			_context = context;
		}
        [Route("shop.html", Name = ("ShopProduct"))]
        public IActionResult Index(int? page)
        {
            try
            {
                var pageNumber = page == null || page <= 0 ? 1 : page.Value;
                var pageSize = 10;
                var lsTinDangs = _context.SanPhams
                    .AsNoTracking()
                    .OrderBy(x => x.NgayTao);
                PagedList<SanPham> models = new PagedList<SanPham>(lsTinDangs, pageNumber, pageSize);

                ViewBag.CurrentPage = pageNumber;
                return View(models);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }


        }
        [Route("danhmuc/{Url}", Name = ("DanhSachSanPham"))]
        public IActionResult List(string Alias, int page = 1)
        {
            try
            {
                var pageSize = 10;
                var danhmuc = _context.DanhMucs.AsNoTracking().SingleOrDefault(x => x.Url == Alias);

                var lsTinDangs = _context.SanPhams
                    .AsNoTracking()
                    .Where(x => x.MaDm == danhmuc.MaDm)
                    .OrderByDescending(x => x.NgayTao);
                PagedList<SanPham> models = new PagedList<SanPham>(lsTinDangs, page, pageSize);
                ViewBag.CurrentPage = page;
                ViewBag.CurrentCat = danhmuc;
                return View(models);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }


        }

        [Route("/{Url}-{id}.html", Name = ("ChiTietSanPhams"))]
        public IActionResult Details(int id)
        {
            try
            {
                var product = _context.SanPhams.Include(x => x.MaDmNavigation).FirstOrDefault(x => x.MaSp == id);
                if (product == null)
                {
                    return RedirectToAction("Index");
                }
                var lsProduct = _context.SanPhams
                    .AsNoTracking()
                    .Where(x => x.MaDm == product.MaDm && x.MaSp != id && x.TrangThai == true)
                    .Take(4)
                    .OrderByDescending(x => x.NgayTao)
                    .ToList();
                ViewBag.SanPham = lsProduct;
                return View(product);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }


        }

    }
}
