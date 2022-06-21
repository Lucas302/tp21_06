using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    class StalinSort : IFunction
    {
        float IFunction.Apply(List<BasicNumber> arguments)
        {
            float temp = Memory.memory[(int)arguments[0]];
            for (int i = (int)arguments[0]+1; i <= arguments[1]; i++)
            {
                if (Memory.memory[i] < temp)
                    Memory.memory[i] = float.NaN;
                else
                    temp = Memory.memory[i];
            }
            return 0;
        }
    }
}
