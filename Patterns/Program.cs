using System;
using Patterns.Patterns.Creational;
using Patterns.Patterns.Behavioral;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
			CreatTester CrItem = new CreatTester();
			CrItem.RunReationalTest();

			BehavTester BhItem = new BehavTester();
			BhItem.RunReationalTest();

			Console.ReadLine();
		}
    }
}