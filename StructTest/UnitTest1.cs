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

        /// <summary>
        /// Check situation when size less zero
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "The size cannot be less than zero")]
        public void CheckSituationWhenSizeLessZeroAraayStruct()
        {
            IContainer myArrayStruct = new ArrayStruct(-100);
        }

        /// <summary>
        /// Check situation when size equal zero
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "The size cannot be less than zero")]
        public void CheckSituationWhenSizeEqualZeroArrayStruct()
        {
            IContainer myArrayStruct = new ArrayStruct(0);
        }

        /// <summary>
        /// Check correct algoritm summator
        /// </summary>
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

        /// <summary>
        /// Check correct algoritm summator for random value
        /// </summary>
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

        /// <summary>
        /// Check situation when start index more end index
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Incorrect value into start and end index")]
        public void CheckSituationWhenStartIndexMoreEndIndexArrayStruct()
        {
            IContainer myArrayStruct = new ArrayStruct(5);

            foreach (var item in randomValueArray)
            {
                myArrayStruct.Add(item);
            }

            double actualRes = myArrayStruct.GetSum(2, 1);
        }

        /// <summary>
        /// Check situation when start and end index out of range
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Incorrect value into start and end index")]
        public void CheckSituationWhenStartAndEndIndexOutOfRangeArrayStruct()
        {
            IContainer myArrayStruct = new ArrayStruct(5);

            foreach (var item in randomValueArray)
            {
                myArrayStruct.Add(item);
            }

            double actualRes = myArrayStruct.GetSum(1000, 10001);
        }

        #endregion Test for ArrayStruct

        #region Test For DictStruct

        /// <summary>
        /// Check situation when size less zero
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "The size cannot be less than zero")]
        public void CheckSituationWhenSizeLessZeroDictStruct()
        {
            IContainer myDictStruct = new DictStruct(-100);
        }

        /// <summary>
        /// Check situation when size equal zero
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),"The size cannot be less than zero")]
        public void CheckSituatuionWhenSizeEqualZeroDictStruct()
        {
            IContainer myDictStruct = new DictStruct(0);
        }

        /// <summary>
        /// Check situation when summator one element
        /// </summary>
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

        /// <summary>
        /// Check correct summator algorithm
        /// </summary>
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

        /// <summary>
        /// Check situation when start index more end index
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Incorrect value into start and end index")]
        public void CheckWhenStartIndexMoreEndIndexDictStruct()
        {
            IContainer myDictStruct = new DictStruct(5);

            foreach (var item in randomValueArray)
            {
                myDictStruct.Add(item);
            }

            double actualRes = myDictStruct.GetSum(2, 1);
        }

        #endregion Test For DictStruct

        #region Test For LinkedStruct

        /// <summary>
        /// Check situation when size less than zero
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),"The size cannot be less than zero")]
        public void CheckSizeLessZero()
        {
            IContainer myLinkedStruct = new LinkedListStruct(-100);
        }

        /// <summary>
        /// Check situation when size equal zero
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "The size cannot be less than zero")]
        public void CheckSizeEqualZero()
        {
            IContainer myLinkedStruct = new LinkedListStruct(0);
        }

        /// <summary>
        /// Check situation when need calcuation one element
        /// </summary>
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

        /// <summary>
        /// Check correct summation element
        /// </summary>
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

        /// <summary>
        /// Check situation when start index more than end index
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "The Argument out of range")]
        public void CheckSituationWhenStartIndexMoreEndIndex()
        {
            IContainer myLinkedStruct = new LinkedListStruct(5);

            foreach (var item in randomValueArray)
            {
                myLinkedStruct.Add(item);
            }

            double actualValue = myLinkedStruct.GetSum(2, 1);
        }
        /// <summary>
        /// Check situation when index start and end set out of range
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "The Argument out of range")]
        public void CheckStartIndexOutOfRange()
        {
            IContainer myLinkedStruct = new LinkedListStruct(10);

            foreach (var item in randomValueArray)
            {
                myLinkedStruct.Add(item);
            }

            double actualResult = myLinkedStruct.GetSum(100, 1001);
        }

        #endregion Test For LinkedStruct

        #region Test My Struct
        
        /// <summary>
        /// Check situation when user insert size less than zero
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "The size cannot be less than zero")]
        public void CheckIfSizeLessThanZero()
        {
            IContainer myFastContainer = new YourFastStruct(-100);
        }

        /// <summary>
        /// Check situation when user insert size = 0
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "The size cannot be less than zero")]
        public void CheckSituationIfSizeEqualZero()
        {
            IContainer myFastContainer = new YourFastStruct(0);
        }

        /// <summary>
        /// Checko if start index less 0
        /// </summary>
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
        /// <summary>
        /// Check situation When end index more real size
        /// </summary>
        [TestMethod]
        public void CheckSituationWhenEndIndexMoreSize()
        {
            IContainer myFastContainer = new YourFastStruct(5);

            foreach(var item in randomValueArray)
            {
                myFastContainer.Add(item);
            }

            Assert.AreEqual(-81.0,myFastContainer.GetSum(0,100));
        }

        /// <summary>
        /// Check summator where value random 
        /// </summary>
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
        /// <summary>
        /// Check situation if End index less start index
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),"The Start index less end index")]
        public void CheckExceptionOutOfRange()
        {
            IContainer myFastContainer = new YourFastStruct(5);

            foreach (var item in randomValueArray)
            {
                myFastContainer.Add(item);
            }

            double actualValue = myFastContainer.GetSum(2, 1);
        }
        /// <summary>
        /// Validate result summation if start and end index equals.
        /// </summary>
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
        /// <summary>
        /// Check if start and end indexs are size of struct
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "The Start index less end index")]
        public void CheckExceptionOutOfRangeArray()
        {
            IContainer myFastContainer = new YourFastStruct(5);

            foreach (var item in randomValueArray)
            {
                myFastContainer.Add(item);
            }

            double actualValue = myFastContainer.GetSum(6, 10);
        }
        /// <summary>
        /// Method Check situation when start and end indexs out of range
        /// </summary>
        [TestMethod]
        public void CheckSummIfEndIndexOutOfRange()
        {
            IContainer myFastCollection = new YourFastStruct(5);

            foreach (var item in randomValueArray)
            {
                myFastCollection.Add(item);
            }

            Assert.AreEqual(-81.0, myFastCollection.GetSum(-1, 10));
        }
        /// <summary>
        /// Check if start index more end index
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "The start index more end index")]
        public void CheckSituationWhenStartAndEndIndexNotEqual()
        {
            IContainer myFastContainer = new YourFastStruct(5);

            foreach (var item in randomValueArray)
            {
                myFastContainer.Add(item);
            }

            double actualValue = myFastContainer.GetSum(2, 2);
        }

        #endregion Test My Struct
    }
}
