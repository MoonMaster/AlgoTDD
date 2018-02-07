using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoStructTest
{
    public class DictStruct:IContainer
    {
        /// <summary>
        /// Dictionary using this class. Key - int, value - double
        /// </summary>
        private Dictionary<int, double> dictionaryContainer;

        /// <summary>
        /// Current Iteration
        /// </summary>
        private int currentIteration = 0;

        private int sizeDictionaryContainer;

        /// <summary>
        /// Method which initialize Dictionary Struct
        /// </summary>
        /// <param name="size">Size dictionary</param>
        public DictStruct(int size)
        {
            if (size > 0 && size < int.MaxValue)
            {
                dictionaryContainer = new Dictionary<int, double>();

                sizeDictionaryContainer = size;
            }
            else
                throw new ArgumentException("The size cannot be less than zero");
        }

        /// <summary>
        /// Method add value to Dictionary Struct
        /// </summary>
        /// <param name="value">Adding Value</param>
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

        /// <summary>
        /// Method calculation elemen into set range
        /// </summary>
        /// <param name="startIndex">Start Index element</param>
        /// <param name="endIndex">End Index element</param>
        /// <returns>Sum of elements</returns>
        public double GetSum(int startIndex, int endIndex)
        {
            if (startIndex > endIndex || startIndex > sizeDictionaryContainer)
                throw new ArgumentOutOfRangeException("Incorrect value into start and end index");

            int newIndexStart = startIndex < 0 ? 0 : startIndex;

            int newIndexEnd = endIndex > sizeDictionaryContainer ? sizeDictionaryContainer : endIndex;

            if ((newIndexStart + 1) > newIndexEnd)
                throw new ArgumentOutOfRangeException("Incorrect value into start and end index");

            
            return dictionaryContainer.OrderBy(key => key.Key).Skip(newIndexStart + 1).Take(newIndexEnd).Sum(x => x.Value);
        }
    }
}
