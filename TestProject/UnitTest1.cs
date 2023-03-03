using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello, World! from shrinidhi";
        [TestMethod]
        public void TestMethod1()
        {
            using(var sw = new StringWriter())
            {
                Console.SetOut(sw);
                SampleDeploymentConsoleApp.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}