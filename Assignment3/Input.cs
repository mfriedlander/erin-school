using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Input
    {
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
    }
}
