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
    /// <summary>
    /// Represents Main UI for BMI Calculator
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();

            // Creates new instance of bmi calculator
            BMICalculator bmiCalculator = new BMICalculator();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeGUI()
        {
            // Tile of form window
            this.Text = "Body Mass Calculator";
        }

        /// <summary>
        /// Gets BMI information on 'Calculate' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            infoLabel.Visible = false;

            if (heightTextbox.Text != "" && weightTextbox.Text != "") {
                DisplayResults();

                bmiCalculator.Unit = ReadMeasurementType();
                bmiCalculator.Weight = ReadWeightInput();
                bmiCalculator.Height = ReadHeightInput();

                // Displays bmi results to user
                bmiResultsLabel.Text = bmiCalculator.CalculateBMI().ToString("f2");

                // Displays weight category results to user
                weightCategoryResultsLabel.Text = bmiCalculator.BMIWeightCategory();

                NormalWeightMessage();
            }
            else
            {
                // Tells user they must enter at least their weight / height
                infoLabel.Visible = true;
            }
        }

        /// <summary>
        /// Reads which measurement type is selected
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Reads height from user
        /// </summary>
        /// <returns></returns>
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

                // get total in in" from ft'in"
                height = (height * 12) + inches;
            }
            else
            {
                // get total in m from cm
                height = (height * 0.01);
            }

            return height;
        }

        /// <summary>
        /// Read weight from user
        /// </summary>
        /// <returns></returns>
        private double ReadWeightInput()
        {
            double weight;
            string input = weightTextbox.Text;

           Double.TryParse(input, out weight);

            return weight;
        }

        /// <summary>
        /// Display the results to user
        /// </summary>
        private void DisplayResults()
        {
            ResultsGroup.Visible = true;

            if (NameTextbox.Text != "")
            {
                // Change text of results group if the user has input a name
                ResultsGroup.Text = "Results for " + NameTextbox.Text;
            }
        }

        /// <summary>
        /// Change labels to metric when that radio button is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            inchesTextbox.Visible = false;
            inchesLabel.Visible = false;
            feetLabel.Text = "cm";
            heightLabel.Text = "cm";
            weightLabel.Text = "kg";
        }

        /// <summary>
        /// Change labels to american when that radio button is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void americanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            inchesTextbox.Visible = true;
            inchesLabel.Visible = true;
            feetLabel.Text = "ft";
            heightLabel.Text = "feet";
            weightLabel.Text = "lbs";
        }

        /// <summary>
        /// Provides weight estimates to the user if they are outside of 'Normal' BMI
        /// </summary>
        private void NormalWeightMessage()
        {
            if (bmiCalculator.CalculateBMI() >= 25.0 || bmiCalculator.CalculateBMI() < 18.5)
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
