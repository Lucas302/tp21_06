using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
	class Partition : IFunction
	{
		static public float Execute(int start, int end)
        {
			int a = start;
			int b = end;
			float pivot = Memory.memory[b - a];
			a--;
			b++;
			while (true)
			{
				do
				{
					a++;
				} while (Memory.memory[a] < pivot);
				do
				{
					b--;
				}
				while (Memory.memory[b] > pivot);
				if (a >= b)
				{
					return b + 1;//à vérifier
				}
				var temp = Memory.memory[a];
				Memory.memory[a] = Memory.memory[b];
				Memory.memory[b] = temp;
			}
		}

		float IFunction.Apply(List<BasicNumber> arguments)
		{
			return Execute((int)arguments[0], (int)arguments[1]);
		}
	}
}