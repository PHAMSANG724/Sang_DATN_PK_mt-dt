using System;
using System.ComponentModel.DataAnnotations;

namespace LKDT.ModelView
{
	public class UpdateViewModel
	{
        [Key]
        public int CustomerId { get; set; }

        [Display(Name = "Số điện thoại")]
        public string SDT { get; set; }

        [Display(Name = "Địa chỉ nhận hàng")]
        public string DiaChi { get; set; }

    }
}
