using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoStructTest
{
    public class ArrayStruct:IContainer
    {
        private double[] arrayContainer;

        private int currentIteration = 0;
        
        public ArrayStruct(int size)
        {
            arrayContainer = new double[size];
        }

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
        //TODO Add additional check for input params
        public double GetSum(int startIndex, int endIndex)
        {
            int newStartIndex = startIndex < 0 ? 0 : startIndex;

            int newEndIndex = endIndex > arrayContainer.Length ? arrayContainer.Length : endIndex;

            return arrayContainer.Skip(newStartIndex+1).Take(newEndIndex).Sum();

        }
    }
}
