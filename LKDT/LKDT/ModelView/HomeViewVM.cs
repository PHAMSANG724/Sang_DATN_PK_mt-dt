using LKDT.Models;
using LKDT.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LKDT.ModelView
{
	public class HomeViewVM
	{
		public List<TinTuc> TinTucs { get; set; }
		public List<ProductHomeVM> SanPhams { get; set; }

	}
}
