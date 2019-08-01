using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldJenkins;

namespace HelloJenkinsTest
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
