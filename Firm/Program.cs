using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            var projectHours = int.Parse(Console.ReadLine());
            var avalaibleDays = int.Parse(Console.ReadLine());
            var overtimeWorkers = int.Parse(Console.ReadLine());

            var workDays = avalaibleDays * 0.10;
            var overtimeHours = avalaibleDays * 2 * overtimeWorkers;
            var workHours = workDays *8 + overtimeHours;
            var totalHours = Math.Floor(workHours + overtimeHours);
            if (projectHours<=totalHours)
            {
                Console.WriteLine("Yes!{} hours left.", projectHours - totalHours);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", projectHours - totalHours);
            }
        }
    }
}
