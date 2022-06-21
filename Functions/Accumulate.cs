using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
	class Accumulate : IFunction
	{
		float IFunction.Apply(List<BasicNumber> arguments)
		{
			float total = 0;
			for (int i = (int)arguments[0]; i <= arguments[1]; i++)
            {
				total += Memory.memory[i];
            }
			return total;
		}
	}
}