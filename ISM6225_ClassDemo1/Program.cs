// See https://aka.ms/new-console-template for more information
//test
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Please provide your input");

            string userInputToCheck = Console.ReadLine();

            try
            {
                int inputNumberChecked = Convert.ToInt32(userInputToCheck);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}