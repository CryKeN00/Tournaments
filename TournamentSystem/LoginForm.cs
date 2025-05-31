using System;
using System.Windows.Forms;

namespace TournamentSystem
{
    public partial class LoginForm : Form
    {
        private DatabaseHelper dbHelper;

        public LoginForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, введите имя пользователя и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dbHelper.ValidateUser(username, password))
            {
                bool isAdmin = dbHelper.IsAdmin(username);
                int userId = dbHelper.GetUserId(username);

                if (isAdmin)
                {
                    AdminForm adminForm = new AdminForm(userId);
                    adminForm.Show();
                }
                else
                {
                    UserDashboard userDashboard = new UserDashboard(userId);
                    userDashboard.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}