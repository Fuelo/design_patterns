using System;

namespace design_patterns
{
	public class PizzaRedSauceComponent : ProductComponent
	{
		public PizzaRedSauceComponent ()
		{
		}

		public override string getDescription(){
			return "red sauce Pizza";
		}

		public override float getPrice ()
		{
			return 3.00f;
		}
	}
}

