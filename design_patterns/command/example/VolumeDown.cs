using System;

namespace design_patterns.example
{
	public class VolumeDown : Command
	{
		Television television;
		private int oldVolume;

		public VolumeDown (Television television)
		{
			this.television = television;
		}

		public void execute ()
		{
			oldVolume = television.Volume;
			television.Volume--;
		}

		public void undo ()
		{
			television.Volume = oldVolume;
		}

		public override string ToString(){
			return "Volume Down";
		}
	}
}

