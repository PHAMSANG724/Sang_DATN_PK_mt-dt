using LKDT.ModelView;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LKDT.Extension;

namespace LKDT.Controllers.Components
{
	public class HeaderCartViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
			return View(cart);
		}
	}
}
