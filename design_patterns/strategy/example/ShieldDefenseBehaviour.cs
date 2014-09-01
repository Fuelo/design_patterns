using System;

namespace design_patterns
{
	public class ShieldDefenseBehaviour : IDefenseBehaviour 
	{

		public void defend ()
		{
			Console.WriteLine("blocked with an SHIELD");
		}
	}
}

