using System;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var inputUnit = Console.ReadLine().ToLower();
            var outputUnit = Console.ReadLine().ToLower();

            #region converting to meter

            if (inputUnit == "km")
            {
                number = number / 0.001;
            }
            else if (inputUnit == "mm")
            {
                number /= 1000;
            }
            else if (inputUnit == "cm")
            {
                number /= 100;
            }
            else if (inputUnit == "mi")
            {
                number /= 0.000621371192;
            }
            else if (inputUnit == "ft")
            {
                number /= 3.2808399;
            }
            else if (inputUnit == "in")
            {
                number /= 39.3700787;
            }
            else if (inputUnit == "yd")
            {
                number /= 1.0936133;
            }
            #endregion

            #region converting from m to the desired unit
            if (outputUnit == "km")
            {
                number = number * 0.001;
            }
            else if (outputUnit == "mm")
            {
                number *= 1000;
            }
            else if (outputUnit == "cm")
            {
                number *= 100;
            }
            else if (outputUnit == "mi")
            {
                number *= 0.000621371192;
            }
            else if (outputUnit == "ft")
            {
                number *= 3.2808399;
            }
            else if (outputUnit == "in")
            {
                number *= 39.3700787;
            }
            else if (inputUnit == "yd")
            {
                number *= 1.0936133;
            }
            #endregion

            Console.WriteLine(number + " " + outputUnit);
        }
    }
}
