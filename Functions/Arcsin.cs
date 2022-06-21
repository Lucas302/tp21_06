using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
	class Arcsin : IFunction
	{
		float IFunction.Apply(List<BasicNumber> arguments)
		{
			return (float)Math.Asin(arguments[0]);
		}
	}
}
