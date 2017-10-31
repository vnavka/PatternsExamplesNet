using System;
using System.Collections.Generic;
using System.Text;
using Patterns.Patterns.Behavioral.ObserverPattern.ObserverInterface;
using Patterns.Patterns.Behavioral.ObserverPattern.ObserverModels;

namespace Patterns.Patterns.Behavioral.ObserverPattern.ObserverInterface
{
	interface IMyObservable
	{
		void RegisterObserver(IMyObserver o);
		void RemoveObserver(IMyObserver o);
		void NotifyObservers();
	}
}
