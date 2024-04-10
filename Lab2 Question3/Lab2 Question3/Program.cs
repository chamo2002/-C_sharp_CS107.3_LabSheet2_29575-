using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureTracker tracker = new TemperatureTracker();
            tracker.DailyTemperature();
            tracker.Report();



            Console.ReadLine();
        }
    }
}
