using System;

// Singleton Pattern with thread safety and eager instantiation example.

namespace design_patterns
{
	public class Singleton
	{
		static Singleton instance;

		public double Value{ get;  set;}

		private Singleton ()
		{

		}

		public static Singleton getInstance(){
			if(instance==null){
				instance = new Singleton ();
			}
			return instance;
		}

		//synchronize for thread safety
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
		public static Singleton getInstanceSynchronizedComplete(){
			if(instance==null){
				instance = new Singleton ();
			}
			return instance;
		}

		static Object mylock = new Object ();
		//performance optimized synchronize for thread safety only if it is not created
		public static Singleton getInstanceSynchronized(){
			if(instance==null){
				lock (mylock) {
					if (instance == null) {
						instance = new Singleton ();
					}
				}
			}
			return instance;
		}
	}

	//eager instantiation of the Singleton Object to prevent multithreading bugs
	public class SingletonEager
	{
		static SingletonEager instance=new SingletonEager();

		public double Value{ get;  set;}

		private SingletonEager ()
		{

		}

		public static SingletonEager getInstance(){
			return instance;
		}
	}
}

