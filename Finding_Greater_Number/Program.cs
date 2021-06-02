using System;

namespace Finding_Greater_Number
{
    class Program
    {
        static void Main()
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());

            if (number1 >= number2)
            {
                Console.WriteLine("The Greatest number is:" + number1);
            }
            else
            {
                Console.WriteLine("The Greatest number is:" + number2);
            }
        }
    }
}
