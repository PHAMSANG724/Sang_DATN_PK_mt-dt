using System;
using System.Collections.Generic;

#nullable disable

namespace LKDT.Models
{
    public partial class TrangThaiDonHang
    {
        public TrangThaiDonHang()
        {
            DonHangs = new HashSet<DonHang>();
        }

        public int MaTrangThai { get; set; }
        public string TenTrangThai { get; set; }
        public string MoTa { get; set; }

        public virtual ICollection<DonHang> DonHangs { get; set; }
    }
}
