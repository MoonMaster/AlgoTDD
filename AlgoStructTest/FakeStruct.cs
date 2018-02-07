using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoStructTest
{
	/// <summary>
	/// Fake class
	/// </summary>
    public class FakeStruct:IContainer
    {
		/// <summary>
		/// Contstuctor for Fake class
		/// </summary>
		/// <param name="size"></param>
        public FakeStruct(int size)
        {
        }

		/// <summary>
		/// Method Add. Nothing do
		/// </summary>
		/// <param name="value"></param>
        public void Add(double value)
        {
            //Do nothing
        }

		/// <summary>
		/// Method get sum of elements
		/// </summary>
		/// <param name="startIndex">Start index summator</param>
		/// <param name="endIndex">End index summator</param>
		/// <returns>Sum of elements</returns>
        public double GetSum(int startIndex, int endIndex)
        {
            return Enumerable.Range(5, 100).Sum();
        }
    }
}
