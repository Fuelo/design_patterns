using System;

namespace design_patterns
{
	public interface Command
	{
		void execute();
		void undo();
	}
}

