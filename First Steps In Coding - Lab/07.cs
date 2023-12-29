using System;

namespace _07._Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read the inputs from the user
            //1.name of the architect
            string nameOfArchitect = Console.ReadLine();
            //2.number ot all projects
            int numberOfProjects = int.Parse(Console.ReadLine());
            //logical solving of the problem
            int individualProjectTime = 3;
            int timeForAllProjects = numberOfProjects * individualProjectTime;
            //printing results
            Console.WriteLine($"The architect {nameOfArchitect} will need {timeForAllProjects} hours to complete {numberOfProjects} project/s.");
        }
    }
}
