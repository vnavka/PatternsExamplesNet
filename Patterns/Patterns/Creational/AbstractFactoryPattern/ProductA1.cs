using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Patterns.Creational.AbstractFactoryPattern
{
	class ProductA1 : AbstractProductA
	{
		public override void GetInfoA() { Console.WriteLine("Its Pr1 {0}", this.GetType()); }
	}

}
