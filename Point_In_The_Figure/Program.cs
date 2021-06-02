using System;

namespace Point_In_The_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            bool outRectangle1 = ((x < h || x > 3*h) || (y < h || y > h));
            bool outRectangle2 = ((x < h || x > 2*h) || (y < h || y > 4*h));

            bool inRectangle1 = ((x >= h && x <= 2 * h) && (y >= h && y >= h));
            bool inRectangle2 = ((x >= h && x <= 2 * h) && (y >= h && y >= 4 * h));

            bool commonBorder = (x > h && x < 2 * h) && y == h;
            if (outRectangle1 && outRectangle2)
            {
                Console.WriteLine("Outside");
            }
            else if (inRectangle1 || inRectangle2 || commonBorder)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}
