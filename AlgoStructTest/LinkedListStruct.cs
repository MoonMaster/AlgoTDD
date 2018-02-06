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
            if (size > 0)
            {
                linkedListStruct = new LinkedList<double>();

                limitSize = size;
            }
            else
                throw new ArgumentException("The size cannot be less than zero");
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
            if (startIndex > endIndex || startIndex > limitSize)
                throw new ArgumentOutOfRangeException("The Argument out of range");

            int newStartIndex = startIndex < 0 ? 0 : startIndex;

            int newEndIndex = endIndex > limitSize ? limitSize : endIndex;

            if ((newStartIndex + 1) > newEndIndex)
                throw new ArgumentOutOfRangeException("The Argument out of range");

            if ((newStartIndex + 1) == newEndIndex)
                return linkedListStruct.ElementAt(newEndIndex);

            return linkedListStruct.Skip(newStartIndex + 1).Take(newEndIndex).Sum();
        }
    }
}
