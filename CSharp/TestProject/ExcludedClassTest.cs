namespace TestProject;

[TestClass]
public class ExcludedClassTest
{
    [TestMethod]
    public void SomeTest()
    {
        // Arrange,
        ExcludedClass target = new();

        // Act,
        target.IncludedProperty = target.ExcludedProperty;
        target.ExcludedProperty = target.IncludedProperty;

        target.IncludedMethod(target.IncludedProperty);
        target.ExcludedMethod(target.IncludedProperty);
    }
}