using System;

namespace design_patterns
{
	public class NormalSingleton
	{
		static NormalSingleton instance;

		public double Value{ get;  set;}

		private NormalSingleton ()
		{

		}

		public static NormalSingleton getInstance(){
			if(instance==null){
				instance = new NormalSingleton ();
			}
			return instance;
		}
	}
}

