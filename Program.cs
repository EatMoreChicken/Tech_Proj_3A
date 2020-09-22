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
            /* Using try catch to ensure that if an error occurs during the execution of the code, mainly if the user enters an unexpected input, the catch will display an error
             instead of the code crashing with no error. */
            try
            {
                UserOutput(GetUserName());
                // Waiting for user input before exiting the program
                ExitPrompt(false);
            }
            
            // Will display an error code if an error occurs during the execution of the code.
            catch
            {
                ExitPrompt(true);
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

        private static void ExitPrompt(bool error)
        {
            if (error == true)
            {
                Console.WriteLine("Uh oh! Looks like the program encountered an error.");
                Console.WriteLine("Please ensure that only inputting your name when prompted.");
                Console.WriteLine("The program will now close. Please reopen the program to try again.");
                Console.WriteLine("Press any key to continue...");
            }
            else
            {
                Console.WriteLine("The program will now close. Please reopen the program to try again.");
                Console.WriteLine("Press any key to continue...");
            }
            Console.ReadKey(true);
        }
    }
}
