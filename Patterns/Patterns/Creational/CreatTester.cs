using Patterns.Patterns.Creational.AbstractFactoryPattern;
using Patterns.Patterns.Creational.FactoryMethodPattern;
using Patterns.Patterns.Creational.SingletonPattern;
using Patterns.Patterns.Creational.PrototypePattern;
using Patterns.Patterns.Creational.BuilderPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Patterns.Creational
{
	class CreatTester {
		public void RunReationalTest()
		{
			this.RunAbstractFactoryTest();
			this.RunFactoryMethodTest();
			this.RunSingletonTest();
			this.RunPrototypeTest();
			this.RunBuilderTest();
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
		private void RunFactoryMethodTest()
		{
			Creator creator = new ConcreteCreatorA();
			FactoryMethodPattern.Product Item1 = creator.FactoryMethod();

			creator = new ConcreteCreatorB();
			FactoryMethodPattern.Product Item2 = creator.FactoryMethod();
		}
		private void RunAbstractFactoryTest()
		{
			Client cust = new Client(new ConcreteFactoryA());
			cust.Run();
			cust = new Client(new ConcreteFactoryB());
			cust.Run();
		}
		private void RunSingletonTest()
		{
			var creator = new Singleton();
			var product = creator.Instance;
			Console.WriteLine(product.name);
		}
		private void RunBuilderTest()
		{
			Builder a_builder = new ConcreteBuilder();
			Director a_derector = new Director(a_builder);
			a_derector.Construct();
			BuilderPattern.Product a_product = a_builder.GetResult();
		}
		#endregion
	}
}
