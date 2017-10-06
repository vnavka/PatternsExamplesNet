using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Patterns.Creational.FactoryMethod
{
	class ConcreteCreatorA : Creator
	{
		public override Product FactoryMethod() { return new ConcreteProductA(); }
	}
}
