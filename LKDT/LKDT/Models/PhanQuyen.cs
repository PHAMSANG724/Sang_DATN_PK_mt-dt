using System;
using System.Collections.Generic;

#nullable disable

namespace LKDT.Models
{
    public partial class PhanQuyen
    {
        public PhanQuyen()
        {
            TaiKhoans = new HashSet<TaiKhoan>();
        }

        public int MaQuyen { get; set; }
        public string TenQuyen { get; set; }
        public string MoTa { get; set; }

        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
