using System;
using System.Windows.Forms;

namespace TournamentSystem
{
    public partial class AddEditUserForm : Form
    {
        private bool isEditMode;
        private int userId;

        public AddEditUserForm()
        {
            InitializeComponent();
            isEditMode = false;
            this.Text = "Добавить пользователя";
        }

        public AddEditUserForm(int userId, string username, string email, string fullName, bool isAdmin)
        {
            InitializeComponent();
            isEditMode = true;
            this.userId = userId;
            this.Text = "Редактировать пользователя";

            txtUsername.Text = username;
            txtEmail.Text = email;
            txtFullName.Text = fullName;
            chkIsAdmin.Checked = isAdmin;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            bool isAdmin = chkIsAdmin.Checked;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DatabaseHelper dbHelper = new DatabaseHelper();
            bool result;

            if (isEditMode)
            {
                result = dbHelper.UpdateUser(userId, username, email, fullName, isAdmin);
            }
            else
            {
                string password = "password123"; // Пароль по умолчанию
                result = dbHelper.RegisterUser(username, password, email, fullName);

                if (result && isAdmin)
                {
                    // Если нужно сделать пользователя администратором
                    dbHelper.UpdateUser(dbHelper.GetUserId(username), username, email, fullName, isAdmin);
                }
            }

            if (result)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка при сохранении пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}