﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Patterns.Creational.BuilderPattern
{
	abstract class Builder
	{
		public abstract void BuildPartA();
		public abstract void BuildPartB();
		public abstract void BuildPartC();
		public abstract Product GetResult();
	}	
}
