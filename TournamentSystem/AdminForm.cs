using System;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace TournamentSystem
{
    public partial class AdminForm : Form
    {
        private int userId;
        private DatabaseHelper dbHelper;

        public AdminForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            dbHelper = new DatabaseHelper();
            LoadUserInfo();
            LoadUsers();
            LoadTournaments();
            this.FormClosing += AdminForm_FormClosing;
        }

        private void LoadUserInfo()
        {
            DataTable userInfo = dbHelper.GetUserInfo(userId);
            if (userInfo.Rows.Count > 0)
            {
                lblWelcome.Text = "Добро пожаловать, " + userInfo.Rows[0]["FullName"].ToString() + " (Администратор)";
            }
        }

        private void LoadUsers()
        {
            dgvUsers.DataSource = dbHelper.GetAllUsers();
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadTournaments()
        {
            dgvTournaments.DataSource = dbHelper.GetAllTournaments();
            dgvTournaments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddEditUserForm addUserForm = new AddEditUserForm();
            if (addUserForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите пользователя для редактирования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedUserId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserId"].Value);
            string username = dgvUsers.SelectedRows[0].Cells["Username"].Value.ToString();
            string email = dgvUsers.SelectedRows[0].Cells["Email"].Value.ToString();
            string fullName = dgvUsers.SelectedRows[0].Cells["FullName"].Value.ToString();
            bool isAdmin = Convert.ToBoolean(dgvUsers.SelectedRows[0].Cells["IsAdmin"].Value);

            AddEditUserForm editUserForm = new AddEditUserForm(selectedUserId, username, email, fullName, isAdmin);
            if (editUserForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите пользователя для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedUserId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserId"].Value);
            string username = dgvUsers.SelectedRows[0].Cells["Username"].Value.ToString();

            if (MessageBox.Show($"Вы уверены, что хотите удалить пользователя {username}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dbHelper.DeleteUser(selectedUserId))
                {
                    MessageBox.Show("Пользователь успешно удален", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show("Ошибка при удалении пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddTournament_Click(object sender, EventArgs e)
        {
            AddEditTournamentForm addTournamentForm = new AddEditTournamentForm(userId);
            if (addTournamentForm.ShowDialog() == DialogResult.OK)
            {
                LoadTournaments();
            }
        }

        private void btnEditTournament_Click(object sender, EventArgs e)
        {
            if (dgvTournaments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите турнир для редактирования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int tournamentId = Convert.ToInt32(dgvTournaments.SelectedRows[0].Cells["TournamentId"].Value);
            string name = dgvTournaments.SelectedRows[0].Cells["Name"].Value.ToString();
            string description = dgvTournaments.SelectedRows[0].Cells["Description"].Value.ToString();
            DateTime startDate = Convert.ToDateTime(dgvTournaments.SelectedRows[0].Cells["StartDate"].Value);
            DateTime endDate = Convert.ToDateTime(dgvTournaments.SelectedRows[0].Cells["EndDate"].Value);
            int maxParticipants = Convert.ToInt32(dgvTournaments.SelectedRows[0].Cells["MaxParticipants"].Value);

            AddEditTournamentForm editTournamentForm = new AddEditTournamentForm(tournamentId, name, description, startDate, endDate, maxParticipants);
            if (editTournamentForm.ShowDialog() == DialogResult.OK)
            {
                LoadTournaments();
            }
        }

        private void btnDeleteTournament_Click(object sender, EventArgs e)
        {
            if (dgvTournaments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите турнир для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int tournamentId = Convert.ToInt32(dgvTournaments.SelectedRows[0].Cells["TournamentId"].Value);
            string tournamentName = dgvTournaments.SelectedRows[0].Cells["Name"].Value.ToString();

            if (MessageBox.Show($"Вы уверены, что хотите удалить турнир {tournamentName}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dbHelper.DeleteTournament(tournamentId))
                {
                    MessageBox.Show("Турнир успешно удален", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTournaments();
                }
                else
                {
                    MessageBox.Show("Ошибка при удалении турнира", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnViewParticipants_Click(object sender, EventArgs e)
        {
            if (dgvTournaments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите турнир для просмотра участников", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int tournamentId = Convert.ToInt32(dgvTournaments.SelectedRows[0].Cells["TournamentId"].Value);
            string tournamentName = dgvTournaments.SelectedRows[0].Cells["Name"].Value.ToString();

            ParticipantsForm participantsForm = new ParticipantsForm(tournamentId, tournamentName);
            participantsForm.ShowDialog();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            if (dgvTournaments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите турнир для экспорта");
                return;
            }

            int tournamentId = Convert.ToInt32(dgvTournaments.SelectedRows[0].Cells["TournamentId"].Value);
            string tournamentName = dgvTournaments.SelectedRows[0].Cells["Name"].Value.ToString();
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
        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }




        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}