using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoStructTest
{
    public class LinkedListStruct:IContainer
    {
		/// <summary>
		/// Linked List using this class
		/// </summary>
        private LinkedList<double> linkedListStruct;

		/// <summary>
		/// Limit size of LinkedList
		/// </summary>
        private int limitSize;

		/// <summary>
		/// Current iteration
		/// </summary>
        private int currentIteration;

		/// <summary>
		/// Constructor for this class
		/// </summary>
		/// <param name="size"> Size of Linked List</param>
        public LinkedListStruct(int size)
        {
            if (size > 0 && size < int.MaxValue)
            {
                linkedListStruct = new LinkedList<double>();

                limitSize = size;
            }
            else
                throw new ArgumentException("The size cannot be less than zero");
        }

		/// <summary>
		/// Method add value into Linked List
		/// </summary>
		/// <param name="value">Adding value</param>
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

		/// <summary>
		/// Summation of elements in a given range
		/// </summary>
		/// <param name="startIndex">Start index summation</param>
		/// <param name="endIndex">End index summation</param>
		/// <returns>Summation of elements</returns>
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
