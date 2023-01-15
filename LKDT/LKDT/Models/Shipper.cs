using System;
using System.Collections.Generic;

#nullable disable

namespace LKDT.Models
{
    public partial class Shipper
    {
        public Shipper()
        {
            DonHangs = new HashSet<DonHang>();
        }

        public int MaShipper { get; set; }
        public string TenShipper { get; set; }
        public string MoTa { get; set; }

        public virtual ICollection<DonHang> DonHangs { get; set; }
    }
}
