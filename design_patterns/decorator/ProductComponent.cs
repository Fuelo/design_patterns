using System;

namespace design_patterns
{
	public abstract class ProductComponent
	{
		public virtual string getDescription(){
			return "default description";
		}

		abstract public float getPrice();
	}
}

