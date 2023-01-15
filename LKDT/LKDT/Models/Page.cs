using System;
using System.Collections.Generic;

#nullable disable

namespace LKDT.Models
{
    public partial class Page
    {
        public int MaPage { get; set; }
        public string TenPage { get; set; }
        public string MotaNgan { get; set; }
        public string MotaDai { get; set; }
        public string Avatar { get; set; }
        public bool TrangThai { get; set; }
        public string Url { get; set; }
        public DateTime? NgayTao { get; set; }
        public int? SapXep { get; set; }
    }
}
