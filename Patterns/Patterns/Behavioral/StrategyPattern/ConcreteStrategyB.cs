using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Patterns.Behavioral.StrategyPattern
{
	public class ConcreteStrategyB : IStrategy
	{
		public void Algorithm()
		{
			Console.WriteLine("Some action B");
		}
	}
}
