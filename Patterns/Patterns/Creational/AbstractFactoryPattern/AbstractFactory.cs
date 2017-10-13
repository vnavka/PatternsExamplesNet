
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Patterns.Creational.AbstractFactoryPattern
{
	abstract class AbstractFactory
	{
		public abstract AbstractProductA CreateProductA();
		public abstract AbstractProductB CreateProductB();
	}
}
