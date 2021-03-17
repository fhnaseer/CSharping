using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Framework.Library
{
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
            var list = new List<string>();
            list.Where(x => x == "test").FirstOrDefault();
        }

        private static void SomeMethod()
        {
            var list = new List<string>();
        }
    }
}
