using System;

namespace design_patterns
{
	public class SwordAttackBehaviour : IAttackBehaviour
	{
		public void attack ()
		{
			Console.WriteLine("attacking with a SWORD");
		}
	}
}

