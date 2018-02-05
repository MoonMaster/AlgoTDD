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

            //YourFastStruct test = new YourFastStruct(5);

            //test.Add(1.0);

            //test.Add(2.0);

            //test.Add(3.0);

            //test.Add(4.0);

            //test.Add(5.0);

            //test.Add(6.0);

            //test.Add(7.0);
            //test.Add(8.0);
            //test.Add(9.0);
            //test.Add(10.0);

            //double summa = test.GetSum(-1, 1);
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
