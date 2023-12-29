using System;

namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //reading  the input from user
            //1.number of packs for dog 
            int dogFoodCount = int.Parse(Console.ReadLine());
            //2.number of food for cat
            int catFoodCount = int.Parse(Console.ReadLine());
            //price for single dog food
            double singleDogFoodPrice = 2.5;
            //price for single at food
            double singleCatFoodPrice = 4;
            //logical part for solving the problem
            double totalPriceForDogFood = dogFoodCount * singleDogFoodPrice;
            double totalPriceForCatFood = catFoodCount * singleCatFoodPrice;
            double totalPrice = totalPriceForDogFood + totalPriceForCatFood;
            //print the final result of the console

            Console.WriteLine($"{totalPrice} lv.");

        }
    }
}
