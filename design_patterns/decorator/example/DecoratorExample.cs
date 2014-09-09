using System;

namespace design_patterns
{
	public class DecoratorExample
	{
		public DecoratorExample ()
		{
		}

		public void execute(){
			Console.WriteLine("\n###Decorator Pattern Example -------------\n");


			ProductComponent pizza1;
			ProductComponent pizza2;

			pizza1 = new PizzaRedSauceComponent ();
			pizza1 = new MushroomsDecorator (pizza1);
			pizza1 = new OnionsDecorator (pizza1);
			pizza1 = new CheeseDecorator (pizza1);

			pizza2 = new PizzaWhiteSauceComponent ();
			pizza2 = new SalamiDecorator (pizza2);
			pizza2 = new CheeseDecorator (pizza2);

			Console.WriteLine (pizza1.getDescription()+"\n");
			Console.WriteLine (pizza2.getDescription()+"\n");

		}
	}
}

