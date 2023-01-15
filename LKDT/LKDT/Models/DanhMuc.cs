using System;
using System.Collections.Generic;

#nullable disable

namespace LKDT.Models
{
    public partial class DanhMuc
    {
        public DanhMuc()
        {
            SanPhams = new HashSet<SanPham>();
            TinTucs = new HashSet<TinTuc>();
        }

        public int MaDm { get; set; }
        public string TenDm { get; set; }
        public string MoTa { get; set; }
        public int? SapXep { get; set; }
        public bool TrangThai { get; set; }
        public string Avatar { get; set; }
        public string TieuDe { get; set; }
        public string Url { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
        public virtual ICollection<TinTuc> TinTucs { get; set; }
    }
}
