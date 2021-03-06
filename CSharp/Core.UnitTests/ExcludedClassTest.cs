﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.UnitTests
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
