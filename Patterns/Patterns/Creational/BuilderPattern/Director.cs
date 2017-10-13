using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Patterns.Creational.BuilderPattern
{
	class Director
	{
		Builder builder;
		public Director(Builder builder)
		{
			this.builder = builder;
		}

		//manage action combinations
		//can realization can be queries to database or object processing in multiple orders
		public void Construct()
		{
			builder.BuildPartA();
			builder.BuildPartB();
			builder.BuildPartC();
		}
	}
}
