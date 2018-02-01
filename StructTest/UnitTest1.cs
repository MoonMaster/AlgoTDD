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

            for (int index = 0; index <= 10; index++)
            {
                testArrayStruct.Add(index * 1.0);
            }

            Assert.AreEqual(testArrayStruct.GetSum(-1, 1), 6.0);
        }

        #endregion Test for ArrayStruct

        #region Test For DictStruct
        [TestMethod]
        public void TestDictStructPositiv()
        {
            IContainer testDictStruct = new DictStruct(5);

            for (int index = 0; index <10; index++)
            {
                testDictStruct.Add(index * 1.0);
            }

            Assert.AreEqual(4.0, testDictStruct.GetSum(0, 1));
        }
        #endregion Test For DictStruct
    }
}
