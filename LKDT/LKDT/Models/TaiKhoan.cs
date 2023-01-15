using System;
using System.Collections.Generic;

#nullable disable

namespace LKDT.Models
{
    public partial class TaiKhoan
    {
        public TaiKhoan()
        {
            TinTucs = new HashSet<TinTuc>();
        }

        public int MaTk { get; set; }
        public string HoTen { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public bool TrangThai { get; set; }
        public int? MaQuyen { get; set; }
        public DateTime? DangnhapCuoi { get; set; }
        public DateTime? NgayTao { get; set; }
        public string ChuoiMaHoa { get; set; }

        public virtual PhanQuyen MaQuyenNavigation { get; set; }
        public virtual ICollection<TinTuc> TinTucs { get; set; }
    }
}
