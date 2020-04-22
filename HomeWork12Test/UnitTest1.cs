using System;
using System.IO;
using HomeWork12;
using NUnit.Framework;

namespace HomeWork12Test
{
    [TestFixture]
    public class UnitTestHW12
    {
        [Test]
        public void TestInputDayMethod()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                new Menu().InputDay();
            
                string result = sw.ToString();
                Assert.AreEqual("40", result);
            }
        }
    }
}
