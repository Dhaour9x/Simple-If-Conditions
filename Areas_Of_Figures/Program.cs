using System;

namespace Areas_Of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var geometrytype = Console.ReadLine().ToLower();
            if (geometrytype =="square")
            {
                var side = double.Parse(Console.ReadLine());
                Console.WriteLine("area is = " + (side*side));
            }
            else if (geometrytype == "rectangle")
            {
                var side1 = double.Parse(Console.ReadLine());
                var side2 = double.Parse(Console.ReadLine());
                Console.WriteLine("area is = " + (side1 * side2));
            }
            else if (geometrytype == "circle")
            {
                var radius = double.Parse(Console.ReadLine());
                Console.WriteLine("area is = " + (radius*radius*Math.PI));
            }
            else if (geometrytype == "triangle")
            {
                var h = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine("area is = " + ((b * h)/2));
            }
            
        }
    }
}
