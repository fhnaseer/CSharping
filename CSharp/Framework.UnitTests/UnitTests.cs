using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace Framework.UnitTests
{
    public interface IFoo
    {
        void DoSomething(string text);
    }

    [TestClass]
    public class UnitTests
    {
        [ExpectedException(typeof(InvalidOperationException))]
        [TestMethod]
        public void TestMethod1()
        {
            var mock = new Mock<IFoo>();

            // throwing when invoked with specific parameters
            mock.Setup(foo =>
                foo.DoSomething("reset")).Throws<InvalidOperationException>();
            mock.Object.DoSomething("reset");
            Assert.ThrowsException<InvalidOperationException>(() =>
                mock.Object.DoSomething("reset"));
        }

        [TestMethod]
        public void Add_Works()
        {
            // Arrange,
            const int expected = 5;
            const int a = 2;
            const int b = 3;

            // Act,
            var actual = Library.Math.Add(a, b);

            // Assert,
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Exclude_Test()
        {
            // Act,
            Library.Math.About();
        }
    }
}
