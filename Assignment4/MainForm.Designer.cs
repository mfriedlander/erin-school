namespace Assignment4
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private BMICalculator bmiCalculator = new BMICalculator();

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
            this.name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.metricRadioButton = new System.Windows.Forms.RadioButton();
            this.americanRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ResultsGroup = new System.Windows.Forms.GroupBox();
            this.normalWeightLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bmiResultsLabel = new System.Windows.Forms.Label();
            this.weightCategoryResultsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.heightTextbox = new System.Windows.Forms.TextBox();
            this.weightTextbox = new System.Windows.Forms.TextBox();
            this.heightTxtbx = new System.Windows.Forms.TextBox();
            this.feetLabel = new System.Windows.Forms.Label();
            this.heightLbl = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.weightLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.ResultsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.name.Location = new System.Drawing.Point(64, 114);
            this.name.Name = "name";
            this.name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name.Size = new System.Drawing.Size(221, 46);
            this.name.TabIndex = 0;
            this.name.Text = "Your Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(56, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(56, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Weight";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CalculateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CalculateButton.Location = new System.Drawing.Point(579, 472);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(485, 103);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // metricRadioButton
            // 
            this.metricRadioButton.AutoSize = true;
            this.metricRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.metricRadioButton.Location = new System.Drawing.Point(56, 162);
            this.metricRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metricRadioButton.Name = "metricRadioButton";
            this.metricRadioButton.Size = new System.Drawing.Size(403, 50);
            this.metricRadioButton.TabIndex = 4;
            this.metricRadioButton.TabStop = true;
            this.metricRadioButton.Text = "Metric Unit (cm, kg)";
            this.metricRadioButton.UseVisualStyleBackColor = true;
            this.metricRadioButton.CheckedChanged += new System.EventHandler(this.metricRadioButton_CheckedChanged);
            // 
            // americanRadioButton
            // 
            this.americanRadioButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.americanRadioButton.AutoSize = true;
            this.americanRadioButton.Checked = true;
            this.americanRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.americanRadioButton.Location = new System.Drawing.Point(56, 79);
            this.americanRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.americanRadioButton.Name = "americanRadioButton";
            this.americanRadioButton.Size = new System.Drawing.Size(327, 50);
            this.americanRadioButton.TabIndex = 5;
            this.americanRadioButton.TabStop = true;
            this.americanRadioButton.Text = "US Unit (ft, lbs)";
            this.americanRadioButton.UseVisualStyleBackColor = true;
            this.americanRadioButton.CheckedChanged += new System.EventHandler(this.americanRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.americanRadioButton);
            this.groupBox1.Controls.Add(this.metricRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(1008, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(485, 279);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit";
            // 
            // ResultsGroup
            // 
            this.ResultsGroup.Controls.Add(this.normalWeightLabel);
            this.ResultsGroup.Controls.Add(this.label7);
            this.ResultsGroup.Controls.Add(this.bmiResultsLabel);
            this.ResultsGroup.Controls.Add(this.weightCategoryResultsLabel);
            this.ResultsGroup.Controls.Add(this.label4);
            this.ResultsGroup.Controls.Add(this.label3);
            this.ResultsGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ResultsGroup.Location = new System.Drawing.Point(88, 670);
            this.ResultsGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultsGroup.Name = "ResultsGroup";
            this.ResultsGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultsGroup.Size = new System.Drawing.Size(1477, 565);
            this.ResultsGroup.TabIndex = 7;
            this.ResultsGroup.TabStop = false;
            this.ResultsGroup.Text = "Your Results";
            this.ResultsGroup.Visible = false;
            // 
            // normalWeightLabel
            // 
            this.normalWeightLabel.AutoSize = true;
            this.normalWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.normalWeightLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.normalWeightLabel.Location = new System.Drawing.Point(163, 420);
            this.normalWeightLabel.Name = "normalWeightLabel";
            this.normalWeightLabel.Size = new System.Drawing.Size(1013, 39);
            this.normalWeightLabel.TabIndex = 5;
            this.normalWeightLabel.Text = "Normal weight should be between @lowWeight and @highWeight";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(699, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(684, 46);
            this.label7.TabIndex = 4;
            this.label7.Text = "Normal BMI is between 18.5 and 24.9";
            // 
            // bmiResultsLabel
            // 
            this.bmiResultsLabel.AutoSize = true;
            this.bmiResultsLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bmiResultsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bmiResultsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bmiResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bmiResultsLabel.Location = new System.Drawing.Point(707, 110);
            this.bmiResultsLabel.MinimumSize = new System.Drawing.Size(698, 59);
            this.bmiResultsLabel.Name = "bmiResultsLabel";
            this.bmiResultsLabel.Size = new System.Drawing.Size(698, 59);
            this.bmiResultsLabel.TabIndex = 3;
            this.bmiResultsLabel.Text = "N/A";
            // 
            // weightCategoryResultsLabel
            // 
            this.weightCategoryResultsLabel.AutoSize = true;
            this.weightCategoryResultsLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.weightCategoryResultsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weightCategoryResultsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weightCategoryResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.weightCategoryResultsLabel.Location = new System.Drawing.Point(707, 217);
            this.weightCategoryResultsLabel.MinimumSize = new System.Drawing.Size(698, 59);
            this.weightCategoryResultsLabel.Name = "weightCategoryResultsLabel";
            this.weightCategoryResultsLabel.Size = new System.Drawing.Size(698, 59);
            this.weightCategoryResultsLabel.TabIndex = 2;
            this.weightCategoryResultsLabel.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(96, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 46);
            this.label4.TabIndex = 1;
            this.label4.Text = "Weight Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(96, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Your BMI";
            // 
            // heightTextbox
            // 
            this.heightTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.heightTextbox.Location = new System.Drawing.Point(341, 193);
            this.heightTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.heightTextbox.Name = "heightTextbox";
            this.heightTextbox.Size = new System.Drawing.Size(169, 53);
            this.heightTextbox.TabIndex = 8;
            // 
            // weightTextbox
            // 
            this.weightTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.weightTextbox.Location = new System.Drawing.Point(341, 286);
            this.weightTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weightTextbox.Name = "weightTextbox";
            this.weightTextbox.Size = new System.Drawing.Size(169, 53);
            this.weightTextbox.TabIndex = 9;
            // 
            // heightTxtbx
            // 
            this.heightTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.heightTxtbx.Location = new System.Drawing.Point(645, 193);
            this.heightTxtbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.heightTxtbx.Name = "heightTxtbx";
            this.heightTxtbx.Size = new System.Drawing.Size(169, 53);
            this.heightTxtbx.TabIndex = 10;
            // 
            // feetLabel
            // 
            this.feetLabel.AutoSize = true;
            this.feetLabel.Location = new System.Drawing.Point(528, 212);
            this.feetLabel.Name = "feetLabel";
            this.feetLabel.Size = new System.Drawing.Size(31, 32);
            this.feetLabel.TabIndex = 11;
            this.feetLabel.Text = "ft";
            // 
            // heightLbl
            // 
            this.heightLbl.AutoSize = true;
            this.heightLbl.Location = new System.Drawing.Point(832, 210);
            this.heightLbl.Name = "heightLbl";
            this.heightLbl.Size = new System.Drawing.Size(38, 32);
            this.heightLbl.TabIndex = 12;
            this.heightLbl.Text = "in";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NameTextbox.Location = new System.Drawing.Point(341, 114);
            this.NameTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(556, 53);
            this.NameTextbox.TabIndex = 13;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(197, 210);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(101, 32);
            this.heightLabel.TabIndex = 14;
            this.heightLabel.Text = "( ft, in )";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(205, 293);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(84, 32);
            this.weightLabel.TabIndex = 15;
            this.weightLabel.Text = "( lbs )";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.infoLabel.ForeColor = System.Drawing.Color.Red;
            this.infoLabel.Location = new System.Drawing.Point(56, 384);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(944, 46);
            this.infoLabel.TabIndex = 16;
            this.infoLabel.Text = "You must enter a valid height and weight to continue";
            this.infoLabel.Visible = false;
            // 
            // weightLbl
            // 
            this.weightLbl.AutoSize = true;
            this.weightLbl.Location = new System.Drawing.Point(528, 297);
            this.weightLbl.Name = "weightLbl";
            this.weightLbl.Size = new System.Drawing.Size(52, 32);
            this.weightLbl.TabIndex = 17;
            this.weightLbl.Text = "lbs";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1653, 1292);
            this.Controls.Add(this.weightLbl);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.heightLbl);
            this.Controls.Add(this.feetLabel);
            this.Controls.Add(this.heightTxtbx);
            this.Controls.Add(this.weightTextbox);
            this.Controls.Add(this.heightTextbox);
            this.Controls.Add(this.ResultsGroup);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResultsGroup.ResumeLayout(false);
            this.ResultsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.RadioButton metricRadioButton;
        private System.Windows.Forms.RadioButton americanRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox ResultsGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label bmiResultsLabel;
        private System.Windows.Forms.Label weightCategoryResultsLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox heightTextbox;
        private System.Windows.Forms.TextBox weightTextbox;
        private System.Windows.Forms.TextBox heightTxtbx;
        private System.Windows.Forms.Label feetLabel;
        private System.Windows.Forms.Label heightLbl;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Label normalWeightLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label weightLbl;
    }
}

