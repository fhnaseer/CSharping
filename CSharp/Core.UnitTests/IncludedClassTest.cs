using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.UnitTests
{
    [TestClass]
    public class IncludedClassTest
    {
        [TestMethod]
        public void SomeTest()
        {
            // Arrange,
            var target = new IncludedClass();

            // Act,
            target.IncludedProperty = target.ExcludedProperty;
            target.ExcludedProperty = target.IncludedProperty;

            target.IncludedMethod(target.IncludedProperty);
            target.ExcludedMethod(target.IncludedProperty);
        }
    }
}
