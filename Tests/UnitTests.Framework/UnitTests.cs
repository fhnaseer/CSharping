using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTests.Framework
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
    }
}
