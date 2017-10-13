using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Patterns.Creational.AbstractFactoryPattern
{
	class ConcreteFactoryB : AbstractFactory
	{
		public override AbstractProductA CreateProductA()
		{
			return new ProductA2();
		}

		public override AbstractProductB CreateProductB()
		{
			return new ProductB2();
		}
	}


}
