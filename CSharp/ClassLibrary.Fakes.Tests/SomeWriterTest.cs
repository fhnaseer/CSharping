namespace ClassLibrary.Fakes.Tests;

[TestClass]
public class SomeWriterTest
{
    [TestMethod]
    public void SomeTest()
    {
        // Arrange,
        const string expected = "something";
        StubIDataProvider dataProvider = new()
        {
            GetData = () => expected
        };
        SomeWriter target = new(dataProvider);

        // Act,
        string actual = target.GetLog();

        // Assert,
        Assert.AreEqual(expected, actual);
    }
}