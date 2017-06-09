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
        private BMICalculator bmiCalculator;

        /// <summary>
        /// MainForm constructor that runs when GUI is created
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();

            // Creates new instance of bmi calculator
            bmiCalculator = new BMICalculator();
        }

        /// <summary>
        /// Initializes the GUI
        /// </summary>
        private void InitializeGUI()
        {
            // Tile of form window
            this.Text = "Body Mass Index Calculator";
        }

        /// <summary>
        /// Gets BMI information on 'Calculate' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            infoLabel.Visible = false;

            ReadMeasurementType();
            bool validWeight = ReadWeightInput();
            bool validHeight = ReadHeightInput();

            // Ensure valid input
            if (validWeight && validHeight)
            {
                DisplayResults();

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
                ResultsGroup.Visible = false;
            }
        }

        /// <summary>
        /// Reads which measurement type is selected
        /// </summary>
        /// <returns></returns>
        private void ReadMeasurementType()
        {
            if (americanRadioButton.Checked)
            {
                bmiCalculator.Unit = UnitTypes.American;
            }
            else
            {
                bmiCalculator.Unit = UnitTypes.Metric;
            }
        }

        /// <summary>
        /// Reads height from user
        /// </summary>
        /// <returns>True if textbox values can be parsed.</returns>
        private bool ReadHeightInput()
        {
            double primary = 0;
            double secondary = 0;
            string primaryHeight = ValidateNumericTextbox(heightTextbox);
            string secondaryHeight = ValidateNumericTextbox(secondaryHeightTextbox);

            if (!Double.TryParse(primaryHeight, out primary) || !Double.TryParse(secondaryHeight, out secondary))
            {
                return false;
            }
            else
            {
                if (americanRadioButton.Checked)
                {
                    // get total in in" from ft'in"
                    bmiCalculator.Height = (primary * 12) + secondary;
                }
                else
                {
                    // get total in m from m & cm
                    bmiCalculator.Height = primary + (secondary * 0.01);
                } 

                // Ensure that height is a non-zero positive value
                if (bmiCalculator.Height > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Read weight from user
        /// </summary>
        /// <returns></returns>
        private bool ReadWeightInput()
        {
            double weight;
            string input = ValidateNumericTextbox(weightTextbox);

            if (!Double.TryParse(input, out weight) || weight <= 0)
            {
                return false;
            }
            else
            {
                bmiCalculator.Weight = weight;
                return true;
            }
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
            heightTextbox.Text = "";
            secondaryHeightTextbox.Text = "";
            weightTextbox.Text = "";
            heightLbl.Text = "cm";
            feetLabel.Text = "m";
            heightLabel.Text = "( m,cm )";
            weightLabel.Text = "( kg )";
            weightLbl.Text = "kg";
        }

        /// <summary>
        /// Change labels to american when that radio button is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void americanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            heightTextbox.Text = "";
            weightTextbox.Text = "";
            secondaryHeightTextbox.Text = "";
            heightLbl.Text = "in";
            feetLabel.Text = "ft";
            heightLabel.Text = "( ft,in )";
            weightLabel.Text = "( lbs )";
            weightLbl.Text = "lbs";
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

        /// <summary>
        /// Replaces any whitespace in the textboxes with a default value.
        /// </summary>
        /// <param name="textbox"></param>
        /// <returns></returns>
        private string ValidateNumericTextbox(TextBox textbox)
        {
            if (string.IsNullOrWhiteSpace(textbox.Text))
            {
                textbox.Text = "0";
            }

            return textbox.Text;
        }
    }
}
