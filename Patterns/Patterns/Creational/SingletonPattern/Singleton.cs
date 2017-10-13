using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Patterns.Creational.SingletonPattern
{
	
	public class Singleton
	{
		private TestItem instance;
		public TestItem Instance
		{
			get
			{
				if (instance == null)
					instance = new TestItem("init");
				return instance;
			}
		}
	}
}
