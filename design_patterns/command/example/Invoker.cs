using System;
using System.Collections.Generic;

namespace design_patterns.example
{
	public class Invoker
	{
		private Command[] commandSlots; // 4 free programmable slots (can also be imagined as free setable button skills like Diablo)
		private LinkedList<Command> executedCommands;
		const int defaultSlotAmount=4;

		public Invoker (int slotAmount=defaultSlotAmount)
		{
			commandSlots=new Command[slotAmount];
			executedCommands=new LinkedList<Command>();

			for (int i = 0; i < commandSlots.Length; i++) {
				commandSlots [i] = new EmptyCommand ();
			}
		}

		public void setCommand(int slotNumber, Command command)
		{ 
			commandSlots [slotNumber]=command;
		}

		public void executeSlot(int slotNumber){
			commandSlots [slotNumber].execute ();
			executedCommands.AddLast (commandSlots [slotNumber]);
		}

		public void undoOneStep(){
			executedCommands.Last.Value.undo();
			executedCommands.RemoveLast ();
		}

		public override string ToString(){
			string content="";


			for(int i=0;i<commandSlots.Length;i++){
				content += "Slot " + (i + 1) + " " + commandSlots [i].ToString ()+"\n";
			}

			return content;
		}
	}
}

