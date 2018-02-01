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
            dictionaryContainer = new Dictionary<int, double>(size);

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

                //dictionaryContainer = dictionaryContainer.Skip(1).ToDictionary;



                dictionaryContainer.Remove(dictionaryContainer.Keys.First());

                //int lastKey = dictionaryContainer.Keys.Last();

                //dictionaryContainer.Add(lastKey + 1, value);

                dictionaryContainer[currentIteration] = value;

                dictionaryContainer.OrderBy(key => key.Key);

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
