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

            #region Print in 1 Column
            // This code can be uncommented if you want to print out the results in one column

            //for (int i = 0; i <= 212; i += 4)
            //{
            //    celsiusValue = FahrenheitToCelsius(i);
            //    convertedTemperatures = string.Format("{0:0.00}°F = " + "{1:0.00}°C", i, celsiusValue);
            //    Console.WriteLine(convertedTemperatures);
            //}
            //Console.WriteLine();
            #endregion

            #region Print in 3 Columns
            int start = 0; // starting temperature
            int end = 212; // ending temperature
            int skip = 4; // how many degrees we should skip between steps
            int cols = 3; // number of columns to print
            int rows = ((end - start) / skip) / cols; // number of rows to print

            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // row number times total cols + col number, skip every 4, start at 0
                    int index = (i * cols + j) * skip + start;

                    // Stop early if we hit the end value (leave empty columns)
                    if (index > end)
                    {
                        break;
                    }
                    else
                    {
                        celsiusValue = FahrenheitToCelsius(index);

                        //format the response to right - align string on each side of the equal sign
                        convertedTemperatures = string.Format("{0,10:0.00}°F = " + "{1,6:0.00}°C", index, celsiusValue);
                        Console.Write(convertedTemperatures);
                    }
                }
                Console.WriteLine();
            }
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

            #region Print in 1 Column
            // This code can be uncommented if you want to print out the results in one column

            //for (int i = 0; i <= 100; i += 5)
            //{
            //    fahrenheitValue = CelsiusToFahrenheit(i);
            //    convertedTemperatures = string.Format("{0:0.00}°C = " + "{1:0.00}°F", i, fahrenheitValue);
            //    Console.WriteLine(convertedTemperatures);
            //}
            //Console.WriteLine();
            #endregion

            #region Print in 3 Columns
            int start = 0; // starting temperature
            int end = 100; // ending temperature
            int skip = 5; // how many degrees we should skip between steps
            int cols = 3; // number of columns to print
            int rows = ((end - start) / skip) / cols; // number of rows to print

            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // row number times total cols + col number, skip every 5, start at 0
                    int index = (i * cols + j) * skip + start;

                    // Stop early if we hit the end value (leave empty columns)
                    if (index > end)
                    {
                        break;
                    }
                    else
                    {
                        fahrenheitValue = CelsiusToFahrenheit(index);

                        // format the response to right-align string on each side of the equal sign
                        convertedTemperatures = string.Format("{0,10:0.00}°C = " + "{1,6:0.00}°F", index, fahrenheitValue);
                        Console.Write(convertedTemperatures);
                    }
                }
                Console.WriteLine();
            }
            #endregion
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
