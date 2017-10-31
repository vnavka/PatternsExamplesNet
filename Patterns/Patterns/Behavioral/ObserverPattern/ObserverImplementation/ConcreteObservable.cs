using System;
using System.Collections.Generic;
using Patterns.Patterns.Behavioral.ObserverPattern.ObserverInterface;
using Patterns.Patterns.Behavioral.ObserverPattern.ObserverModels;

namespace Patterns.Patterns.Behavioral.ObserverPattern.ObserverImplementation
{
	class ConcreteObservable : IMyObservable
	{
		DataTransferObject dto;
		List<IMyObserver> observers;

		public ConcreteObservable()
		{
			observers = new List<IMyObserver>();
			dto = new DataTransferObject();
		}
		public void RegisterObserver(IMyObserver o)
		{
			observers.Add(o);
		}
		public void RemoveObserver(IMyObserver o)
		{
			observers.Remove(o);
		}
		public void NotifyObservers()
		{
			foreach (IMyObserver o in observers)
			{
				o.Update(dto);
			}
		}
		public void ReinitInnerState()
		{
			Random rnd = new Random();
			dto.valueA = rnd.Next(0, 60);
			dto.valueB = rnd.Next(0, 80);
			NotifyObservers();
		}
	}

}
