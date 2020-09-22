/*
Author: Varghese Charly
Date: 09/22/2020
Purpose: The purpose of this project is to practice using method.
The code will ask the user to enter thier name and then say hello to the name that they entered.
*/

using System;

namespace Tech_Proj_3A
{
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                UserPrompt();
                Console.ReadKey(true);
            }
            catch
            {
                Console.ReadKey(true);
            }
        }

        private static void UserPrompt()
        {
            Console.WriteLine("What is your name?");
        }
    }
}
