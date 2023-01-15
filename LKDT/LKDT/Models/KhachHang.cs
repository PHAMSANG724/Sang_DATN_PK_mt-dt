using System;
using System.Collections.Generic;

#nullable disable

namespace LKDT.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            DonHangs = new HashSet<DonHang>();
        }

        public int MaKh { get; set; }
        public string HoTen { get; set; }
        public string Avatar { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public DateTime? NgayTao { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? DangNhapCuoi { get; set; }
        public bool TrangThai { get; set; }
        public string ChuoiMaHoa { get; set; }
        public string Url { get; set; }
        public bool DiachiKhac { get; set; }
        public int? MaDcgh { get; set; }

        public virtual DiaChiGiaoHang MaDcghNavigation { get; set; }
        public virtual ICollection<DonHang> DonHangs { get; set; }
    }
}
