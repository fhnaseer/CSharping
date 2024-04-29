using System.Diagnostics.CodeAnalysis;

namespace ClassLibrary;

public static class Math
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    [ExcludeFromCodeCoverage]
    public static void About()
    {
        List<string> list = [];
        _ = list.Where(x => x == "test").FirstOrDefault();
    }

    private static void SomeMethod()
    {
        _ = new List<string>();
    }
}