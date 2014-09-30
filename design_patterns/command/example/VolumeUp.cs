using System;

namespace design_patterns.example
{
	public class VolumeUp : Command
	{
		Television television;
		private int oldVolume;

		public VolumeUp (Television television)
		{
			this.television = television;
		}

		public void execute ()
		{
			oldVolume = television.Volume;
			television.Volume++;
		}

		public void undo ()
		{
			television.Volume = oldVolume;
		}

		public override string ToString(){
			return "Volume Up";
		}
	}
}

