using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Patterns.Creational.AbstractFactoryPattern
{
	class ProductA2 : AbstractProductA
	{
		public override void GetInfoA() { Console.WriteLine("Its Pr2 {0}", this.GetType()); }
	}

}
