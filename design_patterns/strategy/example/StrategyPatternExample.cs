using System;

namespace design_patterns.example
{
	public class StrategyPatternExample
	{
        public void execute()
        {
            Console.WriteLine("\n###Strategy Pattern Example -------------\n");

            Character warrior = new Character(new SwordAttackBehaviour(), new ShieldDefenseBehaviour());
            Character magican = new Character(new MagicalAttackBehaviour(), new MagicalDefenseBehaviour());

            Console.WriteLine("Warrior Attacking and Defending -------------");
            warrior.attack();
            warrior.defend();

            Console.WriteLine("Magican Attacking and Defending -------------");
            magican.attack();
            magican.defend();

            Console.WriteLine("Magican has no mana now changing to Bow -------------");
            magican.setAttackBehaviour(new BowAttackBehaviour());
            magican.attack();
        }
	}
}

