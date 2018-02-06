using AlgoStructTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Diagnostics;


namespace InsertAndAvgPerfTest
{
    class Program
    {
        public static Stopwatch timer = Stopwatch.StartNew();

        static void Main(string[] args)
        {
            Random rnd = new Random();

            int count = Convert.ToInt16(args[0].Trim());

            ArrayStruct myArrayStruct = new ArrayStruct(count);

            DictStruct myDictStruct = new DictStruct(count);

            FakeStruct myFakeStruct = new FakeStruct(count);

            LinkedListStruct myLinkedStruct = new LinkedListStruct(count);

            YourFastStruct myFastStruct = new YourFastStruct(count);

            Console.WriteLine("Struct Name \t Count \t\t Time Add \t\t Time Sum \t");

            var timer = Stopwatch.StartNew();

            int randomCount = count + 100001;


            TestRun(myArrayStruct, randomCount, "Array Struct");

            TestRun(myDictStruct, randomCount, "Dictionary Struct");

            TestRun(myFakeStruct, randomCount, "Fake Struct");

            TestRun(myLinkedStruct, randomCount, "Linked Struct");

            TestRun(myFastStruct, randomCount, "Fast Struct");

            timer.Stop();

            Console.ReadLine();
        }

        public static void TestRun(AlgoStructTest.IContainer structName, int count, string normalStructName)
        {
           
            
            for (int index = 0 ; index <= count; index++)
            {
                structName.Add(index * 1.0);

            }

            var resultAdd = timer.ElapsedMilliseconds;

            double result = structName.GetSum(0, count);

            var resultSum = timer.ElapsedMilliseconds;

            Console.WriteLine("{0,10} \t {1,10} \t {2,10} \t {3,10} \t", normalStructName, count, resultAdd, resultSum);

           
        }
    }
}
