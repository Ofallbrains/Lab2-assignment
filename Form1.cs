namespace Lab2_assignment
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();

            passwordtxt.UseSystemPasswordChar = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernametxt.Text) || string.IsNullOrWhiteSpace(passwordtxt.Text))
            {
                MessageBox.Show("Please enter your username and password!");
            }
            else
            {
                MenuForm menu = new MenuForm();

                menu.Show();

                this.Hide();
            }
        }
    }
}
