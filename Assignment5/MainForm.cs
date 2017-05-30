using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class MainForm : Form
    {
        ItemManager itemManager = new ItemManager();

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            // Tile of form window
            this.Text = "Shopping List";
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private string ReadDescription()
        {
            if (descriptionTextBox.Text != null)
            {
                itemManager.Get
            }
            else
            {
                return ErrorMessage();
            }
        }

        private double ReadAmount()
        {

        }

        private UnitTypes ReadUnitType()
        {

        }

        private string ErrorMessage()
        {

        }
    }
}
