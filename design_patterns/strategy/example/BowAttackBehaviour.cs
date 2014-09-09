using System;

namespace design_patterns.example
{
	public class BowAttackBehaviour : IAttackBehaviour
	{
		public void attack ()
		{
			Console.WriteLine("attacking with a BOW");
		}
	}
}

