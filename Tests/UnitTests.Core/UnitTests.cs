using Library.Core;
using Library.Standard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Core
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Add_Works()
        {
            // Arrange,
            const int expected = 5;
            const int a = 2;
            const int b = 3;

            // Act,
            var actual = Math.Add(a, b);

            // Assert,
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Subtract_Works()
        {
            // Arrange,
            const int expected = -1;
            const int a = 2;
            const int b = 3;

            // Act,
            var actual = AdvancedMath.Subtract(a, b);

            // Assert,
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Exclude_Test()
        {
            // Act,
            Math.About();
        }
    }
}
