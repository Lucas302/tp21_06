using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
	class CylinderVol : IFunction
	{
		float IFunction.Apply(List<BasicNumber> arguments)
		{
			float r = arguments[0];
			float h = arguments[1];
			return r*r*(float)Math.PI*h;
		}
	}
}