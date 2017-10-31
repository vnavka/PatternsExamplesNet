using System;
using Patterns.Patterns.Behavioral.ObserverPattern.ObserverInterface;
using Patterns.Patterns.Behavioral.ObserverPattern.ObserverModels;

namespace Patterns.Patterns.Behavioral.ObserverPattern.ObserverImplementation
{
	class ConcreteObserverA : IMyObserver
	{
		public string Name { get; set; }
		IMyObservable source;
		public ConcreteObserverA(string name, IMyObservable obs)
		{
			this.Name = name;
			source = obs;
			source.RegisterObserver(this);
		}
		public void Update(object ob)
		{
			DataTransferObject sInfo = (DataTransferObject)ob;

			if (sInfo.valueA > 30)
				Console.WriteLine("{0} accept valueA -> {1}", this.Name, sInfo.valueA);
			else
				Console.WriteLine("{0} deny   valueA -> {1}", this.Name, sInfo.valueA);
		}
		public void StopTrade()
		{
			source.RemoveObserver(this);
			source = null;
		}
	}
}
