using System;
using System.Collections.Generic;
using System.Text;
using Patterns.Patterns.Behavioral.ObserverPattern.ObserverInterface;
using Patterns.Patterns.Behavioral.ObserverPattern.ObserverModels;

namespace Patterns.Patterns.Behavioral.ObserverPattern.ObserverImplementation
{
	class ConcreteObserverB : IMyObserver
	{
		public string Name { get; set; }
		IMyObservable source;
		public ConcreteObserverB(string name, IMyObservable obs)
		{
			this.Name = name;
			source = obs;
			source.RegisterObserver(this);
		}
		public void Update(object ob)
		{
			DataTransferObject dto = (DataTransferObject)ob;

			if (dto.valueB > 40)
				Console.WriteLine("{0} accept valueB -> {1}", this.Name, dto.valueB);
			else
				Console.WriteLine("{0} accept valueB -> {1}", this.Name, dto.valueB);
		}
		public void StopSubscrive()
		{
			source.RemoveObserver(this);
			source = null;
		}
	}
}
