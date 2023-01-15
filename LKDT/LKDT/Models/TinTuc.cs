using System;
using System.Collections.Generic;

#nullable disable

namespace LKDT.Models
{
    public partial class TinTuc
    {
        public int MaTinTuc { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public string Avatar { get; set; }
        public bool TrangThai { get; set; }
        public string Url { get; set; }
        public DateTime? NgayTao { get; set; }
        public string TacGia { get; set; }
        public int? MaTk { get; set; }
        public int? MaDm { get; set; }
        public bool TinHot { get; set; }
        public int? LuotXem { get; set; }

        public virtual DanhMuc MaDmNavigation { get; set; }
        public virtual TaiKhoan MaTkNavigation { get; set; }
    }
}
