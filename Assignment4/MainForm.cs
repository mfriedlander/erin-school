using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();

            BMICalculator bmiCalculator = new BMICalculator();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeGUI()
        {
            this.Text = "Body Mass Calculator";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            infoLabel.Visible = false;

            if (heightTextbox.Text != "" && weightTextbox.Text != "") {
                DisplayResults();

                bmiCalculator.Unit = ReadMeasurementType();
                bmiCalculator.Weight = ReadWeightInput();
                bmiCalculator.Height = ReadHeightInput();

                bmiResultsLabel.Text = bmiCalculator.CalculateBMI().ToString("f2");
                weightCategoryResultsLabel.Text = bmiCalculator.BMIWeightCategory();

                NormalWeightMessage();
            }
            else
            {
                infoLabel.Visible = true;
            }
        }

        private UnitTypes ReadMeasurementType()
        {
            if (americanRadioButton.Checked)
            {
                return UnitTypes.American;
            }
            else
            {
                return UnitTypes.Metric;
            }
        }

        private double ReadHeightInput()
        {
            double height;
            double inches;
            string heightInput = heightTextbox.Text;
            string inchesInput = inchesTextbox.Text;

            Double.TryParse(heightInput, out height);

            if (americanRadioButton.Checked)
            {
                Double.TryParse(inchesInput, out inches);

                height = (height * 12) + inches;
            }
            else
            {
                height = (height * 0.01);
            }

            return height;
        }

        private double ReadWeightInput()
        {
            double weight;
            string input = weightTextbox.Text;

           Double.TryParse(input, out weight);

            return weight;
        }

        private void DisplayResults()
        {
            ResultsGroup.Visible = true;
            if (NameTextbox.Text != "")
            {
                ResultsGroup.Text = "Results for " + NameTextbox.Text;
            }
        }

        private void metricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            inchesTextbox.Visible = false;
            inchesLabel.Visible = false;
            feetLabel.Text = "cm";
            heightLabel.Text = "cm";
            weightLabel.Text = "kg";
        }

        private void americanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            inchesTextbox.Visible = true;
            inchesLabel.Visible = true;
            feetLabel.Text = "ft";
            heightLabel.Text = "feet";
            weightLabel.Text = "lbs";
        }

        private void NormalWeightMessage()
        {
            if (bmiCalculator.CalculateBMI() >= 25.0 || bmiCalculator.CalculateBMI() <18.5)
            {
                normalWeightLabel.Text = bmiCalculator.NormalWeight();
            }

            else
            {
                normalWeightLabel.Text = "Your weight is within the normal range for your height.";
            }
        }
    }
}
