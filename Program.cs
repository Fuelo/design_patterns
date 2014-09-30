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

		static void decoratorPatternTest()
		{
			DecoratorExample example = new DecoratorExample();
			example.execute ();
		}

		static void singletonPatternTest()
		{
			SingletonExample example = new SingletonExample();
			example.execute ();
		}

		static void commandPatternExample()
		{
			CommandPatternExample example = new CommandPatternExample();
			example.execute ();
		}

		public static void Main (string[] args)
		{
//            strategyPatternTest();
//            observerPatternTest();
//			decoratorPatternTest ();
			//singletonPatternTest ();
			commandPatternExample ();
            Console.ReadLine();
		}
	}
}
