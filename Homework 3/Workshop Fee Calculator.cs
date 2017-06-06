using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*

 Spencer Henze
 ITM 225
 Assignment #3
 9/21/16
 
 */

namespace Homework_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateTotalButton_Click(object sender, EventArgs e)
        {
            string workshopSelected;
            string locationSelected;

            if(wkshpComboBox.SelectedIndex != -1 && locationComboBox.SelectedIndex != -1)
            {
                // take in the selected item from comboboxes and save the inputs as new variables
                workshopSelected = wkshpComboBox.SelectedItem.ToString();
                locationSelected = locationComboBox.SelectedItem.ToString();

                // set the registration fee and the number of days variables based on the workshop selected:

                decimal registrationFee = 0;
                decimal numDays = 0;


                if (workshopSelected == "Handling Stress")
                {
                    registrationFee = 1000;
                    numDays = 3;
                }
                else if (workshopSelected == "Time Management")
                {
                    registrationFee = 800;
                    numDays = 3;
                }
                else if (workshopSelected == "Supervision Skills")
                {
                    registrationFee = 1500;
                    numDays = 3;
                }
                else if (workshopSelected == "Negotiation")
                {
                    registrationFee = 1300;
                    numDays = 5;
                }
                else if (workshopSelected == "How to Interview")
                {
                    registrationFee = 500;
                    numDays = 1;
                }


                // Now set lodging fee per day variable based on selected location
                decimal lodgingFeePerDay = 0;


                if (locationSelected == "Austin")
                {
                    lodgingFeePerDay = 150;
                }
                else if (locationSelected == "Chicago")
                {
                    lodgingFeePerDay = 225;
                }
                else if (locationSelected == "Dallas")
                {
                    lodgingFeePerDay = 174;
                }
                else if (locationSelected == "Orlando")
                {
                    lodgingFeePerDay = 300;
                }
                else if (locationSelected == "Phoenix")
                {
                    lodgingFeePerDay = 175;
                }
                else if (locationSelected == "Raleigh")
                {
                    lodgingFeePerDay = 150;
                }

                /*
                at this point the registration fee, number of days, and lodging fee per day variables are ready to be used in 
                calculations
                */

                // Now use the assigned variables to calculate the registration, lodging, and grand totals.
                // First, assign the totals variables.
                decimal registrationTotal, lodgingTotal, grandTotal;  

                // now tell the program how to calculate the totals using the variales we defined before.
                registrationTotal = registrationFee;
                lodgingTotal = lodgingFeePerDay * numDays;
                grandTotal = registrationTotal + lodgingTotal;

                // at this point you have values assigned to the total variables.
                // Tell the program to display the values stored as total variables in the Display Labels and convert each to string with currency ("C") as a perameter
                registrationDisplayLabel.Text = registrationTotal.ToString("C0");
                lodgingDisplayLabel.Text = lodgingTotal.ToString("C0");
                grandTotDisplayLabel.Text = grandTotal.ToString("C0");

            } // End of if process for valid selections

            else
            {
               MessageBox.Show("Please select an item from both lists", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } // End of error message for non-valid selections

        } // End of calculate button

        // Program your clear button
        private void clearButton_Click(object sender, EventArgs e)
        {
            registrationDisplayLabel.Text = "";
            lodgingDisplayLabel.Text = "";
            grandTotDisplayLabel.Text = "";
            wkshpComboBox.SelectedIndex = -1;
            locationComboBox.SelectedIndex = -1;

        } // End of Click Clear Button


        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
