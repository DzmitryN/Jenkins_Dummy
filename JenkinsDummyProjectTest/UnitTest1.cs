using System;
using JenkinsDummyProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JenkinsDummyProjectTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World!", Program.CreateMessage());
        }
    }
}
