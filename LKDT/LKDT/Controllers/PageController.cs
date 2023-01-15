using LKDT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LKDT.Controllers
{
	public class PageController : Controller
	{
        private readonly LinhKienDienTuContext _context;
        public PageController(LinhKienDienTuContext context)
        {
            _context = context;
        }
    
        [Route("/page/{url}", Name = "PageChiTiet")]
        public IActionResult Details(string url)
        {
            if (string.IsNullOrEmpty(url)) 
                return RedirectToAction("Index", "Home");

            var page = _context.Pages.AsNoTracking().SingleOrDefault(x => x.Url == url);
            if (page == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(page);
        }
    }
}
