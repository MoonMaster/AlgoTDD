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
                for (int index = 0; index < sizeArrayContainer-1; index++ )
                {
                    arrayContainer[index] = arrayContainer[index + 1];
                }

                arrayContainer[currentIteration-1] = value;

                currentIteration--;
            }

            currentIteration++;
        }

        public double GetSum(int startIndex, int endIndex)
        {
            //check end index and start index???

            return arrayContainer.Skip(startIndex).Take(endIndex).Sum();
            //return 0; // Just to calm up compiler
        }
    }
}
