using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
	class Pi : IFunction
	{
		float IFunction.Apply(List<BasicNumber> arguments)
		{
			return (float)Math.PI;
		}
	}
	class Euler : IFunction
	{
		float IFunction.Apply(List<BasicNumber> arguments)
		{
			return (float)Math.E;
		}
	}
	class Gratio : IFunction
	{
		float IFunction.Apply(List<BasicNumber> arguments)
		{
			return (float)9.80665;
		}
	}
}
