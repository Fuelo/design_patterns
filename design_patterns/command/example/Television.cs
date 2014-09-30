using System;

namespace design_patterns.example
{
	public class Television
	{
		public int Volume{ get; set; }
		public bool On{ get; set;}

		public Television(){
			On = false;
			Volume = 15;
		}

		public override string ToString(){
			return string.Format("Television on: {0}, Volume is {1}",On,Volume);
		}
	}
}

