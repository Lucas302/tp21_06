using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    class M5 : IFunction
    {
        public float Apply(List<BasicNumber> arguments)
        {
            //use sort
            Memory.memory[0] = arguments[0];
            Memory.memory[1] = arguments[1];
            Memory.memory[2] = arguments[2];
            Memory.memory[3] = arguments[3];
            Memory.memory[4] = arguments[4];
            Sort.BubbleSort((int)Memory.memory[0], (int)Memory.memory[5]);
            return Memory.memory[2];
        }
    }
}
