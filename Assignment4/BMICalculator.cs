using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class BMICalculator
    {
        private string name = "No Name";
        private double height = 0;
        private double weight = 0;
        private UnitTypes unit;

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

        public UnitTypes Unit
        {
            get { return unit;  }
            set
            {
                unit = value;
            }
        }

        public string BMIWeightCategory()
        {
            double bmi = CalculateBMI();
            string strOut = string.Empty;

            if (bmi > 40)
            {
                strOut = "Overweight (Obesity class III)";
            }
            else if (bmi < 40)
            {
                strOut = "Overweight (Obesity class II)";
            }
            else if (bmi < 35)
            {
                strOut = "Overweight (Obesity class I)";
            }
            else if (bmi < 30)
            {
                strOut = "Overweight (Pre-obesity)";
            }
            else if (bmi < 25)
            {
                strOut = "Normal weight";
            }
            else if (bmi < 18.5)
            {
                strOut = "Underweight";
            }

            return strOut;
        }

        public double CalculateBMI()
        {
            double bmi;

            if (Unit == UnitTypes.American)
            {
                bmi = 703.0 * Weight / (Height * Height);
            }
            else
            {
                bmi = Weight / (Height * Height);
            }

            return bmi;
        }

        public string NormalWeight()
        {
            return string.Empty;
        }
    }
}
