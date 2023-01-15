using System;
using System.Collections.Generic;
using LKDT.Models;

namespace LKDT.ModelViews
{
    public class ProductHomeVM
    {
        public DanhMuc category { get; set; }
        public List<SanPham> lsProducts { get; set; }
    }
}
