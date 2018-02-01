using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoStructTest
{
    public class YourFastStruct:IContainer
    {
        //private HashSet<double> hashSetStruct;

        private List<double> stackStruct;

        private int limitSize;

        private int currentIteration = 0;

        public YourFastStruct(int size)
        {
            stackStruct = new List<double>();

            limitSize = size;
        }

        public void Add(double value)
        {
            if (currentIteration != limitSize)
            {
                stackStruct.Add(value);
            }
            else
            {
                stackStruct.RemoveAt(0);

                stackStruct.Add(value);

                currentIteration--;
            }

            currentIteration++;
        }

        public double GetSum(int startIndex, int endIndex)
        {
            int newStartIndex = startIndex < 0 ? 0 : startIndex;

            int newEndIndex = endIndex > limitSize ? limitSize : endIndex;

            return stackStruct.Skip(newStartIndex + 1).Take(endIndex).Sum();
        }
    }
}
