using System;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace TournamentSystem
{
    public partial class UserDashboard : Form
    {
        private int userId;
        private DatabaseHelper dbHelper;

        public UserDashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            dbHelper = new DatabaseHelper();
            LoadUserInfo();
            LoadUserTournaments();
            LoadAvailableTournaments();
            this.FormClosing += UserDashboard_FormClosing;
        }

        private void LoadUserInfo()
        {
            DataTable userInfo = dbHelper.GetUserInfo(userId);
            if (userInfo.Rows.Count > 0)
            {
                lblWelcome.Text = "Добро пожаловать, " + userInfo.Rows[0]["FullName"].ToString();
                txtProfileUsername.Text = userInfo.Rows[0]["Username"].ToString();
                txtProfileEmail.Text = userInfo.Rows[0]["Email"].ToString();
                txtProfileFullName.Text = userInfo.Rows[0]["FullName"].ToString();
            }
        }

        private void LoadUserTournaments()
        {
            dgvUserTournaments.DataSource = dbHelper.GetUserTournaments(userId);
            dgvUserTournaments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadAvailableTournaments()
        {
            dgvAvailableTournaments.DataSource = dbHelper.GetAvailableTournaments(userId);
            dgvAvailableTournaments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            string email = txtProfileEmail.Text.Trim();
            string fullName = txtProfileFullName.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dbHelper.UpdateUserInfo(userId, email, fullName))
            {
                MessageBox.Show("Профиль успешно обновлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUserInfo();
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении профиля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmNewPassword.Text;

            if (string.IsNullOrEmpty(currentPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Новые пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка текущего пароля
            if (!dbHelper.ValidateUser(txtProfileUsername.Text, currentPassword))
            {
                MessageBox.Show("Текущий пароль неверен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dbHelper.ChangePassword(userId, newPassword))
            {
                MessageBox.Show("Пароль успешно изменен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCurrentPassword.Text = "";
                txtNewPassword.Text = "";
                txtConfirmNewPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Ошибка при изменении пароля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnJoinTournament_Click(object sender, EventArgs e)
        {
            if (dgvAvailableTournaments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите турнир для участия", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int tournamentId = Convert.ToInt32(dgvAvailableTournaments.SelectedRows[0].Cells["TournamentId"].Value);
            if (dbHelper.JoinTournament(tournamentId, userId))
            {
                MessageBox.Show("Вы успешно записаны на турнир", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUserTournaments();
                LoadAvailableTournaments();
            }
            else
            {
                MessageBox.Show("Ошибка при записи на турнир", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLeaveTournament_Click(object sender, EventArgs e)
        {
            if (dgvUserTournaments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите турнир для выхода", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int tournamentId = Convert.ToInt32(dgvUserTournaments.SelectedRows[0].Cells["TournamentId"].Value);
            if (dbHelper.LeaveTournament(tournamentId, userId))
            {
                MessageBox.Show("Вы успешно покинули турнир", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUserTournaments();
                LoadAvailableTournaments();
            }
            else
            {
                MessageBox.Show("Ошибка при выходе из турнира", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewParticipants_Click(object sender, EventArgs e)
        {
            if (dgvUserTournaments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите турнир для просмотра участников", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int tournamentId = Convert.ToInt32(dgvUserTournaments.SelectedRows[0].Cells["TournamentId"].Value);
            string tournamentName = dgvUserTournaments.SelectedRows[0].Cells["Name"].Value.ToString();

            ParticipantsForm participantsForm = new ParticipantsForm(tournamentId, tournamentName);
            participantsForm.ShowDialog();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            if (dgvUserTournaments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите турнир для экспорта");
                return;
            }

            int tournamentId = Convert.ToInt32(dgvUserTournaments.SelectedRows[0].Cells["TournamentId"].Value);
            string tournamentName = dgvUserTournaments.SelectedRows[0].Cells["Name"].Value.ToString();
            DataTable participants = dbHelper.GetTournamentParticipants(tournamentId);

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx",
                FileName = $"Участники турнира {tournamentName}.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var package = new OfficeOpenXml.ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Участники");

                    // Заголовок
                    worksheet.Cells["A1:D1"].Merge = true;
                    worksheet.Cells["A1"].Value = $"Участники турнира: {tournamentName}";
                    worksheet.Cells["A1"].Style.Font.Bold = true;
                    worksheet.Cells["A1"].Style.Font.Size = 14;
                    worksheet.Cells["A1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    // Заголовки столбцов
                    worksheet.Cells["A3"].Value = "№";
                    worksheet.Cells["B3"].Value = "Имя пользователя";
                    worksheet.Cells["C3"].Value = "ФИО";
                    worksheet.Cells["D3"].Value = "Дата регистрации";

                    // Данные
                    for (int i = 0; i < participants.Rows.Count; i++)
                    {
                        worksheet.Cells[i + 4, 1].Value = i + 1;
                        worksheet.Cells[i + 4, 2].Value = participants.Rows[i]["Username"];
                        worksheet.Cells[i + 4, 3].Value = participants.Rows[i]["FullName"];
                        worksheet.Cells[i + 4, 4].Value = participants.Rows[i]["RegistrationDate"];
                    }

                    // Форматирование
                    worksheet.Cells["A3:D3"].Style.Font.Bold = true;
                    worksheet.Cells["A3:D3"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    worksheet.Cells["A3:D3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);

                    worksheet.Column(1).Width = 5;
                    worksheet.Column(2).Width = 20;
                    worksheet.Column(3).Width = 25;
                    worksheet.Column(4).Width = 20;

                    package.SaveAs(new FileInfo(saveFileDialog.FileName));
                    MessageBox.Show("Файл успешно сохранен");
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
        private void UserDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }


        }
    }
}