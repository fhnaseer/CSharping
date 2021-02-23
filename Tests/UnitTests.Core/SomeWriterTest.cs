using Library.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Core
{
    [TestClass]
    public class LogWriterTest
    {
        public class MockDataProvider : IDataProvider
        {
            private string _data = "something";

            public void AddData(string data)
            {
                _data = data;
            }

            public string GetData()
            {
                return _data;
            }
        }

        [TestMethod]
        public void SomeTest()
        {
            // Arrange,
            const string expected = "something";
            var target = new SomeWriter(new MockDataProvider());

            // Act,
            var actual = target.GetLog();

            // Assert,
            Assert.AreEqual(expected, actual);
        }
    }
}
