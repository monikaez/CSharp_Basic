using System;

namespace _04.inch_ti_cm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read the input from the user
            double number = double.Parse(Console.ReadLine());
            //logical conversion
            double inches = 2.54;
            double centimeters = number * inches;
            //printing result
            Console.WriteLine(centimeters);
        }               
    }
}