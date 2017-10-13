using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Patterns.Creational.BuilderPattern
{
	class ConcreteBuilder : Builder
	{
		Product product = new Product();
		public override void BuildPartA()
		{
			product.Add("Some Action A");
		}
		public override void BuildPartB()
		{
			product.Add("Some Action B");
		}
		public override void BuildPartC()
		{
			product.Add("Some Action C");
		}
		public override Product GetResult()
		{
			return product;
		}
	}
}
