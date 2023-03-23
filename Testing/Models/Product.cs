﻿using System;
namespace Testing.Models
{
	public class Product
	{
		public Product()
		{
		}

		public double Price { get; set; }
		public int ProductID { get; set; }
		public string Name { get; set; }
		public int CategoryID { get; set; }
		public int OnSale { get; set; }
		public int StockLevel { get; set; }
	}
}

