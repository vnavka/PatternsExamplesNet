using Patterns.Patterns.Creational.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Patterns.Creational
{
	class CreatTester {
		public void RunReationalTest()
		{
			Creator creator = new ConcreteCreatorA();
			Product Item1 = creator.FactoryMethod();

			creator = new ConcreteCreatorB();
			Product Item2 = creator.FactoryMethod();
		}
	}
}
