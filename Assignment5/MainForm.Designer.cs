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
            this.amountDropDownList = new System.Windows.Forms.ComboBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ShoppingListBox = new System.Windows.Forms.ListBox();
            this.shoppingListLabel = new System.Windows.Forms.Label();
            this.inputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.amountDropDownList);
            this.inputGroupBox.Controls.Add(this.amountLabel);
            this.inputGroupBox.Controls.Add(this.amountTextBox);
            this.inputGroupBox.Controls.Add(this.descriptionTextBox);
            this.inputGroupBox.Controls.Add(this.descriptionLabel);
            this.inputGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputGroupBox.Location = new System.Drawing.Point(45, 83);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(1120, 333);
            this.inputGroupBox.TabIndex = 0;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Input";
            // 
            // amountDropDownList
            // 
            this.amountDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.amountDropDownList.FormattingEnabled = true;
            this.amountDropDownList.Items.AddRange(new object[] {
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
            this.amountDropDownList.Location = new System.Drawing.Point(718, 180);
            this.amountDropDownList.Name = "amountDropDownList";
            this.amountDropDownList.Size = new System.Drawing.Size(344, 54);
            this.amountDropDownList.TabIndex = 5;
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
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(293, 181);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(372, 53);
            this.amountTextBox.TabIndex = 3;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(293, 85);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(768, 53);
            this.descriptionTextBox.TabIndex = 2;
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
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AddButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddButton.Location = new System.Drawing.Point(1205, 149);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(344, 136);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Teal;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EditButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EditButton.Location = new System.Drawing.Point(1205, 312);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(160, 75);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Firebrick;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteButton.Location = new System.Drawing.Point(1388, 312);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(163, 75);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ShoppingListBox
            // 
            this.ShoppingListBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoppingListBox.FormattingEnabled = true;
            this.ShoppingListBox.ItemHeight = 42;
            this.ShoppingListBox.Location = new System.Drawing.Point(62, 556);
            this.ShoppingListBox.Name = "ShoppingListBox";
            this.ShoppingListBox.Size = new System.Drawing.Size(1472, 760);
            this.ShoppingListBox.TabIndex = 5;
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
            this.Controls.Add(this.ShoppingListBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
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
        private System.Windows.Forms.ComboBox amountDropDownList;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ListBox ShoppingListBox;
        private System.Windows.Forms.Label shoppingListLabel;
    }
}

