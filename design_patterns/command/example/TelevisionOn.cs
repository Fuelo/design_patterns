using System;

namespace design_patterns.example
{
	public class TelevisionOn:Command
	{
		Television television;
		private bool televisionOn;

		public TelevisionOn (Television television)
		{
			this.television = television;
		}

		public void execute ()
		{
			televisionOn = television.On;
			television.On=true;
		}

		public void undo ()
		{
			television.On = televisionOn;
		}

		public override string ToString(){
			return "Television On";
		}
	}
}

