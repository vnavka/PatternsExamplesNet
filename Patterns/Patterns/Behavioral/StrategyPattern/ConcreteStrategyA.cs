using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Patterns.Behavioral.StrategyPattern
{
	public class ConcreteStrategyA : IStrategy
	{
		public void Algorithm()
		{
			Console.WriteLine("Some action A");
		}
	}
}
