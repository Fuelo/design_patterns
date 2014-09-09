using System;

namespace design_patterns
{
	public class MushroomsDecorator: ProductDecorator
	{
		ProductComponent pizzaComponent;

		public MushroomsDecorator (ProductComponent component)
		{
			pizzaComponent = component;
		}

		public override float getPrice ()
		{
			return 0.9f+pizzaComponent.getPrice ();
		}

		public override string getDescription ()
		{
			return pizzaComponent.getDescription()+", Mushrooms";
		}
	}
}

