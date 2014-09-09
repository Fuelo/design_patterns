using System;

namespace design_patterns
{
	public class OnionsDecorator: ProductDecorator
	{
		ProductComponent pizzaComponent;

		public OnionsDecorator (ProductComponent component)
		{
			pizzaComponent = component;
		}

		public override float getPrice ()
		{
			return 0.2f+pizzaComponent.getPrice ();
		}

		public override string getDescription ()
		{
			return pizzaComponent.getDescription()+", Onions";
		}
	}
}

