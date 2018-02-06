using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoStructTest
{
    public class ArrayStruct:IContainer
    {
        /// <summary>
        /// Array double
        /// </summary>
        private double[] arrayContainer;

        /// <summary>
        /// Iteration counter
        /// </summary>
        private int currentIteration = 0;

        /// <summary>
        /// Method which initialize new object array struct
        /// </summary>
        /// <param name="size">Size array structure</param>
        public ArrayStruct(int size)
        {
            if (size > 0)
            {
                arrayContainer = new double[size];
            }
            else
                throw new ArgumentException("The size cannot be less than zero");
        }

        /// <summary>
        /// Methor add value to Array Struct
        /// </summary>
        /// <param name="value">Adding value</param>
        public void Add(double value)
        {
            int sizeArrayContainer = arrayContainer.Length;

            if (currentIteration != sizeArrayContainer)
            {
                arrayContainer[currentIteration] = value;
            }
            else
            {
                arrayContainer = arrayContainer.Skip(1).ToArray();

                Array.Resize(ref arrayContainer, currentIteration);

                arrayContainer[currentIteration - 1] = value;

                currentIteration--;
            }

            currentIteration++;
        }
        /// <summary>
        /// Summator elements into set range
        /// </summary>
        /// <param name="startIndex">Start index for calculation. </param>
        /// <param name="endIndex">End index for calculation</param>
        /// <returns></returns>
        public double GetSum(int startIndex, int endIndex)
        {
            int limitSize = arrayContainer.Length;

            if (startIndex > endIndex || startIndex > limitSize)
                throw new ArgumentOutOfRangeException("Incorrect value into start and end index");

            int newStartIndex = startIndex < 0 ? 0 : startIndex;

            int newEndIndex = endIndex > arrayContainer.Length ? arrayContainer.Length : endIndex;

            if ((newStartIndex + 1) > newEndIndex)
                throw new ArgumentOutOfRangeException("Incorrect value into start and end index");

            if ((newStartIndex + 1) == newEndIndex)
                return arrayContainer[newEndIndex];

            return arrayContainer.Skip(newStartIndex+1).Take(newEndIndex).Sum();

        }
    }
}
