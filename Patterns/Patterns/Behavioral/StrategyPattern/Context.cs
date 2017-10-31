using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Patterns.Behavioral.StrategyPattern
{
	public class Context
	{
		public IStrategy ContextStrategy { get; set; }

		public Context(IStrategy _strategy)
		{
			ContextStrategy = _strategy;
		}

		public void ExecuteAlgorithm()
		{
			ContextStrategy.Algorithm();
		}
	}
}
