using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise6._2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPush()
        {
            STACK s = new STACK();
            s.push(1);
            s.push(2);
            s.push(3);
            Assert.AreEqual(3, s.pop());
            Assert.AreEqual(2, s.pop());
        }
    }
}
