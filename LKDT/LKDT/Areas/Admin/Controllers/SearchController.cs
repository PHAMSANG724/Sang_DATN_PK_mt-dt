using LKDT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LKDT.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class SearchController : Controller
	{
		private readonly LinhKienDienTuContext _context;

		public SearchController(LinhKienDienTuContext context)
		{
			_context = context;
		}

        [HttpPost]
        public IActionResult FindProduct(string keyword)
        {
            List<SanPham> ls = new List<SanPham>();
            if (string.IsNullOrEmpty(keyword) || keyword.Length < 1)
            {
                return PartialView("ListProductsSearchPartial", null);
            }
            ls = _context.SanPhams.AsNoTracking()
                                  .Include(a => a.MaDmNavigation)
                                  .Where(x => x.TenSp.Contains(keyword))
                                  .OrderByDescending(x => x.TenSp)
                                  .Take(10)
                                  .ToList();
            if (ls == null)
            {
                return PartialView("ListProductsSearchPartial", null);
            }
            else
            {
                return PartialView("ListProductsSearchPartial", ls);
            }
        }
    }
}
