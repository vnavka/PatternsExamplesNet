using Patterns.Patterns.Creational.AbstractFactory;
using Patterns.Patterns.Creational.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Patterns.Creational
{
	class CreatTester {
		public void RunReationalTest()
		{
			this.RunAbstractFactory();
			this.RunFactoryMethod();
		}
		private void RunFactoryMethod()
		{
			Creator creator = new ConcreteCreatorA();
			Product Item1 = creator.FactoryMethod();

			creator = new ConcreteCreatorB();
			Product Item2 = creator.FactoryMethod();
		}
		private void RunAbstractFactory()
		{
			Client cust = new Client(new ConcreteFactory1());
			cust.Run();
			cust = new Client(new ConcreteFactory2());
			cust.Run();
		}
	}
}
