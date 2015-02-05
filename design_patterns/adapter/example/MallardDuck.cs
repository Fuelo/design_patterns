using System;

namespace design_patterns.example
{
	public class MallardDuck: IDuck
	{
		public MallardDuck ()
		{

		}
			
		public void quack ()
		{
			throw new NotImplementedException ();
		}

		public void fly ()
		{
			throw new NotImplementedException ();
		}
	}
}