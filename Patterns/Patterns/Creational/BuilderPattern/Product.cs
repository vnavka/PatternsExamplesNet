using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Patterns.Creational.BuilderPattern
{
	class Product
	{
		List<object> parts = new List<object>();
		public void Add(string part)
		{
			parts.Add(part);
		}
	}
}
