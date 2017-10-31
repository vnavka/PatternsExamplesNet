using System;
using System.Collections.Generic;
using System.Text;
using Patterns.Patterns.Behavioral.ObserverPattern.ObserverInterface;
using Patterns.Patterns.Behavioral.ObserverPattern.ObserverModels;

namespace Patterns.Patterns.Behavioral.ObserverPattern.ObserverInterface
{
	interface IMyObserver
	{
		void Update(Object ob);
	}
}
