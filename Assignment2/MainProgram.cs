using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            // Create new instance of 
            TemperatureConverter temperatureConverter = new TemperatureConverter();

            temperatureConverter.Start();
        }
    }
}
