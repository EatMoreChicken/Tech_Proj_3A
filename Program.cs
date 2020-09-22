/*
Author: Varghese Charly
Date: 09/22/2020
Purpose: The purpose of this project is to practice using method.
The code will ask the user to enter their name and then say hello to the name that they entered.
*/

using System;
using System.IO.Pipes;

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
                /* Runs the "UserOutput" method with the value returned from the "GetUserName" method. */
                UserOutput(GetUserName());
                // Calls the "ExitPrompt" method with the boolean of "false". The use of the boolean is explained in the method.
                ExitPrompt(false);
            }
            
            // Will display an error if an error occurs during the execution of the code.
            catch
            {
                // Calls the "ExitPrompt" with the input boolean of "true". The use of the boolean is explained in the method.
                ExitPrompt(true);
            }
        }

        // Method used to prompt the user to enter their name and return the input.
        private static string GetUserName()
        {
            // Prompting the user to input their name
            Console.WriteLine("What is your name?");
            // Grabbing the user's input and writing it to the string variable "userName"
            string userName = Console.ReadLine();
            // Returning the variable "userName"
            return userName;
        }

        // Method used to print the output to the user. The method takes a string input that it renames "userName".
        private static void UserOutput(string userName)
        {
            // Prints out a hello prompt with the user's name from the variable "userName"
            Console.WriteLine("Hello " + userName.ToString() + "!");
        }

        // Method used to display the exit prompt to the user. The method takes a boolean input called which it remains "error". This is discussed in the method.
        private static void ExitPrompt(bool error)
        {
            /* An If Then statement is used to determine the cause of the exit. If the boolean "error" has the value of "true",
             it means that the exit prompt was caused by an error (in the case of the "Catch" section initiating this method).
            If the boolean is false, it means that the exit was normal, such as then the program is successfully finished doing
            what it needs to do.
            */
            if (error == true)
            {
                // If the "error" boolean is true, it will print the following information with instruction for the user to follow.
                Console.WriteLine("Uh oh! Looks like the program encountered an error.");
                Console.WriteLine("Please ensure that only inputting your name when prompted.");
                Console.WriteLine("The program will now close. Please reopen the program to try again.");
                Console.WriteLine("Press any key to continue...");
            }
            else
            {
                // If the "error" boolean is false, it means that the code is exiting normally. The code with print out instructions for a normal exit.
                Console.WriteLine("The program will now close. Please reopen the program to try again.");
                Console.WriteLine("Press any key to continue...");
            }
            // Waiting for the user to acknowledge before exiting the code.
            Console.ReadKey(true);
        }
    }
}
