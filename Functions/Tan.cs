using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
	class Tan : IFunction
	{
		float IFunction.Apply(List<BasicNumber> arguments)
		{
			return (float)Math.Tan(arguments[0]);
		}
	}
}
