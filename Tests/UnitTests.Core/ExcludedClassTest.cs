using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Core
{
    [TestClass]
    public class ExcludedClassTest
    {
        [TestMethod]
        public void SomeTest()
        {
            // Arrange,
            var target = new ExcludedClass();

            // Act,
            target.IncludedProperty = target.ExcludedProperty;
            target.ExcludedProperty = target.IncludedProperty;

            target.IncludedMethod(target.IncludedProperty);
            target.ExcludedMethod(target.IncludedProperty);
        }
    }
}
