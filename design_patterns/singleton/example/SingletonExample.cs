using System;

namespace design_patterns.example
{
	public class SingletonExample
	{
	
		public void execute(){
			Console.WriteLine("\n###Singleton Pattern Example -------------\n");

			Singleton stdSingleton1 = Singleton.getInstance ();
			Singleton stdSingleton2 = Singleton.getInstance ();

			stdSingleton1.Value = Math.PI;
			Console.WriteLine("\nValue of Singleton 2: "+stdSingleton2.Value +"\n");
		}
	}
}

