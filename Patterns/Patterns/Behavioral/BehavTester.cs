using System;
using System.Collections.Generic;
using System.Text;
using Patterns.Patterns.Behavioral.StrategyPattern;
using Patterns.Patterns.Behavioral.ObserverPattern;
using Patterns.Patterns.Behavioral.ObserverPattern.ObserverImplementation;

namespace Patterns.Patterns.Behavioral
{
    class BehavTester
    {
		public void RunReationalTest()
		{
			this.RunStrategyTest();
			this.RunObserverTest();
		}

		#region pattern usage examples
		private void RunStrategyTest()
		{
			Context action = new Context(new ConcreteStrategyA());
			action.ExecuteAlgorithm();

			action.ContextStrategy = new ConcreteStrategyB();
			action.ExecuteAlgorithm();
		}
		private void RunObserverTest()
		{
			ConcreteObservable someProcess = new ConcreteObservable();
			for (int i = 0; i < 10; i++)
			{
				if (i % 2 == 0)
				{
					var tempObject = new ConcreteObserverA(String.Format("ObserverA{0}", i), someProcess);
				}
				else
				{
					var tempObject = new ConcreteObserverB(String.Format("ObserverB{0}", i), someProcess);
				}
			}
			for (int i = 0; i < 10; i++)
			{
				someProcess.ReinitInnerState();
			}
		}
		#endregion 
	}
}
