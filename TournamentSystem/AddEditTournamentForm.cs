using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TournamentSystem
{
    public partial class AddEditTournamentForm : Form
    {
        private bool isEditMode;
        private int tournamentId;
        private int createdBy;

        public AddEditTournamentForm(int createdBy)
        {
            InitializeComponent();
            isEditMode = false;
            this.createdBy = createdBy;
            this.Text = "Добавить турнир";
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now.AddDays(7);
        }

        public AddEditTournamentForm(int tournamentId, string name, string description, DateTime startDate, DateTime endDate, int maxParticipants)
        {
            InitializeComponent();
            isEditMode = true;
            this.tournamentId = tournamentId;
            this.Text = "Редактировать турнир";

            txtName.Text = name;
            txtDescription.Text = description;
            dtpStartDate.Value = startDate;
            dtpEndDate.Value = endDate;
            numMaxParticipants.Value = maxParticipants;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string description = txtDescription.Text.Trim();
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            int maxParticipants = (int)numMaxParticipants.Value;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Пожалуйста, введите название турнира", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (startDate >= endDate)
            {
                MessageBox.Show("Дата окончания должна быть позже даты начала", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DatabaseHelper dbHelper = new DatabaseHelper();
            bool result;

            if (isEditMode)
            {
                result = dbHelper.UpdateTournament(tournamentId, name, description, startDate, endDate, maxParticipants);
            }
            else
            {
                result = dbHelper.CreateTournament(name, description, startDate, endDate, maxParticipants, createdBy);
            }

            if (result)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка при сохранении турнира", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}