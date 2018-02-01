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
            DictStruct test = new DictStruct(5);

            test.Add(1.0);

            test.Add(2.0);

            test.Add(3.0);

            test.Add(4.0);

            test.Add(5.0);

            test.Add(6.0);

            test.Add(7.0);
            test.Add(8.0);
            test.Add(9.0);
            test.Add(10.0);

            double summa = test.GetSum(1, 1);
            //Impelement here comparison test, to proof, your struct is Faster of equal in comparison to others.
        }
    }
}
