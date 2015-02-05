using System;

namespace design_patterns.example
{
	public class TurkeyAdapter: IDuck
	{
		ITurkey turkey;

		public TurkeyAdapter (ITurkey turkey)
		{
			this.turkey = turkey;
		}

		public void quack ()
		{
			turkey.gobble ();
		}

		public void fly ()
		{
			turkey.fly ();
		}
	}
}

