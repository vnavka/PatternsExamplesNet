using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Patterns.Creational.FactoryMethod
{
	class ConcreteProductA : Product
	{
		public ConcreteProductA(string val) : base(val) { }
		public ConcreteProductA()
		{
			Console.WriteLine("ConcreteProductA created");
		}
	}
}
