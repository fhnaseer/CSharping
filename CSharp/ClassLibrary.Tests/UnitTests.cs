using Moq;

namespace ClassLibrary.Tests;

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
        Mock<IFoo> mock = new();

        // throwing when invoked with specific parameters
        _ = mock.Setup(foo =>
            foo.DoSomething("reset")).Throws<InvalidOperationException>();
        mock.Object.DoSomething("reset");
        _ = Assert.ThrowsException<InvalidOperationException>(() =>
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
        int actual = Math.Add(a, b);

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
