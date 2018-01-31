using AlgoStructTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;


namespace InsertAndAvgPerfTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayStruct test = new ArrayStruct(2);

            test.Add(1.0);

            test.Add(2.0);

            test.Add(3.0);

            test.Add(4.0);

            double summa = test.GetSum(1, 1);
            //Impelement here comparison test, to proof, your struct is Faster of equal in comparison to others.
        }
    }
}
