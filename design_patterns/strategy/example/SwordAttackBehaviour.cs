using System;

namespace design_patterns.example
{
	public class SwordAttackBehaviour : IAttackBehaviour
	{
		public void attack ()
		{
			Console.WriteLine("attacking with a SWORD");
		}
	}
}

