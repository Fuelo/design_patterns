using System;

namespace design_patterns
{
	public class PizzaWhiteSauceComponent : ProductComponent
	{
		public PizzaWhiteSauceComponent ()
		{
		}

		public override string getDescription(){
			return "white sauce Pizza";
		}

		public override float getPrice ()
		{
			return 4.00f;
		}
	}
}

