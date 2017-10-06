
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Patterns.Creational.AbstractFactory
{
	abstract class AbstractFactory
	{
		public abstract AbstractProductA CreateProductA();
		public abstract AbstractProductB CreateProductB();
	}
	class ConcreteFactory1 : AbstractFactory
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
	class ConcreteFactory2 : AbstractFactory
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

	abstract class AbstractProductA
	{
		public abstract void GetInfoA();
	}

	abstract class AbstractProductB
	{
		public void GetInfoB()
		{
			Console.WriteLine("{0} /////", this.ToString());
		}
	}

	class ProductA1 : AbstractProductA
	{
		public override void GetInfoA() { Console.WriteLine("Its Pr1 {0}", this.GetType()); }
	}

	class ProductB1 : AbstractProductB
	{ }

	class ProductA2 : AbstractProductA
	{
		public override void GetInfoA() { Console.WriteLine("Its Pr2 {0}", this.GetType()); }
	}

	class ProductB2 : AbstractProductB
	{ }

	class Client
	{
		private AbstractProductA abstractProductA;
		private AbstractProductB abstractProductB;

		public Client(AbstractFactory factory)
		{
			abstractProductB = factory.CreateProductB();
			abstractProductA = factory.CreateProductA();
		}
		public void Run()
		{
			abstractProductA.GetInfoA();
			abstractProductB.GetInfoB();
		}
	}
}
