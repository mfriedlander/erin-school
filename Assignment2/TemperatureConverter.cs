using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class TemperatureConverter
    {
        /// <summary>
        /// Called by the main method to get calculations from user input
        /// </summary>
        public void Start()
        {
            int choice;
            do
            {
                DisplayMenu();
                choice = Input.ReadIntegerConsole("Your Choice: ");

                if (choice == 1)
                {
                    CalculateFahrenheitToCelsius();
                }
                else
                {
                    CalculateCelsiusToFahrenheit();
                }
            } while (choice != 0);

        }

        /// <summary>
        /// Formula to convert the temperature in celsius from the temperature in fahrenheit
        /// </summary>
        /// <returns>double celsius</returns>
        public double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (5.0 / 9.0) * (fahrenheit - 32.0);
            return celsius;
        }

        /// <summary>
        /// Calculates temperature in fahrenheit to celsius
        /// </summary>
        public void CalculateFahrenheitToCelsius()
        {
            double celsiusValue;
            string convertedTemperatures;

            //for (int i = 0; i <= 212; i += 4)
            //{
            //    celsiusValue = FahrenheitToCelsius(i);
            //    convertedTemperatures = string.Format("{0:0.00}°F = " + "{1:0.00}°C", i, celsiusValue);
            //    Console.WriteLine(convertedTemperatures);
            //}
            //Console.WriteLine();


            for (int i = -4; i <= 212; i++)
            {
                if (i % 2 == 0)
                {

                }
                else
                {
                    i--;
                }
                for (int j = 0; j <= 2; j++)
                {
                    celsiusValue = FahrenheitToCelsius(i);
                    convertedTemperatures = string.Format("{0,10:0.00}°F = " + "{1:0.00}°C", i+=4, celsiusValue);
                    Console.Write(convertedTemperatures);
                }
                Console.WriteLine();
            }

            #region Alternative Solution
            //int start = -4; // starting temperature
            //int end = 212; // ending temperature
            //int skip = 4; // how many degrees we should skip between steps
            //int cols = 3; // number of columns to print
            //int rows = ((end - start)/skip)/cols; // number of rows to print

            //for (int i = 0; i <= rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        // row number times total cols + col number, skip every 4, start at -4
            //        int index = (i * cols + j) * skip + start;

            //        // Stop early if we hit the end value (leave empty columns)
            //        if (index > end)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            celsiusValue = FahrenheitToCelsius(index);

            //            // To get the equals sign in the middle we pad the first term left and the whole string right, 
            //            // otherwise (if we only pad the second term right) the "°C" will be after the padding.
            //            convertedTemperatures = string.Format("{0,7:0.00}°F = " + "{1:0.00}°C", index, celsiusValue).PadRight(25);
            //            Console.Write(convertedTemperatures);
            //        }
            //    }
            //    Console.WriteLine();
            //}
            #endregion 
        }

        /// <summary>
        /// Formula to convert the temperature in fahrenheit from the temperature in celsius
        /// </summary>
        /// <returns>double fahrenheit</returns>
        public double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (9.0 / 5.0) * celsius + 32.0;
            return fahrenheit;

        }

        /// <summary>
        /// Calculates temperature in celsius to fahrenheit
        /// </summary>
        public void CalculateCelsiusToFahrenheit()
        {
            double fahrenheitValue;
            string convertedTemperatures;

            for (int i = 0; i <= 100; i += 5)
            {
                fahrenheitValue = CelsiusToFahrenheit(i);
                convertedTemperatures = string.Format("{0:0.00}°C = " + "{1:0.00}°F", i, fahrenheitValue);
                Console.WriteLine(convertedTemperatures);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Display the menu the user will use to choose which calculation they would like to do
        /// </summary>
        public void DisplayMenu()
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("                   MAIN MENU                            ");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Convert Fahrenheit to Celsius: press 1");
            Console.WriteLine("Convert Celsius to Fahrenheit: press 2");
            Console.WriteLine("Exit the Converter:            press 0");
            Console.WriteLine();
        }

    }
}
