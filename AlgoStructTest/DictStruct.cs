using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoStructTest
{
    public class DictStruct:IContainer
    {
        private Dictionary<int, double> dictionaryContainer;

        private int currentIteration = 0;

        private int sizeDictionaryContainer;

        public DictStruct(int size)
        {
            dictionaryContainer = new Dictionary<int, double>();

            sizeDictionaryContainer = size;
        }

        public void Add(double value)
        {
            if (currentIteration != sizeDictionaryContainer)
            {
                //dictionaryContainer.Add(currentIteration, value);
                dictionaryContainer[currentIteration] = value;
            }
            else
            {

                int firstIndex = dictionaryContainer.Keys.First();

                dictionaryContainer.Remove(firstIndex);


                for (int index = 1; index < sizeDictionaryContainer; index++ )
                {
                    dictionaryContainer[index - 1] = dictionaryContainer[index];
                }

                dictionaryContainer[currentIteration] = value;

                currentIteration--;
            }
            currentIteration++;
            //Put your code here
        }

        public double GetSum(int startIndex, int endIndex)
        {
            return dictionaryContainer.Skip(startIndex).Take(endIndex).Sum(x => x.Value);
            //Put your code here
           // return 0; // Just to calm up compiler
        }
    }
}
