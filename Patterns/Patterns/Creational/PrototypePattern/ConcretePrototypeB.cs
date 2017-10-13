using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Patterns.Creational.PrototypePattern
{
	class ConcretePrototypeB : Prototype
	{
		public ConcretePrototypeB(int id)
			: base(id)
		{ }
		public override Prototype Clone()
		{
			return new ConcretePrototypeB(Id);
		}
	}
}
