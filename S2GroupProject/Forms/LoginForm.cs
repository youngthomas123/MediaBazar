using System.Security.Cryptography;
using System.Globalization;
using System.Threading;
using System.ComponentModel;
using S2GroupProject.Forms;
using Microsoft.Extensions.DependencyInjection;


namespace S2GroupProject
{
	public partial class LoginForm : Form
	{
		private readonly IServiceProvider _serviceProvider;

		public LoginForm(IServiceProvider serviceProvider)
		{
			_serviceProvider = serviceProvider;

			InitializeComponent();

		}
		private void LoginForm_Load(object sender, EventArgs e)
		{

		}

		private void UserNameTB_TextChanged(object sender, EventArgs e)
		{

		}


		private void LoginBT_Click_1(object sender, EventArgs e)
		{
			if (UserNameTB.Text == "Admin" && PasswordTB.Text == "123456")
			{
				MainPage form1 = _serviceProvider.GetService<MainPage>();
				form1.Show();
				//this.Hide();
			}
			else if (UserNameTB.Text == "WAdmin" && PasswordTB.Text == "1234")
			{
				WarehouseManager itemManager = _serviceProvider.GetService<WarehouseManager>();
				itemManager.Show();
				//this.Hide();
			}

		}

		private void ChangeLanguage(string language)
		{
			foreach (Control control in this.Controls)
			{
				ComponentResourceManager resources = new ComponentResourceManager(typeof(LoginForm));
				resources.ApplyResources(control, control.Name, new CultureInfo(language));
			}
		}
	}
}