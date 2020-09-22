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
                UserOutput(GetUserName());
                Console.ReadKey(true);
            }
            catch
            {
                Console.ReadKey(true);
            }
        }

        private static string GetUserName()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            return userName;
        }

        private static void UserOutput(string userName)
        {
            Console.WriteLine("Hello " + userName.ToString() + "!");
        }
    }
}
