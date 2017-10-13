using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Patterns.Creational.FactoryMethodPattern
{
	abstract class Product
	{
		public string Name { get; set; }
		public Product()
		{
			Console.WriteLine("Item created");
		}
		public Product(string val)
		{
			Name = val;
		}
	}
}
