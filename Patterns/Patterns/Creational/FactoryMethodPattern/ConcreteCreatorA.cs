using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Patterns.Creational.FactoryMethodPattern
{
	class ConcreteCreatorA : Creator
	{
		public override Product FactoryMethod() { return new ConcreteProductA(); }
	}
}
