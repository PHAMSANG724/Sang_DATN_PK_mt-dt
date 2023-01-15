using LKDT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LKDT.ModelView
{
	public class CartItem
	{
		public SanPham product { get; set; }
		public int amount { get; set; }
		public double TotalMoney => amount * product.DonGia.Value;
	}
}
