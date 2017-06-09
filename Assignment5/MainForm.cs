using System;
using System.Windows.Forms;

namespace Assignment5
{
    /// <summary>
    /// Shopping form.
    /// </summary>
    public partial class MainForm : Form
    {
        ItemManager itemManager;

        /// <summary>
        /// Constructs a new instance of MainForm.
        /// </summary>
        public MainForm()
        {
            // Create a new item manager instance.
            itemManager = new ItemManager();

            InitializeComponent();
            // Populates dropdown list with values from the UnitTypes enumeration
            amountDropDownList.DataSource = Enum.GetValues(typeof(UnitTypes));

            InitializeGUI();
        }

        /// <summary>
        /// Initializes the form view.
        /// </summary>
        private void InitializeGUI()
        {
            // Tile of form window
            this.Text = "Shopping List";
        }

        /// <summary>
        /// Handles the click event of the add button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            // Get shopping item from GetItem()
            ShoppingItem newItem = GetItem();

            // Add new item to item manager
            itemManager.AddItem(newItem);

            // Force list to re-render
            RenderList();
        }

        /// <summary>
        /// Handles the click event of the edit button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {
            // Get index of selected item in list
            int index = ShoppingListBox.SelectedIndex;

            // If no item is selected, take no action.
            // If an item is selected, get shopping item from user inputs (GetItem) and update
            // item at selected index.
            if (index >= 0)
            {
                itemManager.ChangeItem(GetItem(), index);
                RenderList();
            }
        }

        /// <summary>
        /// Handles the click event of the delete button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Get index of selected item in list
            int index = ShoppingListBox.SelectedIndex;

            // If no item is selected, take no action.
            // If an item is selected, remove shopping item from list at selected index.
            if (index >= 0)
            {
                itemManager.DeleteItem(index);
                RenderList();
            }

            RenderList();
        }

        /// <summary>
        /// Gets a new shopping item from the user's input.
        /// </summary>
        /// <returns>A shopping item.</returns>
        private ShoppingItem GetItem()
        {
            string description = "N/A";
            double amount = 0;
            UnitTypes unit = UnitTypes.cm;

            // Get description from input
            if (!string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                description = descriptionTextBox.Text;
            }

            // Get text amount from input, ensure that input is a double, default to 0
            Double.TryParse(amountTextBox.Text, out amount);

            // Get text unittype from input, ensure that input is enum, default to first unittype
            Enum.TryParse<UnitTypes>(amountDropDownList.SelectedValue.ToString(), out unit);

            // Create new ShoppingItem given valid inputs (or default) and return
            ShoppingItem newItem = new ShoppingItem(description, amount, unit);

            return newItem;
        }

        /// <summary>
        /// Clears inputs and re-renders the shopping list component.
        /// </summary>
        private void RenderList()
        {
            descriptionTextBox.Text = string.Empty;
            amountTextBox.Text = string.Empty;
            amountDropDownList.SelectedIndex = 0;
           
            ShoppingListBox.DataSource = null;
            ShoppingListBox.DataSource = itemManager.GetItemInfoStrings();
            ShoppingListBox.Refresh();
        }
    }
}
