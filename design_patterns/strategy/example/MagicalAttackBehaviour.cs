using System;

namespace design_patterns
{
	public class MagicalAttackBehaviour: IAttackBehaviour
	{
		public void attack ()
		{
			Console.WriteLine("attacking with a FIREBALL");
		}
	}
}

