using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Core.Library
{
    public static class Math
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        [ExcludeFromCodeCoverage]
        public static void About()
        {
            var list = new List<string>();
            list.Where(x => x == "test").FirstOrDefault();
        }
    }
}
