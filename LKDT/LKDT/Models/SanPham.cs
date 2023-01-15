using System;
using System.Collections.Generic;

#nullable disable

namespace LKDT.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
        }

        public int MaSp { get; set; }
        public string TenSp { get; set; }
        public string MotaNgan { get; set; }
        public string MotaDai { get; set; }
        public int? MaDm { get; set; }
        public int? DonGia { get; set; }
        public string Avatar { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayChinhSua { get; set; }
        public bool TrangThai { get; set; }
        public string Url { get; set; }

        public virtual DanhMuc MaDmNavigation { get; set; }
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
    }
}
