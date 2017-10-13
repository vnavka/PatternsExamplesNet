using Patterns.Patterns.Creational.AbstractFactoryPattern;
using Patterns.Patterns.Creational.FactoryMethodPattern;
using Patterns.Patterns.Creational.SingletonPattern;
using Patterns.Patterns.Creational.PrototypePattern;
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
			this.RunSingleton();
			this.RunPrototypeTest();
		}

		#region patternTest
		private void RunPrototypeTest()
		{
			Prototype prototype = new ConcretePrototypeA(1);
			Prototype clone = prototype.Clone();
			Console.WriteLine("itemA_id={0}", clone.Id);

			prototype = new ConcretePrototypeB(2);
			clone = prototype.Clone();
			Console.WriteLine("itemB_id={0}", clone.Id);
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
			Client cust = new Client(new ConcreteFactoryA());
			cust.Run();
			cust = new Client(new ConcreteFactoryB());
			cust.Run();
		}
		private void RunSingleton()
		{
			var creator = new Singleton();
			var product = creator.Instance;
			Console.WriteLine(product.name);
		}
		#endregion
	}
}
