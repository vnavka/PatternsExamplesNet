using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Patterns.Creational.FactoryMethodPattern
{
	class ConcreteCreatorB : Creator
	{
		public override Product FactoryMethod() { return new ConcreteProductB(); }
	}
}
