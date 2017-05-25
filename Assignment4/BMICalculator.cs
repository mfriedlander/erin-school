using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    /// <summary>
    /// Represents a BMI Calculator
    /// </summary>
    class BMICalculator
    {
        private string name = "";
        private double height = 0;
        private double weight = 0;
        private UnitTypes unit;
        private const double lowBmi = 18.5;
        private const double highBmi = 24.9;

        /// <summary>
        /// Gets/Sets Name
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
        }

        /// <summary>
        /// Gets/Sets Height
        /// </summary>
        public double Height
        {
            get { return height; }
            set
            {
                if (value >= 0)
                {
                    height = value;
                }
            }
        }

        /// <summary>
        /// Gets/Sets Weight
        /// </summary>
        public double Weight
        {
            get { return weight; }
            set
            {
                if (value >= 0)
                {
                    weight = value;
                }
            }
        }

        /// <summary>
        /// Gets/Sets Unit
        /// </summary>
        public UnitTypes Unit
        {
            get { return unit;  }
            set
            {
                unit = value;
            }
        }

        /// <summary>
        /// Determines BMI weight category from BMI
        /// </summary>
        /// <returns></returns>
        public string BMIWeightCategory()
        {
            double bmi = CalculateBMI();
            string strOut = string.Empty;

            if (bmi > 40)
            {
                strOut = "Overweight (Obesity class III)";
            }
            else if (bmi < 40 && bmi > 35)
            {
                strOut = "Overweight (Obesity class II)";
            }
            else if (bmi < 35 && bmi > 30)
            {
                strOut = "Overweight (Obesity class I)";
            }
            else if (bmi < 30 && bmi > 25)
            {
                strOut = "Overweight (Pre-obesity)";
            }
            else if (bmi < 25 && bmi >= 18.5)
            {
                strOut = "Normal weight";
            }
            else if (bmi < 18.5)
            {
                strOut = "Underweight";
            }

            return strOut;
        }

        /// <summary>
        /// Calculates BMI from entered weight and height
        /// </summary>
        /// <returns></returns>
        public double CalculateBMI()
        {
            double bmi;

            if (Unit == UnitTypes.Metric)
            {
                bmi = Weight / (Height * Height);
            }
            else
            {
                bmi = (Weight / (Height * Height)) * 703.0;
            }

            return bmi;
        }

        /// <summary>
        /// Determines acceptable weight range for 'Normal' BMI of entered height
        /// </summary>
        /// <returns></returns>
        public string NormalWeight()
        {
            double lowerWeight = 0;
            double upperWeight = 0;
            string unit = "";

            if (Unit == UnitTypes.Metric)
            {
                unit = "kg";

                lowerWeight = lowBmi * (Height * Height);
                upperWeight = highBmi * (Height * Height);
            }
            else
            {
                unit = "lbs";

                lowerWeight = (lowBmi * (Height * Height)) / 703.0;
                upperWeight = (highBmi * (Height * Height)) / 703.0;
            }

            // Returns a string with the lower and upper weight limits for someone of the entered height to be within a normal BMI range
            return "To be within the 'Normal' BMI range, you should weigh between \n" + lowerWeight.ToString("f2") + unit + " and " + upperWeight.ToString("f2") + unit;
        }
    }
}
