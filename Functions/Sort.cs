using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    class Sort : IFunction
    {
        static public float BubbleSort(int start, int end)
        {
            int v = start;
            float temp = 0;
            List<float> listVal = new List<float>();
            while (v < end)
            {
                listVal.Add(Memory.memory[v]) ;
                v++;
            }
            for (int j = 0; j <= listVal.Count -2; j++)
            {
                for (int i = 0; i <= listVal.Count - 2; i++)
                {
                    temp = listVal[i + 1];
                    listVal[i + 1] = listVal[i];
                    listVal[i] = temp;
                }
            }
            return 0;
        }

        static public float Execute(int start, int end)
        {
            float middle;
            if (start == end)
            {
                Console.WriteLine("Sort ended (return 0)");
                return 0;
            }
            middle = Partition.Execute(start, end);
            Sort.Execute(start, (int)middle);
            Sort.Execute((int)middle, end);
            return 1;
        }
        public float Apply(List<BasicNumber> arguments)
        {
           if (arguments.Count < 5)
            {
                return BubbleSort((int)arguments[0], (int)arguments[1]);
            }
            else
            {
                return Execute((int)arguments[0], (int)arguments[1]);
            }
        }
    }
}
