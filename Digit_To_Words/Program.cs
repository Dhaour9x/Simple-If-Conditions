using System;

namespace Digit_To_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var digit = decimal.Parse(Console.ReadLine());
            if (digit ==1)
            {
                Console.WriteLine("One");
            }
            else if (digit==2)
            {
                Console.WriteLine("Tow");
            }
            else if (digit == 3)
            {
                Console.WriteLine("Three");
            }
            else if (digit == 4)
            {
                Console.WriteLine("Four");
            }
            else if (digit == 5)
            {
                Console.WriteLine("Five");
            }
            else if (digit == 6)
            {
                Console.WriteLine("secs");
            }
            else if (digit == 7)
            {
                Console.WriteLine("Seven");
            }
            else if (digit == 8)
            {
                Console.WriteLine("Eight");
            }
            else if (digit == 9)
            {
                Console.WriteLine("Nine");
            }
            else
            {
                Console.WriteLine("number too big");
            }
        }
    }
}
