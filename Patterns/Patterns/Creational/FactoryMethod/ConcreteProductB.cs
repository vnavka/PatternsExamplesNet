﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Patterns.Creational.FactoryMethod
{
	class ConcreteProductB : Product
	{
		public ConcreteProductB(string val) : base(val) { }
		public ConcreteProductB()
		{
			Console.WriteLine("ConcreteProductB created");
		}
	}
}
