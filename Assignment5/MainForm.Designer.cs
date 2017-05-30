namespace Assignment5
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.shoppingListBox = new System.Windows.Forms.ListBox();
            this.shoppingListLabel = new System.Windows.Forms.Label();
            this.inputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.amountComboBox);
            this.inputGroupBox.Controls.Add(this.amountLabel);
            this.inputGroupBox.Controls.Add(this.amountTextBox);
            this.inputGroupBox.Controls.Add(this.descriptionTextBox);
            this.inputGroupBox.Controls.Add(this.descriptionLabel);
            this.inputGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputGroupBox.Location = new System.Drawing.Point(45, 83);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(1178, 333);
            this.inputGroupBox.TabIndex = 0;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Input";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.descriptionLabel.Location = new System.Drawing.Point(75, 91);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(188, 39);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(293, 85);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(768, 53);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(293, 181);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(372, 53);
            this.amountTextBox.TabIndex = 3;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.amountLabel.Location = new System.Drawing.Point(75, 190);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(134, 39);
            this.amountLabel.TabIndex = 4;
            this.amountLabel.Text = "Amount";
            // 
            // amountComboBox
            // 
            this.amountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.amountComboBox.FormattingEnabled = true;
            this.amountComboBox.Items.AddRange(new object[] {
            "cm",
            "ft",
            "g",
            "gal",
            "inch",
            "kg",
            "lb",
            "l",
            "m",
            "oz",
            "piece"});
            this.amountComboBox.Location = new System.Drawing.Point(718, 180);
            this.amountComboBox.Name = "amountComboBox";
            this.amountComboBox.Size = new System.Drawing.Size(344, 54);
            this.amountComboBox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addButton.Location = new System.Drawing.Point(1255, 149);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(294, 136);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Teal;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editButton.Location = new System.Drawing.Point(1255, 312);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(145, 75);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Firebrick;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteButton.Location = new System.Drawing.Point(1406, 312);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(145, 75);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // shoppingListBox
            // 
            this.shoppingListBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingListBox.FormattingEnabled = true;
            this.shoppingListBox.ItemHeight = 42;
            this.shoppingListBox.Location = new System.Drawing.Point(62, 556);
            this.shoppingListBox.Name = "shoppingListBox";
            this.shoppingListBox.Size = new System.Drawing.Size(1472, 760);
            this.shoppingListBox.TabIndex = 5;
            // 
            // shoppingListLabel
            // 
            this.shoppingListLabel.AutoSize = true;
            this.shoppingListLabel.Font = new System.Drawing.Font("Museo Sans Rounded 700", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingListLabel.ForeColor = System.Drawing.Color.Teal;
            this.shoppingListLabel.Location = new System.Drawing.Point(62, 470);
            this.shoppingListLabel.Name = "shoppingListLabel";
            this.shoppingListLabel.Size = new System.Drawing.Size(405, 72);
            this.shoppingListLabel.TabIndex = 6;
            this.shoppingListLabel.Text = "Shopping List";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 1404);
            this.Controls.Add(this.shoppingListLabel);
            this.Controls.Add(this.shoppingListBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.inputGroupBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.ComboBox amountComboBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox shoppingListBox;
        private System.Windows.Forms.Label shoppingListLabel;
    }
}

