using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Patterns.Creational.SingletonPattern
{
	public class TestItem
	{
		public TestItem(string name)
		{
			this.name = name;
		}
		public string name { get; }
	}
}
