using System;
using System.Diagnostics;

namespace Console.Framework
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var size = IntPtr.Size;
            using (var image = new ImageMagick.MagickImage(@"C:\APEXImage\Data\alpha\bottom.png"))
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                image.Blur(10, 3);
                stopwatch.Stop();
                System.Console.WriteLine($"Blur Time: {stopwatch.ElapsedMilliseconds}");
                image.Write(@"C:\Users\FHZ2\Desktop\blur.png");
            }
        }
    }
}
