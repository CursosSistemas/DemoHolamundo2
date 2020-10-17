using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoHolamundo2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World1", Program.createMessage());
        }
    }
}
