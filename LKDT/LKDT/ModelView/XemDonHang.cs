using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LKDT.Models;

namespace LKDT.ModelView
{
	public class XemDonHang
    {
        public DonHang DonHang { get; set; }
        public List<ChiTietDonHang> ChiTietDonHang { get; set; }
    }
}
