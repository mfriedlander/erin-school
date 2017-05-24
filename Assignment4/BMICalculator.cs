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

        public string NormalWeight()
        {
            double bmi = CalculateBMI();
            double lowWeight = 0;
            double highWeight = Weight;
            string highEnd = "";

            while (bmi < 18.5)
            {
                for (int i = 0; lowWeight <= Weight; i++)
                {
                    lowWeight = lowWeight * i;

                    bmi = (lowWeight / (Height * Height)) * 703.0;
                }
                lowWeight.ToString();
            }

            while (bmi > 25.0)
            {
                for (double i = 0; i < Weight; i++)
                {
                    Weight -= i;

                    bmi = (Weight / (Height * Height)) * 703.0;
                }
                highEnd = bmi.ToString();
            }

            return "Normal weight for your height is between " + lowWeight + " and " + highEnd;
        }
    }
}
