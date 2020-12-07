using Library.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Core
{
    [TestClass]
    public class LogWriterTest
    {
        [TestMethod]
        public void SomeTest()
        {
            // Arrange,
            const string expected = "something";
            var dataProvider = new Library.Core.Fakes.StubIDataProvider
            {
                GetData = () => expected
            };
            var target = new SomeWriter(dataProvider);

            // Act,
            var actual = target.GetLog();

            // Assert,
            Assert.AreEqual(expected, actual);
        }
    }
}
