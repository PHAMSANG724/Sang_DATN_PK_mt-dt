using LKDT.Models;
using LKDT.ModelView;
using LKDT.ModelViews;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LKDT.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LinhKienDienTuContext _context;

        public HomeController(ILogger<HomeController> logger, LinhKienDienTuContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewVM model = new HomeViewVM();

            var lsProducts = _context.SanPhams
                .AsNoTracking()
                .Where(x => x.TrangThai == true)
                .OrderByDescending(x => x.NgayTao)
                .ToList();

            List<ProductHomeVM> lsProductViews = new List<ProductHomeVM>();
            var lsCats = _context.DanhMucs
                .AsNoTracking()
                .Where(x => x.TrangThai == true)
                .OrderByDescending(x => x.SapXep)
                .ToList();

            foreach (var item in lsCats)
            {
                ProductHomeVM productHome = new ProductHomeVM();
                productHome.category = item;
                productHome.lsProducts = lsProducts.Where(x => x.MaDm == item.MaDm).ToList();
                lsProductViews.Add(productHome);


                var TinTuc = _context.TinTucs
                    .AsNoTracking()
                    .Where(x => x.TrangThai == true)
                    .OrderByDescending(x => x.NgayTao)
                    .Take(3)
                    .ToList();
				model.SanPhams = lsProductViews;
                model.TinTucs = TinTuc;
                ViewBag.AllProducts = lsProducts;
            }
            return View(model);
        }



        [Route("lien-he.html", Name = "LienHe")]
        public IActionResult LienHe()
        {
            return View();
        }
        [Route("gioi-thieu.html", Name = "VeChungToi")]
        public IActionResult VeChungToi()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
