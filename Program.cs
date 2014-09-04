using System;
using design_patterns.example;

namespace design_patterns
{
	class MainClass
	{
        static void strategyPatternTest() {
            StrategyPatternExample strategyPatternExample = new StrategyPatternExample();
            strategyPatternExample.execute();
        }

        static void observerPatternTest()
        {

            ObserverPatternExample example = new ObserverPatternExample();
            example.execute();
        }

		public static void Main (string[] args)
		{
            //strategyPatternTest();
            observerPatternTest();
            Console.ReadLine();
		}
	}
}
