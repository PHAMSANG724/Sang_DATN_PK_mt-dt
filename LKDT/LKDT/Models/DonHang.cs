using System;
using System.Collections.Generic;

#nullable disable

namespace LKDT.Models
{
    public partial class DonHang
    {
        public DonHang()
        {
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
        }

        public int MaDh { get; set; }
        public int MaKh { get; set; }
        public DateTime? NgayMua { get; set; }
        public DateTime? NgayGiao { get; set; }
        public int MaTrangThai { get; set; }
        public bool ThanhToan { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public string GhiChu { get; set; }
        public int MaShipper { get; set; }
        public bool DiaChi { get; set; }
        public int TongTien { get; set; }
        public string DiachiGiaoHang { get; set; }

        public virtual KhachHang MaKhNavigation { get; set; }
        public virtual Shipper MaShipperNavigation { get; set; }
        public virtual TrangThaiDonHang MaTrangThaiNavigation { get; set; }
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
    }
}
