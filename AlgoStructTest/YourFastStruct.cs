using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoStructTest
{
    public class YourFastStruct:IContainer
    {

        private List<double> myFastStruct;

        private int limitSize;

        private int currentIteration = 0;

        public YourFastStruct(int size)
        {
            myFastStruct = new List<double>();

            limitSize = size;
        }

        public void Add(double value)
        {           

            if (currentIteration != limitSize)
            {
                myFastStruct.Add(value);
               

            }
            else
            {

                //myFastStruct = myFastStruct.Skip(1).ToList();

                myFastStruct.RemoveAt(0);               

                myFastStruct.Add(value);

                currentIteration--;
            }

            currentIteration++;
        }

        public double GetSum(int startIndex, int endIndex)
        {
            if (startIndex > endIndex || startIndex > limitSize)
                throw new ArgumentOutOfRangeException("The Start index lwss end index");

            int newStartIndex = startIndex < 0 ? 0 : startIndex;

            int newEndIndex = endIndex > limitSize ? limitSize : endIndex;

            if ((newStartIndex + 1) == newEndIndex)
                return myFastStruct[newEndIndex];

            return myFastStruct.Skip(newStartIndex + 1).Take(newEndIndex).Sum();

            //return myFastStruct.Skip(newStartIndex + 1).Take(newEndIndex).Sum(x => x.Value);

        }       
    }
}
