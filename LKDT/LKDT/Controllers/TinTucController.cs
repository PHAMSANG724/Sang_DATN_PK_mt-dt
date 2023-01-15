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
    public class TinTucController : Controller
    {
        private readonly LinhKienDienTuContext _context;
        public TinTucController(LinhKienDienTuContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        [Route("blogs.html", Name = ("Blog"))]
        public IActionResult Index(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 10;
            var lsTinDangs = _context.TinTucs
                .AsNoTracking()
                .OrderBy(x => x.MaTinTuc);
            PagedList<TinTuc> models = new PagedList<TinTuc>(lsTinDangs, pageNumber, pageSize);

            ViewBag.CurrentPage = pageNumber;
            return View(models);
        }
        [Route("/tin-tuc/{url}-{id}.html", Name = "TinChiTiet")]
        public IActionResult Details(int id)
        {
            var tindang = _context.TinTucs.AsNoTracking().SingleOrDefault(x => x.MaTinTuc == id);
            if (tindang == null)
            {
                return RedirectToAction("Index");
            }
            var lsBaivietlienquan = _context.TinTucs
                .AsNoTracking()
                .Where(x => x.TrangThai == true && x.MaTinTuc != id)
                .Take(3)
                .OrderByDescending(x => x.NgayTao).ToList();
            ViewBag.Baivietlienquan = lsBaivietlienquan;
            return View(tindang);
        }
    }
}
