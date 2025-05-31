using System;
using System.Windows.Forms;

namespace TournamentSystem
{
    public partial class RegistrationForm : Form
    {
        private DatabaseHelper dbHelper;

        public RegistrationForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string email = txtEmail.Text.Trim();
            string fullName = txtFullName.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dbHelper.RegisterUser(username, password, email, fullName))
            {
                MessageBox.Show("Регистрация прошла успешно! Теперь вы можете войти в систему.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка при регистрации. Возможно, имя пользователя или email уже заняты.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}