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
    public partial class BMICalculatorForm : Form
    {
        //Class properties
        public double UserWeight { get; set;}
        public double UserHeight { get; set; }

        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is an event handler to trigger a Click Event that will reset all of radio buttons and text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            //Clear the textboxes
            WeightTextBox.Clear();
            HeightTextBox.Clear();
            BMIResultTextBox.Clear();

            //Change the radio buttons to their original state
            ImpericalRadioButton.Checked = true;
            MetricRadioButton.Checked = false;

            //Hide error label
            BMIResultLabel.Visible = false;
            
        }

        /// <summary>
        /// This is the event handler to trigger a Click Event that will calculate the user's BMI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {

            //Retrieve values from the user
            UserHeight = double.Parse(HeightTextBox.Text);
            UserWeight = double.Parse(WeightTextBox.Text);

           if (ImpericalRadioButton.Checked)
            {

                if(UserHeight > 0 && UserWeight > 0)
                {
                    //Calculate the user's BMI
                    double resultBMI = (UserWeight * 703) / (UserHeight * UserHeight);

                    //Check the resultBMI and display the result to the user
                    if (resultBMI < 18.5)
                    {
                        BMIResultTextBox.Text = "Underweight";
                    }
                    else if (resultBMI >= 18.5 && resultBMI <= 24.9)
                    {
                        BMIResultTextBox.Text = "Normal";
                    }
                    else if (resultBMI >= 25 && resultBMI <= 29.9)
                    {
                        BMIResultTextBox.Text = "Overweight";
                    }
                    else if (resultBMI >= 30)
                    {
                        BMIResultTextBox.Text = "Obese";
                    }

                    //Display the result
                    BMIResultLabel.Text = resultBMI.ToString();

                }
                else
                {
                    BMIResultLabel.Text = "Error: Please enter appropriate values";
                    BMIResultLabel.Visible = true;
                }
            }
            else
            {

                if (UserHeight > 0 && UserWeight > 0)
                {

                    //Calculate the user's BMI
                    double resultBMI = UserWeight / (UserHeight * UserHeight);

                    //Check the resultBMI and display the result to the user
                    if (resultBMI < 18.5)
                    {
                        BMIResultTextBox.Text = "Underweight";
                    }
                    else if (resultBMI >= 18.5 && resultBMI <= 24.9)
                    {
                        BMIResultTextBox.Text = "Normal";
                    }
                    else if (resultBMI >= 25 && resultBMI <= 29.9)
                    {
                        BMIResultTextBox.Text = "Overweight";
                    }
                    else if (resultBMI >= 30)
                    {
                        BMIResultTextBox.Text = "Obese";
                    }

                    //Display the result
                    BMIResultLabel.Text = resultBMI.ToString();
                }
                else
                {
                    BMIResultLabel.Text = "Error: Please enter appropriate values";
                    BMIResultLabel.Visible = true;
                }
            }
        }
        /// <summary>
        /// This is the event handler that triggers labels to be changed when the radio button is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImpericalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnitsLabel.Text = "in";
            WeightUnitsLabel.Text = "Ibs";

        }
        /// <summary>
        /// This is the event handler that triggers labels to be changed when the radio button is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnitsLabel.Text = "m";
            WeightUnitsLabel.Text = "kg";

        }
        /// <summary>
        /// This is an Event Handler for input into the textbox to ensure that the correct datatype is entered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double.Parse(WeightTextBox.Text);
                CalculateBMIButton.Enabled = true;
            }
            catch
            {
                CalculateBMIButton.Enabled = false;
            }

        }

        /// <summary>
        /// This is an Event Handler for input into the textbox to ensure that the correct datatype is entered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double.Parse(HeightTextBox.Text);
                CalculateBMIButton.Enabled = true;
            }
            catch
            {
                CalculateBMIButton.Enabled = false;
            }

        }
    }
}
