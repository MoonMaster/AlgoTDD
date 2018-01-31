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
    }
}
