using System;

namespace design_patterns.example
{
	public class ShieldDefenseBehaviour : IDefenseBehaviour 
	{

		public void defend ()
		{
			Console.WriteLine("blocked with an SHIELD");
		}
	}
}

