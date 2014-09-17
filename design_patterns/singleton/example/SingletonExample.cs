using System;

namespace design_patterns.example
{
	public class SingletonExample
	{
	
		public void execute(){
			Console.WriteLine("\n###Singleton Pattern Example -------------\n");

			NormalSingleton stdSingleton1 = NormalSingleton.getInstance ();
			NormalSingleton stdSingleton2 = NormalSingleton.getInstance ();

			stdSingleton1.Value = Math.PI;
			Console.WriteLine("\nValue of Singleton 2: "+stdSingleton2.Value +"\n");
		}
	}
}

