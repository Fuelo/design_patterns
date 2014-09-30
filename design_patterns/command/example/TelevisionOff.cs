using System;

namespace design_patterns.example
{
	public class TelevisionOff :Command
	{
		Television television;
		private bool televisionOn;

		public TelevisionOff (Television television)
		{
			this.television = television;
		}

		public void execute ()
		{
			televisionOn = television.On;
			television.On=false;
		}

		public void undo ()
		{
			television.On = televisionOn;
		}

		public override string ToString(){
			return "Television Off";
		}
	}
}

