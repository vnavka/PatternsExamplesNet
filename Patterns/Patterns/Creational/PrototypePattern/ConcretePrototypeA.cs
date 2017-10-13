using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Patterns.Creational.PrototypePattern
{
	class ConcretePrototypeA : Prototype
	{
		public ConcretePrototypeA(int id)
			: base(id)
		{ }
		public override Prototype Clone()
		{
			return new ConcretePrototypeA(Id);
		}
	}
}
