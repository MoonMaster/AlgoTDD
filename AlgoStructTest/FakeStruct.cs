using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoStructTest
{
    public class FakeStruct:IContainer
    {
        public FakeStruct(int size)
        {
        }

        public void Add(double value)
        {
            //Do nothing
        }

        public double GetSum(int startIndex, int endIndex)
        {
            return Enumerable.Range(5, 100).Sum();
        }
    }
}
