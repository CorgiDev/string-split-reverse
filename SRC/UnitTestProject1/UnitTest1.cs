using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringSplit;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Class1 _split;
        [TestInitialize]
        public void Init()
        {
            _split = new Class1();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var output = _split.SplitString("The cat goes");
            Assert.AreEqual("ehT tac seog", output);
        }
    }
}
