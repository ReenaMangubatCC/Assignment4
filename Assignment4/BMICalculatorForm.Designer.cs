namespace Assignment4
{
    partial class BMICalculatorForm
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
            this.UnitsLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.MyHeightLebel = new System.Windows.Forms.Label();
            this.MyWeightLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.ImpericalRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.BMIResultTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.HeightUnitsLabel = new System.Windows.Forms.Label();
            this.WeightUnitsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UnitsLabel
            // 
            this.UnitsLabel.AutoSize = true;
            this.UnitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitsLabel.Location = new System.Drawing.Point(5, 87);
            this.UnitsLabel.Name = "UnitsLabel";
            this.UnitsLabel.Size = new System.Drawing.Size(104, 39);
            this.UnitsLabel.TabIndex = 0;
            this.UnitsLabel.Text = "Units:";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(12, 200);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(182, 45);
            this.HeightTextBox.TabIndex = 1;
            // 
            // MyHeightLebel
            // 
            this.MyHeightLebel.AutoSize = true;
            this.MyHeightLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyHeightLebel.Location = new System.Drawing.Point(8, 158);
            this.MyHeightLebel.Name = "MyHeightLebel";
            this.MyHeightLebel.Size = new System.Drawing.Size(179, 39);
            this.MyHeightLebel.TabIndex = 2;
            this.MyHeightLebel.Text = "My Height:";
            // 
            // MyWeightLabel
            // 
            this.MyWeightLabel.AutoSize = true;
            this.MyWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyWeightLabel.Location = new System.Drawing.Point(8, 248);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Size = new System.Drawing.Size(186, 39);
            this.MyWeightLabel.TabIndex = 3;
            this.MyWeightLabel.Text = "My Weight:";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(12, 290);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(182, 45);
            this.WeightTextBox.TabIndex = 4;
            // 
            // ImpericalRadioButton
            // 
            this.ImpericalRadioButton.AutoSize = true;
            this.ImpericalRadioButton.Checked = true;
            this.ImpericalRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImpericalRadioButton.Location = new System.Drawing.Point(110, 63);
            this.ImpericalRadioButton.Name = "ImpericalRadioButton";
            this.ImpericalRadioButton.Size = new System.Drawing.Size(177, 43);
            this.ImpericalRadioButton.TabIndex = 5;
            this.ImpericalRadioButton.TabStop = true;
            this.ImpericalRadioButton.Text = "Imperical";
            this.ImpericalRadioButton.UseVisualStyleBackColor = true;
            this.ImpericalRadioButton.CheckedChanged += new System.EventHandler(this.ImpericalRadioButton_CheckedChanged);
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricRadioButton.Location = new System.Drawing.Point(110, 112);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(130, 43);
            this.MetricRadioButton.TabIndex = 6;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_CheckedChanged);
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.BackColor = System.Drawing.Color.SlateBlue;
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMIButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CalculateBMIButton.Location = new System.Drawing.Point(12, 341);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(260, 46);
            this.CalculateBMIButton.TabIndex = 7;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // BMIResultTextBox
            // 
            this.BMIResultTextBox.Location = new System.Drawing.Point(12, 12);
            this.BMIResultTextBox.Name = "BMIResultTextBox";
            this.BMIResultTextBox.Size = new System.Drawing.Size(278, 45);
            this.BMIResultTextBox.TabIndex = 8;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Brown;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ResetButton.Location = new System.Drawing.Point(93, 393);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(94, 46);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // HeightUnitsLabel
            // 
            this.HeightUnitsLabel.AutoSize = true;
            this.HeightUnitsLabel.Location = new System.Drawing.Point(200, 200);
            this.HeightUnitsLabel.Name = "HeightUnitsLabel";
            this.HeightUnitsLabel.Size = new System.Drawing.Size(44, 39);
            this.HeightUnitsLabel.TabIndex = 10;
            this.HeightUnitsLabel.Text = "in";
            // 
            // WeightUnitsLabel
            // 
            this.WeightUnitsLabel.AutoSize = true;
            this.WeightUnitsLabel.Location = new System.Drawing.Point(200, 290);
            this.WeightUnitsLabel.Name = "WeightUnitsLabel";
            this.WeightUnitsLabel.Size = new System.Drawing.Size(63, 39);
            this.WeightUnitsLabel.TabIndex = 11;
            this.WeightUnitsLabel.Text = "Ibs";
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.WeightUnitsLabel);
            this.Controls.Add(this.HeightUnitsLabel);
            this.Controls.Add(this.ImpericalRadioButton);
            this.Controls.Add(this.MetricRadioButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.BMIResultTextBox);
            this.Controls.Add(this.CalculateBMIButton);
            this.Controls.Add(this.UnitsLabel);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.MyWeightLabel);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.MyHeightLebel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label UnitsLabel;
        private System.Windows.Forms.Label MyHeightLebel;
        private System.Windows.Forms.Label MyWeightLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.RadioButton ImpericalRadioButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.TextBox BMIResultTextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label HeightUnitsLabel;
        private System.Windows.Forms.Label WeightUnitsLabel;
    }
}

