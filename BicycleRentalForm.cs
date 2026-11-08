using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2_assignment
{
    public partial class BicycleRentalForm : Form
    {
        public BicycleRentalForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void startingTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void endingTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            int startHour, endHour;

            // Validate input
            if (!int.TryParse(startingTxt.Text, out startHour) ||
                !int.TryParse(endingTxt.Text, out endHour) ||
                startHour < 0 || startHour > 23 ||
                endHour < 1 || endHour > 24 ||
                startHour >= endHour)
            {
                MessageBox.Show(
                    "Enter valid whole hours: start 0-23, end 1-24, and start must be less than end.",
                    "Invalid hours",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                totalTxt.Clear();
                return;
            }

            // Calculate rental cost
            int total = 0;

            for (int hour = startHour; hour < endHour; hour++)
            {
                if (hour < 7)
                {
                    total += 500;
                }
                else if (hour < 14)
                {
                    total += 1000;
                }
                else if (hour < 19)
                {
                    total += 1500;
                }
                else if (hour < 21)
                {
                    total += 1000;
                }
                else
                {
                    total += 500;
                }
            }

            // Display total
            totalTxt.Text = total.ToString("N0") + " RWF";
        }

        private void totalTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
