using System;

namespace design_patterns
{
	public class StrategyPatternExample
	{
		public StrategyPatternExample ()
		{
			Console.WriteLine ("###Strategy Pattern Example -------------");
			Character warrior = new Character (new SwordAttackBehaviour(), new ShieldDefenseBehaviour());
			Character magican = new Character (new MagicalAttackBehaviour(), new MagicalDefenseBehaviour());

			warrior.attack ();
			warrior.defend ();


		}
	}
}

