using System;

namespace design_patterns
{
	public class BowAttackBehaviour : IAttackBehaviour
	{
		public BowAttackBehaviour ()
		{
		}

		public void attack ()
		{
			Console.WriteLine("attacking with a BOW");
		}
	}
}

