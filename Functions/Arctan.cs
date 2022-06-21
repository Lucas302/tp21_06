using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
	class Arctan : IFunction
	{
		float IFunction.Apply(List<BasicNumber> arguments)
		{
			return (float)Math.Atan(arguments[0]);
		}
	}
}
