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
            
        }


        /// <summary>
        /// This is the event handler to trigger a Click Event that will calculate the user's BMI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            if (ImpericalRadioButton.Checked)
            {
                //Retrieve values from the user
                double userHeight = Convert.ToDouble(HeightTextBox.Text);
                double userWeight = Convert.ToDouble(WeightTextBox.Text);
                
                //Calculate the user's BMI
                double resultBMI = (userWeight * 703)/(userHeight * userHeight);

             

                //Display the result
                BMIResultTextBox.Text = resultBMI.ToString();

            }
            else
            {


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


    }
}
