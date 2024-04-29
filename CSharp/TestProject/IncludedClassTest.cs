namespace TestProject;

[TestClass]
public class IncludedClassTest
{
    [TestMethod]
    public void SomeTest()
    {
        // Arrange,
        IncludedClass target = new();

        // Act,
        target.IncludedProperty = target.ExcludedProperty;
        target.ExcludedProperty = target.IncludedProperty;

        target.IncludedMethod(target.IncludedProperty);
        target.ExcludedMethod(target.IncludedProperty);
    }
}