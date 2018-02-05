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

            //int randomCount = count + rnd.Next();

            var timer = Stopwatch.StartNew();

            int randomCount = count + 100001;


            TestRun(myArrayStruct, randomCount, "Array Struct");

            TestRun(myDictStruct, randomCount, "Dictionary Struct");

            TestRun(myFakeStruct, randomCount, "Fake Struct");

            TestRun(myLinkedStruct, randomCount, "Linked Struct");

            TestRun(myFastStruct, randomCount, "Fast Struct");

            timer.Stop();

            //var randomValueArray = new[] { 1.0, 1.2, 1.5, 1.6, 2.0, -1.0, -2.0, 10.0, 8.0, -100.0, 1.0 };

            //YourFastStruct testDict = new YourFastStruct(5);

            //foreach (var item in randomValueArray)
            //{
            //    testDict.Add(item);
            //}

            //double sumRes = testDict.GetSum(0, 5);

            //double summa = testDict.GetSum(-1, 1);
            //Impelement here comparison test, to proof, your struct is Faster of equal in comparison to others.

            Console.ReadLine();
        }

        public static void TestRun(AlgoStructTest.IContainer structName, int count, string normalStructName)
        {
            Random rnd = new Random();          
            
            for (int index = 0 ; index <= count; index++)
            {
                //structName.Add(index * 1.0);

                structName.Add(rnd.NextDouble());

            }

            var resultAdd = timer.ElapsedMilliseconds;

            double result = structName.GetSum(0, count);

            var resultSum = timer.ElapsedMilliseconds;

            Console.WriteLine("{0,10} \t {1,10} \t {2,10} \t {3,10} \t", normalStructName, count, resultAdd, resultSum);

           
        }
    }
}
