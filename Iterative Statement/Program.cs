// Author: Mark Shim
// Date: 9/9/2019
// Comments: This C# Console application code demonstrates
// the use of iterative statements after getting input from users
using System;

namespace Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input

            Console.WriteLine("PLease enter an integer value between 1 and 100");

            // Use the try catch block to validate user input.
            // If the user provides bad input, the catch block
            // will handle the error and a message will be displayed.

            try
            {
                // This variable will gather data from user input
                string input = Console.ReadLine();
                //This variable will be used to perform the following iterative statement
                // and is paired as an iteger
                int value_of_input = int.Parse(input);

                // This is an iterative statement used to test the values of user input.
                // Depending on the value of the user input between 1 and 100, 
                // a for loop will execute

                // If the value of the user is between 1 and 100, execute the for loop
                if ((value_of_input >= 1) && (value_of_input <= 100))
                {

                    Console.WriteLine("You have entered " + value_of_input + ".");
                    // Here is the For Loop
                    for (int i = 1; i <= value_of_input; i++)
                    {
                        Console.WriteLine( "You have entered "+ value_of_input +". This is the current integer value in the loop:" + i);

                    }
                    Console.WriteLine("Press any key to Exit the program....");
                    Console.ReadKey(true);
                } 
                else
                {
                    Console.WriteLine(" Please, enter an integer between 1 and 100 and try again...");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }
            }
            catch
            {
            }
        }
    }
}
                    


                