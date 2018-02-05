using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoStructTest
{
    public class YourFastStruct:IContainer
    {
        //private HashSet<double> hashSetStruct;

        //private SortedDictionary<int,double> stackStruct;

        private SortedSet<double> structSort;

        private int limitSize;

        private int currentIteration = 0;

        public YourFastStruct(int size)
        {
            //stackStruct = new SortedDictionary<int, double>();

            structSort = new SortedSet<double>();

            limitSize = size;
        }

        public void Add(double value)
        {
            if (currentIteration != limitSize)
            {
                //stackStruct.Add(currentIteration, value);

                structSort.Add(value);
            }
            else
            {
                //stackStruct.Remove(stackStruct.Keys.First());

                //stackStruct.Add(stackStruct.Keys.Max()+1, value);

                structSort.Remove(structSort.First());

                structSort.Add(value);

                currentIteration--;
            }

            currentIteration++;
        }

        public double GetSum(int startIndex, int endIndex)
        {
            int newStartIndex = startIndex < 0 ? 0 : startIndex;

            int newEndIndex = endIndex > limitSize ? limitSize : endIndex;

            //return stackStruct.Skip(newStartIndex + 1).Take(endIndex).Sum(x=> x.Value);

            return structSort.Skip(newStartIndex + 1).Take(newEndIndex).Sum();
        }
    }
}
