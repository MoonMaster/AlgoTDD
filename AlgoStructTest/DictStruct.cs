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
                dictionaryContainer.Add(currentIteration, value);
                
            }
            else
            {

                int maxKey = dictionaryContainer.Keys.Max();

                int firstIndex = dictionaryContainer.Keys.Min();

                dictionaryContainer.Remove(firstIndex);

                dictionaryContainer.Add(maxKey + 1, value);

                currentIteration--;
            }
            currentIteration++;
            
        }

        public double GetSum(int startIndex, int endIndex)
        {
            int newIndexStart = startIndex < 0 ? 0 : startIndex;

            int newIndexEnd = endIndex > sizeDictionaryContainer ? sizeDictionaryContainer : endIndex;

            
            return dictionaryContainer.OrderBy(key => key.Key).Skip(newIndexStart + 1).Take(newIndexEnd).Sum(x => x.Value);
        }
    }
}
