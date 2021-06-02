using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine().ToLower();
            var rows = int.Parse(Console.ReadLine());
            var columns = int.Parse(Console.ReadLine());
            switch (type)
            {
                case "premiere":
                    Console.WriteLine(Math.Round((columns*rows*12.00),2).ToString());
                    break;
                case "normal":
                    Console.WriteLine(Math.Round((columns*rows*7.50),2).ToString());
                    break;
                case "discount":
                    Console.WriteLine(Math.Round((columns*rows*5.00),2).ToString());
                    break;
                default:
                    break;
            }
        }
    }
}
