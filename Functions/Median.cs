using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
	class Median : IFunction
	{
		float IFunction.Apply(List<BasicNumber> arguments)
		{
			return QuickSelect.Execute((int)arguments[0], (int)arguments[1], (int)arguments[1] - (int)arguments[0]);
		}
	}
}
