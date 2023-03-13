using System.Security.Cryptography;

namespace S2GroupProject
{
    public partial class LoginForm : Form
    {
		
		public LoginForm()
        {
            InitializeComponent();
            
        }

        private void UserNameTB_TextChanged(object sender, EventArgs e)
        {

        }


        private void LoginBT_Click_1(object sender, EventArgs e)
        {
            if (UserNameTB.Text == "Admin" && PasswordTB.Text == "123456")
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}