using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using AlgoStructTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StructTest
{
    [TestClass]
    public class UnitTest1
    {
        private double[] randomValueArray;

        [TestInitialize]
        public void InitRandomArray()
        {
            randomValueArray = new[] { 1.0, 1.2, 1.5, 1.6, 2.0, -1.0, -2.0, 10.0, 8.0, -100.0, 1.0 };
        }

        [TestMethod]
        public void TestMethod1()
        {
            IContainer testStruct=new FakeStruct(60*60*24*30);
            for (int i = 0; i < 60*60*24*30+4; i++)
            {
                testStruct.Add(i);
            }
            Assert.IsTrue(testStruct.GetSum(4,104) == 5450);
        }
        #region Test for ArrayStruct
        [TestMethod]
        public void CheckCorrectWorkGetSum()
        {
            IContainer testArrayStruct = new ArrayStruct(5);

            for (int index = 0; index < 10; index++)
            {
                testArrayStruct.Add(index * 1.0);
            }

            Assert.AreEqual(6.0,testArrayStruct.GetSum(-1, 1));
        }

        [TestMethod]
        public void CheckCorrectWorkWithRandomArray()
        {
            IContainer testArrayStruct = new ArrayStruct(5);

            foreach (var item in randomValueArray)
            {
                testArrayStruct.Add(item);
            }

            Assert.AreEqual(-81.0, testArrayStruct.GetSum(0, 5));
        }

        #endregion Test for ArrayStruct

        #region Test For DictStruct
        [TestMethod]
        public void TestDictStructPositiv()
        {
            IContainer testDictStruct = new DictStruct(5);

            for (int index = 0; index < 10; index++)
            {
                testDictStruct.Add(index * 1.0);
            }

            Assert.AreEqual(6.0, testDictStruct.GetSum(-1, 1));
        }

        [TestMethod]
        public void TestingDictionaryValueRandomArray()
        {
            IContainer testDictionaryContainer = new DictStruct(5);

            foreach (var item in randomValueArray)
            {
                testDictionaryContainer.Add(item);
            }

            Assert.AreEqual(-81.0, testDictionaryContainer.GetSum(0, 5));
        }

        #endregion Test For DictStruct

        #region Test For LinkedStruct

        [TestMethod]
        public void TestLinkedStruct()
        {
            IContainer testLinkedStruct = new LinkedListStruct(5);

            for (int index = 0; index < 10; index++)
            {
                testLinkedStruct.Add(index * 1.0);
            }

            Assert.AreEqual(6.0, testLinkedStruct.GetSum(-1, 1));
        }

        [TestMethod]
        public void TestGetSummForRandomValueArray()
        {
            IContainer testLinkedStructure = new LinkedListStruct(5);

            foreach (var item in randomValueArray)
            {
                testLinkedStructure.Add(item);
            }

            Assert.AreEqual(-81.0, testLinkedStructure.GetSum(0, 5));
        }

        #endregion Test For LinkedStruct

        #region Test My Struct
        [TestMethod]
        public void TestMyStruct()
        {

            IContainer testMyStruct = new YourFastStruct(5);

            for (int index = 0; index < 10; index++)
            {
                testMyStruct.Add(index * 1.0);
            }

            Assert.AreEqual(6.0, testMyStruct.GetSum(-1, 1));
        }

        [TestMethod]
        public void TestMyStructWithRandomValue()
        {
            IContainer testMyTestStruct = new YourFastStruct(5);

            foreach (var item in randomValueArray)
            {
                testMyTestStruct.Add(item);
            }

            Assert.AreEqual(-81.0, testMyTestStruct.GetSum(0, 5));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),"The Start index lwss end index")]
        public void CheckExceptionOutOfRange()
        {
            IContainer myFastContainer = new YourFastStruct(5);

            foreach (var item in randomValueArray)
            {
                myFastContainer.Add(item);
            }

            double actualValue = myFastContainer.GetSum(2, 1);
        }

        [TestMethod]
        public void TestCheckIfIndexStartAndEndEquals()
        {
            IContainer myTestCollection = new YourFastStruct(5);

            foreach(var item in randomValueArray.Take(5))
            {
                myTestCollection.Add(item);
            }

            Assert.AreEqual(1.5, myTestCollection.GetSum(1, 2));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "The Start index lwss end index")]
        public void CheckExceptionOutOfRangeArray()
        {
            IContainer myFastContainer = new YourFastStruct(5);

            foreach (var item in randomValueArray)
            {
                myFastContainer.Add(item);
            }

            double actualValue = myFastContainer.GetSum(6, 10);
        }

        #endregion Test My Struct
    }
}
