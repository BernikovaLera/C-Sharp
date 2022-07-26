using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tests
{
[TestClass()]
    public class AbTests
    {
        [TestMethod()]
        public void subTest()
        {
            int a = 2;
            int b = 3;
            int expected = -1;
            int actual;
            actual = Ab.sub(a, b);
            Assert.AreEqual(expected, actual);
            // Assert.Fail();
        }

        [TestMethod()]
        public void subTest1()
        {
            int a = 3;
            int b = 3;
            int expected = 0;
            int actual;
            actual = Ab.sub(a, b);
            Assert.AreEqual(expected, actual);
            // Assert.Fail();
        }
        [TestMethod()]
        public void divTest()
        {
            int a = 9;
            int b = 3;
            int expected = 4;
            int actual;
            actual = Ab.div(a, b);
            Assert.AreEqual(expected, actual);
            // Assert.Fail();
        }
    }
}