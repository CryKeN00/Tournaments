using System;
using System.Data;
using System.Windows.Forms;

namespace TournamentSystem
{
    public partial class ParticipantsForm : Form
    {
        private int tournamentId;
        private DatabaseHelper dbHelper;

        public ParticipantsForm(int tournamentId, string tournamentName)
        {
            InitializeComponent();
            this.tournamentId = tournamentId;
            this.Text = "Участники турнира: " + tournamentName;
            dbHelper = new DatabaseHelper();
            LoadParticipants();
        }

        private void LoadParticipants()
        {
            dgvParticipants.DataSource = dbHelper.GetTournamentParticipants(tournamentId);
            dgvParticipants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ParticipantsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
