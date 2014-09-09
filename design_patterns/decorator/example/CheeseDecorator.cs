using System;

namespace design_patterns
{
	public class CheeseDecorator: ProductDecorator
	{
		ProductComponent pizzaComponent;

		public CheeseDecorator (ProductComponent component)
		{
			pizzaComponent = component;
		}

		public override float getPrice ()
		{
			return 0.9f+pizzaComponent.getPrice ();
		}

		public override string getDescription ()
		{
			return pizzaComponent.getDescription()+", Cheese";
		}
	}
}

