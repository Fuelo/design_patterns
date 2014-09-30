using System;

namespace design_patterns.example
{
	public class EmptyCommand: Command
	{
		public EmptyCommand ()
		{
		}

		public void execute ()
		{
		}
		public void undo ()
		{
		}

		public override string ToString(){
			return "Empty Command";
		}
	}
}

