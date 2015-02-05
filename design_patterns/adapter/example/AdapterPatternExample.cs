using System;

namespace design_patterns.example
{
	public class AdapterPatternExample:ITestExample
	{
		private void TestDuck(IDuck duck){

		}

		public void execute ()
		{
			Console.WriteLine("\n###Command Pattern Example -------------\n");
			MallardDuck duck = new MallardDuck ();
			WildTurkey turkey = new WildTurkey ();
			IDuck turkeyAdapter = new TurkeyAdapter (MallardDuck);

			Console.WriteLine("\nDuck says");
			duck.quack ();

			Console.WriteLine("\nTurkey Gobbles");
			turkey.gobble ();

			Console.WriteLine("\nTurkey Adaptet to ad duck quacks");
			turkeyAdapter.quack ();


		}
	}
}

