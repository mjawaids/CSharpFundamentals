using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpFundamentals.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ArrayInitialize()
        {
            int num = 4;
            int[] var = new int[num];
        }

        [TestMethod]
        public void StringParameter()
        {
            string str = "A string";
            changeString(str);
            Assert.AreNotEqual("Changes string", str);
        }

        private void changeString(string str)
        {
            str = "Changes string";
        }

        [TestMethod]
        public void StringObjectParameter()
        {
            String str = "A string";
            changeString(str);
            Assert.AreNotEqual("Changes string", str);            
        }

        private void changeStringObject(String str)
        {
            str = "Changes string";
        }
    }
}
