namespace TournamentSystem
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabUsers = new TabPage();
            groupBox1 = new GroupBox();
            btnDeleteUser = new Button();
            btnEditUser = new Button();
            btnAddUser = new Button();
            dgvUsers = new DataGridView();
            tabTournaments = new TabPage();
            groupBox2 = new GroupBox();
            btnExportToExcel = new Button();
            btnViewParticipants = new Button();
            btnDeleteTournament = new Button();
            btnEditTournament = new Button();
            btnAddTournament = new Button();
            dgvTournaments = new DataGridView();
            lblWelcome = new Label();
            btnLogout = new Button();
            tabControl1.SuspendLayout();
            tabUsers.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            tabTournaments.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTournaments).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabUsers);
            tabControl1.Controls.Add(tabTournaments);
            tabControl1.Location = new Point(14, 58);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1003, 577);
            tabControl1.TabIndex = 0;
            // 
            // tabUsers
            // 
            tabUsers.Controls.Add(groupBox1);
            tabUsers.Controls.Add(dgvUsers);
            tabUsers.Location = new Point(4, 24);
            tabUsers.Margin = new Padding(4, 3, 4, 3);
            tabUsers.Name = "tabUsers";
            tabUsers.Padding = new Padding(4, 3, 4, 3);
            tabUsers.Size = new Size(995, 549);
            tabUsers.TabIndex = 0;
            tabUsers.Text = "Пользователи";
            tabUsers.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDeleteUser);
            groupBox1.Controls.Add(btnEditUser);
            groupBox1.Controls.Add(btnAddUser);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(4, 492);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(987, 54);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.IndianRed;
            btnDeleteUser.Location = new Point(420, 17);
            btnDeleteUser.Margin = new Padding(4, 3, 4, 3);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(175, 29);
            btnDeleteUser.TabIndex = 2;
            btnDeleteUser.Text = "Удалить пользователя";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.BackColor = Color.GreenYellow;
            btnEditUser.Location = new Point(210, 17);
            btnEditUser.Margin = new Padding(4, 3, 4, 3);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(198, 29);
            btnEditUser.TabIndex = 1;
            btnEditUser.Text = "Редактировать пользователя";
            btnEditUser.UseVisualStyleBackColor = false;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.Orange;
            btnAddUser.Location = new Point(12, 17);
            btnAddUser.Margin = new Padding(4, 3, 4, 3);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(187, 29);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "Добавить пользователя";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.Location = new Point(4, 3);
            dgvUsers.Margin = new Padding(4, 3, 4, 3);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(987, 543);
            dgvUsers.TabIndex = 0;
            // 
            // tabTournaments
            // 
            tabTournaments.Controls.Add(groupBox2);
            tabTournaments.Controls.Add(dgvTournaments);
            tabTournaments.Location = new Point(4, 24);
            tabTournaments.Margin = new Padding(4, 3, 4, 3);
            tabTournaments.Name = "tabTournaments";
            tabTournaments.Padding = new Padding(4, 3, 4, 3);
            tabTournaments.Size = new Size(995, 549);
            tabTournaments.TabIndex = 1;
            tabTournaments.Text = "Турниры";
            tabTournaments.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnExportToExcel);
            groupBox2.Controls.Add(btnViewParticipants);
            groupBox2.Controls.Add(btnDeleteTournament);
            groupBox2.Controls.Add(btnEditTournament);
            groupBox2.Controls.Add(btnAddTournament);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(4, 492);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(987, 54);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btnExportToExcel
            // 
            btnExportToExcel.Location = new Point(793, 17);
            btnExportToExcel.Margin = new Padding(4, 3, 4, 3);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new Size(175, 29);
            btnExportToExcel.TabIndex = 4;
            btnExportToExcel.Text = "Экспорт в Excel";
            btnExportToExcel.UseVisualStyleBackColor = true;
            btnExportToExcel.Click += btnExportToExcel_Click;
            // 
            // btnViewParticipants
            // 
            btnViewParticipants.Location = new Point(607, 17);
            btnViewParticipants.Margin = new Padding(4, 3, 4, 3);
            btnViewParticipants.Name = "btnViewParticipants";
            btnViewParticipants.Size = new Size(175, 29);
            btnViewParticipants.TabIndex = 3;
            btnViewParticipants.Text = "Просмотр участников";
            btnViewParticipants.UseVisualStyleBackColor = true;
            btnViewParticipants.Click += btnViewParticipants_Click;
            // 
            // btnDeleteTournament
            // 
            btnDeleteTournament.Location = new Point(420, 17);
            btnDeleteTournament.Margin = new Padding(4, 3, 4, 3);
            btnDeleteTournament.Name = "btnDeleteTournament";
            btnDeleteTournament.Size = new Size(175, 29);
            btnDeleteTournament.TabIndex = 2;
            btnDeleteTournament.Text = "Удалить турнир";
            btnDeleteTournament.UseVisualStyleBackColor = true;
            btnDeleteTournament.Click += btnDeleteTournament_Click;
            // 
            // btnEditTournament
            // 
            btnEditTournament.Location = new Point(210, 17);
            btnEditTournament.Margin = new Padding(4, 3, 4, 3);
            btnEditTournament.Name = "btnEditTournament";
            btnEditTournament.Size = new Size(198, 29);
            btnEditTournament.TabIndex = 1;
            btnEditTournament.Text = "Редактировать турнир";
            btnEditTournament.UseVisualStyleBackColor = true;
            btnEditTournament.Click += btnEditTournament_Click;
            // 
            // btnAddTournament
            // 
            btnAddTournament.Location = new Point(12, 17);
            btnAddTournament.Margin = new Padding(4, 3, 4, 3);
            btnAddTournament.Name = "btnAddTournament";
            btnAddTournament.Size = new Size(187, 29);
            btnAddTournament.TabIndex = 0;
            btnAddTournament.Text = "Добавить турнир";
            btnAddTournament.UseVisualStyleBackColor = true;
            btnAddTournament.Click += btnAddTournament_Click;
            // 
            // dgvTournaments
            // 
            dgvTournaments.AllowUserToAddRows = false;
            dgvTournaments.AllowUserToDeleteRows = false;
            dgvTournaments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTournaments.Dock = DockStyle.Fill;
            dgvTournaments.Location = new Point(4, 3);
            dgvTournaments.Margin = new Padding(4, 3, 4, 3);
            dgvTournaments.MultiSelect = false;
            dgvTournaments.Name = "dgvTournaments";
            dgvTournaments.ReadOnly = true;
            dgvTournaments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTournaments.Size = new Size(987, 543);
            dgvTournaments.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblWelcome.Location = new Point(23, 23);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 20);
            lblWelcome.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.BackColor = Color.OrangeRed;
            btnLogout.Location = new Point(875, 23);
            btnLogout.Margin = new Padding(4, 3, 4, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(140, 27);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Выйти";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.maxresdefault;
            ClientSize = new Size(1031, 647);
            Controls.Add(btnLogout);
            Controls.Add(lblWelcome);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Турнирная система - Администратор";
            tabControl1.ResumeLayout(false);
            tabUsers.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            tabTournaments.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTournaments).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabTournaments;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.DataGridView dgvTournaments;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteTournament;
        private System.Windows.Forms.Button btnEditTournament;
        private System.Windows.Forms.Button btnAddTournament;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnViewParticipants;
        private System.Windows.Forms.Button btnExportToExcel;
    }
}