using System;

namespace design_patterns.example
{
	/// <summary>
	/// This Class shows on an imaginary free programmable remote controller how the command pattern can be applied.
	/// Also the class represents the client in the pattern
	/// </summary>
	public class CommandPatternExample
	{


		public void execute(){
		

			Console.WriteLine("\n###Command Pattern Example -------------\n");
			Invoker remoteTelevisionController=new Invoker();
			Television television = new Television ();
			Console.Write(remoteTelevisionController.ToString());

			Console.WriteLine("\nSetting remote commands\n");
			Command telOn = new TelevisionOn (television);
			Command telOff = new TelevisionOff (television);
			Command volumeUp = new VolumeUp (television);
			Command volumeDown = new VolumeDown (television);

			remoteTelevisionController.setCommand (0, telOn);
			remoteTelevisionController.setCommand (1, telOff);
			remoteTelevisionController.setCommand (2, volumeUp);
			remoteTelevisionController.setCommand (3, volumeDown);
			Console.Write(remoteTelevisionController.ToString());
			Console.Write(television.ToString());

			Console.WriteLine("\n\nPressing Slot1");
			remoteTelevisionController.executeSlot(0);
			Console.Write(television.ToString());


			Console.WriteLine("\n\nPressing Slot3");
			remoteTelevisionController.executeSlot(2);
			Console.Write(television.ToString());

			Console.WriteLine("\n\nUndoing Commands");
			remoteTelevisionController.undoOneStep ();
			remoteTelevisionController.undoOneStep ();
			Console.Write(television.ToString());
		}
	}
}

