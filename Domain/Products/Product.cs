﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Products
{
	public class Product
	{
		public int Id {  get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string category { get; set; }
		public int Status { get; set; }

	}

}
