using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Patterns.Creational.AbstractFactoryPattern
{
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
