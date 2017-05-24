using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Input
    {
        /// <summary>
        ///  Writes a given message to the console and converts console input to char. 
        /// If input cannot be converted to char, an error message is printed on the console. 
        /// The process is repeated until conversion is succesful.
        /// </summary>
        /// <param name="messageToUser">The string to be printed on the console</param>
        /// <param name="allowedChars">Acceptable chars</param>
        /// <returns>The char value entered by the user</returns>
        public static char ReadCharConsole(string messageToUser, params char[] allowedChars)
        {
            bool done = false;
            char response = ' '; //return value
            for (int i = 0; i < allowedChars.Length; i++)
                allowedChars[i] = char.ToLower(allowedChars[i]);
            do
            {
                Console.WriteLine();
                Console.Write(messageToUser);
                string userInput = Console.ReadLine();
                userInput = userInput.Trim(); //delete spaces at the sides of the line
                userInput = userInput.ToLower(); //change to lower for comparison
                response = userInput[0]; //take the first char of the string
                if ((response == allowedChars[0]) || (response == allowedChars[1]))
                    done = true;
                else
                    Console.WriteLine("Please answer with one of the letters {0} or {1}!",
                     allowedChars[0], allowedChars[1]);
            } while (!done);
            return response;
        }

        /// <summary>
        /// Writes a given message to the console and converts console input to integer. 
        /// If input cannot be converted to integer, an error message is printed on the console. 
        /// The process is repeated until conversion is succesful.
        /// </summary>
        /// <param name="messageToUser">The string to be printed on the console</param>
        /// <returns>The int value entered by the user</returns>
        public static int ReadIntegerConsole(string messageToUser)
        {
            // Declare value to return
            int convertedValue = 0;  //local variable must be initiated.

            //A flag to stop the loop
            bool goodNumber = false;

            // Loop until user input can be converted to integer
            do
            {
                // Display info message on console
                Console.Write(messageToUser);

                // Check if console input can be converted to integer 
                // goodNumber will be true if conversion is successful           
                goodNumber = int.TryParse(Console.ReadLine(), out convertedValue);

                if (!goodNumber)  //same as (goodNumber == false)
                    Console.WriteLine("Input must be an integer. Try again.");

                //If conversion was not succesful, continue with the loop
            } while (!goodNumber);  //means: while (done == false)

            //loop is finished and there is a good number - send it back.
            return convertedValue;
        }

        /// <summary>
        /// Writes a given message to the console and converts console input to decimal. 
        /// If input cannot be converted to decimal, an error message is printed on the console. 
        /// The process is repeated until conversion is succesful.
        /// </summary>
        /// <param name="messageToUser">The string to be printed on the console</param>
        /// <returns>The decimal value entered by the user</returns>
        public static decimal ReadDecimalConsole(string messageToUser)
        {
            // Declare value to return
            decimal convertedValue = 0;  //local variable must be initiated.

            //A flag to stop the loop
            bool goodNumber = false;

            // Loop until user input can be converted to decimal
            do
            {
                // Display info message on console
                Console.Write(messageToUser);

                // Check if console input can be converted to decimal
                // goodNumber will be true if conversion is successful           
                goodNumber = decimal.TryParse(Console.ReadLine(), out convertedValue);

                if (!goodNumber)  //same as (goodNumber == false)
                    Console.WriteLine("Input must be an decimal. Try again.");

                //If conversion was not succesful, continue with the loop
            } while (!goodNumber);  //means: while (done == false)

            //loop is finished and there is a good number - send it back.
            return convertedValue;
        }
    }
}
