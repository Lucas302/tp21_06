using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
	class QuickSelect : IFunction
	{
		static public float Execute(int start, int end, int selectVal)
        {
			int a = start;
			int b = end;
			int n = selectVal;

			float middle = Partition.Execute(a, b);
			if (n == middle)
				return n;
			if (n < middle)
				return QuickSelect.Execute(a, (int)middle, n);
			if (n > middle)
				return QuickSelect.Execute((int)middle, b, n);
			else
				return float.NaN;
		}
		float IFunction.Apply(List<BasicNumber> arguments)
		{
			return Execute((int)arguments[0], (int)arguments[1], (int)arguments[2]);
		}
	}
}