using System;
using System.ComponentModel.DataAnnotations;

namespace LKDT.ModelView
{
    public class MuaHangVM
    {

        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Họ và Tên")]
        public string FullName { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
		public string Phone { get; set; }
		[Required(ErrorMessage = "Vui lòng nhập địa chỉ nhận hàng")]
		public string Address { get; set; }
		//[Required(ErrorMessage = "Địa chỉ nhận hàng khác")]
		public string Dif_Address { get; set; }

		public bool DcKhac { get; set; }
		public string Note { get; set; }
    }
}
