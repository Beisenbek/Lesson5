using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegExp2;
using System.Collections.Generic;

namespace UnitTestRegExp2
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void TestMethod1()
        {
            string text = "123456789111";
            Assert.AreEqual("ok",Program.MyMatch(Program.pattern2, text));
        }
        [TestMethod]
        public void TestMethod2()
        {
            string text = "12345678911!";
            Assert.AreEqual("ok", Program.MyMatch(Program.pattern2, text));
        }
        [TestMethod]
        public void TestMethod3()
        {
            string text = "12345678911!";
            Assert.AreEqual("ok", Program.MyMatch(Program.pattern, text));
        }
        [TestMethod]
        public void TestMethod4()
        {
            List<string> s = new List<string>();
            s.Add("12345678911!");
            s.Add("123456789111");
            s.Add("12345678911a");
            s.Add("12345678911");
            s.Add("123456789113");

            for (int i = 0; i < s.Count; ++i)
            {
                Assert.AreEqual(Program.MyMatch(Program.pattern2,s[i]), Program.MyMatch(Program.pattern, s[i]));
            }
        }
    }
}
