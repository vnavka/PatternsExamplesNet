using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Patterns.Creational.AbstractFactoryPattern
{
	class ConcreteFactoryA : AbstractFactory
	{
		public override AbstractProductA CreateProductA()
		{
			return new ProductA1();
		}

		public override AbstractProductB CreateProductB()
		{
			return new ProductB1();
		}
	}

}
