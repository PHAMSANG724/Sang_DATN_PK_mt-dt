using System;
using System.Collections.Generic;

#nullable disable

namespace LKDT.Models
{
    public partial class DiaChiGiaoHang
    {
        public DiaChiGiaoHang()
        {
            KhachHangs = new HashSet<KhachHang>();
        }

        public int MaDcgh { get; set; }
        public int? MaKh { get; set; }
        public string DiaChi { get; set; }

        public virtual ICollection<KhachHang> KhachHangs { get; set; }
    }
}
