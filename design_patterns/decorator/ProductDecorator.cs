using System;

namespace design_patterns
{
	public abstract class ProductDecorator : ProductComponent
	{
		public abstract override string getDescription();
	}
}