using System;
using Patterns.Patterns.Creational;
using Patterns.Patterns.Creational.AbstractFactory;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
			CreatTester CrItem = new CreatTester();
			CrItem.RunReationalTest();

			Console.ReadLine();
		}
    }
}