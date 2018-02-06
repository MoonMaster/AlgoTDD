using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoStructTest
{
    /// <summary>
    /// Class with realization my fast structure
    /// </summary>
    public class YourFastStruct:IContainer
    {

        private List<double> myFastStruct;

        private int limitSize;

        private int currentIteration = 0;

        /// <summary>
        /// Constructor for my fast Structure
        /// </summary>
        /// <param name="size">Size of structure</param>

        public YourFastStruct(int size)
        {
            if (size > 0)
            {
                myFastStruct = new List<double>();

                limitSize = size;
            }
            else
                throw new ArgumentException("The size cannot be less than zero");
        }
        /// <summary>
        /// Method realizing add element to structure
        /// </summary>
        /// <param name="value">Added value into structure</param>
        public void Add(double value)
        {           

            if (currentIteration != limitSize)
            {
                myFastStruct.Add(value);
               

            }
            else
            {

                myFastStruct.RemoveAt(0);               

                myFastStruct.Add(value);

                currentIteration--;
            }

            currentIteration++;
        }
        /// <summary>
        /// Summation element value in a given range
        /// </summary>
        /// <param name="startIndex">Start position for summation. This element not included into range</param>
        /// <typeparam name="startIndex">The element type of the integer</typeparam>
        /// <param name="endIndex">End position for summation</param>
        /// <typeparam name="endIndex">The element type of the integer</typeparam>
        /// <returns>The result of the summation</returns>
        public double GetSum(int startIndex, int endIndex)
        {
            if (startIndex > endIndex || startIndex > limitSize)
                throw new ArgumentOutOfRangeException("The Start index less end index");

            int newStartIndex = startIndex < 0 ? 0 : startIndex;

            int newEndIndex = endIndex > limitSize ? limitSize : endIndex;

            if ((newStartIndex + 1) > newEndIndex)
                throw new ArgumentOutOfRangeException("The start index more end index");

            if ((newStartIndex + 1) == newEndIndex)
                return myFastStruct[newEndIndex];

            return myFastStruct.Skip(newStartIndex + 1).Take(newEndIndex).Sum();

        }       
    }
}
