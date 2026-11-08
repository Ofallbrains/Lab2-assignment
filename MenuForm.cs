using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2_assignment
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

       

        private void bicycleBtn_Click(object sender, EventArgs e)
        {

            BicycleRentalForm bicycleForm = new BicycleRentalForm();

            bicycleForm.Show();

            this.Hide();
        }

        private void mushroomBtn_Click(object sender, EventArgs e)
        {
            MushroomForm mushroom = new MushroomForm();

            mushroom.Show();

            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            form1 login = new form1();
            login.Show();
            this.Hide();
        }
    }
}
