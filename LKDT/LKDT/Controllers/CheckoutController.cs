using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LKDT.Extension;
using LKDT.Helpper;
using LKDT.Models;
using LKDT.ModelView;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebShop.Controllers
{
	public class CheckoutController : Controller
	{
		private readonly LinhKienDienTuContext _context;
		public INotyfService _notyfService { get; }
		public CheckoutController(LinhKienDienTuContext context, INotyfService notyfService)
		{
			_context = context;
			_notyfService = notyfService;
		}
		public List<CartItem> GioHang
		{
			get
			{
				var gh = HttpContext.Session.Get<List<CartItem>>("GioHang");
				if (gh == default(List<CartItem>))
				{
					gh = new List<CartItem>();
				}
				return gh;
			}
		}
		[Route("checkout.html", Name = "Checkout")]
		public IActionResult Index(string returnUrl = null)
		{
			//Lay gio hang ra de xu ly
			var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
			var taikhoanID = HttpContext.Session.GetString("MaKh");
			MuaHangVM model = new MuaHangVM();
			if (taikhoanID != null)
			{
				var khachhang = _context.KhachHangs.AsNoTracking().SingleOrDefault(x => x.MaKh == Convert.ToInt32(taikhoanID));
				model.CustomerId = khachhang.MaKh;
				model.FullName = khachhang.HoTen;
				model.Email = khachhang.Email;
				model.Phone = khachhang.Sdt;
				model.Address = khachhang.DiaChi;
			}
			ViewBag.GioHang = cart;
			return View(model);
		}

		[HttpPost]
		[Route("checkout.html", Name = "Checkout")]
		public IActionResult Index(MuaHangVM muaHang)
		{
			//Lay ra gio hang de xu ly
			var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
			var taikhoanID = HttpContext.Session.GetString("MaKh");
			MuaHangVM model = new MuaHangVM();
			if (taikhoanID != null)
			{
				var khachhang = _context.KhachHangs.AsNoTracking().SingleOrDefault(x => x.MaKh == Convert.ToInt32(taikhoanID));
				model.CustomerId = khachhang.MaKh;
				model.FullName = khachhang.HoTen;
				model.Email = khachhang.Email;
				model.Phone = khachhang.Sdt;
				model.Address = khachhang.DiaChi;
				//model.Dif_Address = khachhang.MaDcghNavigation.DiaChi;
				//if (khachhang.DiaChi != null)
				//{
				//	model.Address = khachhang.DiaChi;
				//	khachhang.DiaChi = muaHang.Address;
				//}


				//if (khachhang.MaDcghNavigation.DiaChi != null)
				//{
				//	model.Dif_Address = khachhang.MaDcghNavigation.DiaChi;
				//	khachhang.MaDcghNavigation.DiaChi = muaHang.Dif_Address;
				//}



				//khachhang.DiachiKhac = muaHang.Address;
				khachhang.DiaChi = muaHang.Address;
				//khachhang.MaDcghNavigation.DiaChi = muaHang.Dif_Address;
				_context.Update(khachhang);
				_context.SaveChanges();
			}
			try
			{
				if (ModelState.IsValid)
				{
					//Khoi tao don hang
					DonHang donhang = new DonHang();
					donhang.MaKh = model.CustomerId;
					donhang.DiachiGiaoHang = model.Address;
					if (model.DcKhac == true)
					{
						donhang.DiachiGiaoHang = model.Dif_Address;
					}

					donhang.NgayMua = DateTime.Now;
					donhang.MaTrangThai = 1;//Don hang moi
					donhang.MaShipper = 1;
					donhang.GhiChu = Utilities.StripHTML(model.Note);
					donhang.TongTien = Convert.ToInt32(cart.Sum(x => x.TotalMoney));
					_context.Add(donhang);
					_context.SaveChanges();
					//tao danh sach don hang

					foreach (var item in cart)
					{
						ChiTietDonHang orderDetail = new ChiTietDonHang();
						orderDetail.MaDh = donhang.MaDh;
						orderDetail.MaSp = item.product.MaSp;
						orderDetail.SoLuong = item.amount;
						orderDetail.TongTien = donhang.TongTien;
						orderDetail.DonGia = item.product.DonGia;
						orderDetail.NgayMua = DateTime.Now;
						_context.Add(orderDetail);
					}
					_context.SaveChanges();
					//clear gio hang
					HttpContext.Session.Remove("GioHang");
					//Xuat thong bao
					_notyfService.Success("Đơn hàng đặt thành công");
					//cap nhat thong tin khach hang
					return RedirectToAction("Success");


				}
			}
			catch
			{
				ViewBag.GioHang = cart;
				return View(model);
			}
			ViewBag.Error = "Không được để trống";
			ViewBag.GioHang = cart;
			return View(model);
		}
		[Route("dat-hang-thanh-cong.html", Name = "Success")]
		public IActionResult Success()
		{
			try
			{
				var taikhoanID = HttpContext.Session.GetString("CustomerId");
				if (string.IsNullOrEmpty(taikhoanID))
				{
					return RedirectToAction("Login", "Accounts", new { returnUrl = "/dat-hang-thanh-cong.html" });
				}
				var khachhang = _context.KhachHangs.AsNoTracking().SingleOrDefault(x => x.MaKh == Convert.ToInt32(taikhoanID));
				var donhang = _context.DonHangs
					.Where(x => x.MaKh == Convert.ToInt32(taikhoanID))
					.OrderByDescending(x => x.NgayGiao)
					.FirstOrDefault();
				MuaHangSuccessVM successVM = new MuaHangSuccessVM();
				successVM.FullName = khachhang.HoTen;
				successVM.DonHangID = donhang.MaDh;
				successVM.Phone = khachhang.Sdt;
				successVM.Address = khachhang.DiaChi;
				return View(successVM);
			}
			catch
			{
				return View();
			}
		}
	}
}
