using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Patterns.Creational.AbstractFactoryPattern
{
	abstract class AbstractProductB
	{
		public void GetInfoB()
		{
			Console.WriteLine("{0} /////", this.ToString());
		}
	}

}
