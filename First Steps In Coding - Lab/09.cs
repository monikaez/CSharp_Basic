using System;

namespace _09._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //reading the input from the user
            double size = double.Parse(Console.ReadLine());
            //logical part of solving the problem
            double priceWithoutDiscount = size * 7.61;
            double discount = priceWithoutDiscount * .18;
            //printing the result on the console
            Console.WriteLine($"The final price is:{priceWithoutDiscount - discount} lv.");
            Console.WriteLine($"The discoun is:{discount} lv.");
        }
    }
}
