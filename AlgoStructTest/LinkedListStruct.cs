using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoStructTest
{
    public class LinkedListStruct:IContainer
    {
        private LinkedList<double> linkedListStruct;

        private int limitSize;

        private int currentIteration;

        public LinkedListStruct(int size)
        {
            linkedListStruct = new LinkedList<double>();

            limitSize = size;
        }

        public void Add(double value)
        {
            if (currentIteration == 0)
            {
                linkedListStruct.AddFirst(value);
            }
            else if (currentIteration != limitSize)
            {
                linkedListStruct.AddLast(value);
            }
            else
            {
                linkedListStruct.RemoveFirst();

                linkedListStruct.AddLast(value);

                currentIteration--;
            }

            

            currentIteration++;
        }

        public double GetSum(int startIndex, int endIndex)
        {

            int newStartIndex = startIndex < 0 ? 0 : startIndex;

            int newEndIndex = endIndex > limitSize ? limitSize : endIndex;

            return linkedListStruct.Skip(newStartIndex + 1).Take(newEndIndex).Sum();
        }
    }
}
