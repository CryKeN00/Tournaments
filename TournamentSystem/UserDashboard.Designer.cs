namespace TournamentSystem
{
    partial class UserDashboard
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
            tabProfile = new TabPage();
            btnLogout = new Button();
            groupBox2 = new GroupBox();
            btnChangePassword = new Button();
            txtConfirmNewPassword = new TextBox();
            label3 = new Label();
            txtNewPassword = new TextBox();
            label2 = new Label();
            txtCurrentPassword = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnUpdateProfile = new Button();
            txtProfileFullName = new TextBox();
            lblFullName = new Label();
            txtProfileEmail = new TextBox();
            lblEmail = new Label();
            txtProfileUsername = new TextBox();
            lblUsername = new Label();
            lblWelcome = new Label();
            tabTournaments = new TabPage();
            splitContainer1 = new SplitContainer();
            groupBox3 = new GroupBox();
            btnViewParticipants = new Button();
            btnExportToExcel = new Button();
            btnLeaveTournament = new Button();
            dgvUserTournaments = new DataGridView();
            groupBox4 = new GroupBox();
            btnJoinTournament = new Button();
            dgvAvailableTournaments = new DataGridView();
            tabControl1.SuspendLayout();
            tabProfile.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabTournaments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserTournaments).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableTournaments).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabProfile);
            tabControl1.Controls.Add(tabTournaments);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1031, 647);
            tabControl1.TabIndex = 0;
            // 
            // tabProfile
            // 
            tabProfile.Controls.Add(btnLogout);
            tabProfile.Controls.Add(groupBox2);
            tabProfile.Controls.Add(groupBox1);
            tabProfile.Controls.Add(lblWelcome);
            tabProfile.Location = new Point(4, 24);
            tabProfile.Margin = new Padding(4, 3, 4, 3);
            tabProfile.Name = "tabProfile";
            tabProfile.Padding = new Padding(4, 3, 4, 3);
            tabProfile.Size = new Size(1023, 619);
            tabProfile.TabIndex = 0;
            tabProfile.Text = "Профиль";
            tabProfile.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.Location = new Point(875, 12);
            btnLogout.Margin = new Padding(4, 3, 4, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(140, 27);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Выйти";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(btnChangePassword);
            groupBox2.Controls.Add(txtConfirmNewPassword);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtNewPassword);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtCurrentPassword);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = Color.Orange;
            groupBox2.Location = new Point(23, 288);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.RightToLeft = RightToLeft.Yes;
            groupBox2.Size = new Size(992, 231);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Смена пароля";
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.Orange;
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(23, 173);
            btnChangePassword.Margin = new Padding(4, 3, 4, 3);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(233, 35);
            btnChangePassword.TabIndex = 6;
            btnChangePassword.Text = "Изменить пароль";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.Location = new Point(23, 138);
            txtConfirmNewPassword.Margin = new Padding(4, 3, 4, 3);
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.PasswordChar = '*';
            txtConfirmNewPassword.Size = new Size(349, 23);
            txtConfirmNewPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 120);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 4;
            label3.Text = "Подтвердите пароль";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(23, 81);
            txtNewPassword.Margin = new Padding(4, 3, 4, 3);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(349, 23);
            txtNewPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 63);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 2;
            label2.Text = "Новый пароль";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(23, 35);
            txtCurrentPassword.Margin = new Padding(4, 3, 4, 3);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.PasswordChar = '*';
            txtCurrentPassword.Size = new Size(349, 23);
            txtCurrentPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Текущий пароль";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnUpdateProfile);
            groupBox1.Controls.Add(txtProfileFullName);
            groupBox1.Controls.Add(lblFullName);
            groupBox1.Controls.Add(txtProfileEmail);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(txtProfileUsername);
            groupBox1.Controls.Add(lblUsername);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Orange;
            groupBox1.Location = new Point(23, 58);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(992, 208);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Информация о профиле";
            // 
            // btnUpdateProfile
            // 
            btnUpdateProfile.BackColor = Color.Orange;
            btnUpdateProfile.ForeColor = Color.White;
            btnUpdateProfile.Location = new Point(23, 162);
            btnUpdateProfile.Margin = new Padding(4, 3, 4, 3);
            btnUpdateProfile.Name = "btnUpdateProfile";
            btnUpdateProfile.Size = new Size(233, 35);
            btnUpdateProfile.TabIndex = 6;
            btnUpdateProfile.Text = "Обновить профиль";
            btnUpdateProfile.UseVisualStyleBackColor = false;
            btnUpdateProfile.Click += btnUpdateProfile_Click;
            // 
            // txtProfileFullName
            // 
            txtProfileFullName.Location = new Point(23, 127);
            txtProfileFullName.Margin = new Padding(4, 3, 4, 3);
            txtProfileFullName.Name = "txtProfileFullName";
            txtProfileFullName.Size = new Size(349, 23);
            txtProfileFullName.TabIndex = 5;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(23, 109);
            lblFullName.Margin = new Padding(4, 0, 4, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(35, 15);
            lblFullName.TabIndex = 4;
            lblFullName.Text = "ФИО";
            // 
            // txtProfileEmail
            // 
            txtProfileEmail.Location = new Point(23, 81);
            txtProfileEmail.Margin = new Padding(4, 3, 4, 3);
            txtProfileEmail.Name = "txtProfileEmail";
            txtProfileEmail.Size = new Size(349, 23);
            txtProfileEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(21, 63);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // txtProfileUsername
            // 
            txtProfileUsername.Location = new Point(23, 35);
            txtProfileUsername.Margin = new Padding(4, 3, 4, 3);
            txtProfileUsername.Name = "txtProfileUsername";
            txtProfileUsername.ReadOnly = true;
            txtProfileUsername.Size = new Size(349, 23);
            txtProfileUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(23, 17);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(115, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Имя пользователя";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblWelcome.Location = new Point(23, 23);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 20);
            lblWelcome.TabIndex = 0;
            // 
            // tabTournaments
            // 
            tabTournaments.Controls.Add(splitContainer1);
            tabTournaments.Location = new Point(4, 24);
            tabTournaments.Margin = new Padding(4, 3, 4, 3);
            tabTournaments.Name = "tabTournaments";
            tabTournaments.Padding = new Padding(4, 3, 4, 3);
            tabTournaments.Size = new Size(1023, 619);
            tabTournaments.TabIndex = 1;
            tabTournaments.Text = "Турниры";
            tabTournaments.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(4, 3);
            splitContainer1.Margin = new Padding(4, 3, 4, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox3);
            splitContainer1.Panel1.Controls.Add(dgvUserTournaments);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox4);
            splitContainer1.Panel2.Controls.Add(dgvAvailableTournaments);
            splitContainer1.Size = new Size(1015, 613);
            splitContainer1.SplitterDistance = 289;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnViewParticipants);
            groupBox3.Controls.Add(btnExportToExcel);
            groupBox3.Controls.Add(btnLeaveTournament);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(0, 231);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(1015, 58);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            // 
            // btnViewParticipants
            // 
            btnViewParticipants.BackColor = Color.Orange;
            btnViewParticipants.Location = new Point(12, 17);
            btnViewParticipants.Margin = new Padding(4, 3, 4, 3);
            btnViewParticipants.Name = "btnViewParticipants";
            btnViewParticipants.Size = new Size(175, 29);
            btnViewParticipants.TabIndex = 2;
            btnViewParticipants.Text = "Просмотр участников";
            btnViewParticipants.UseVisualStyleBackColor = false;
            btnViewParticipants.Click += btnViewParticipants_Click;
            // 
            // btnExportToExcel
            // 
            btnExportToExcel.BackColor = Color.GreenYellow;
            btnExportToExcel.Location = new Point(420, 17);
            btnExportToExcel.Margin = new Padding(4, 3, 4, 3);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new Size(175, 29);
            btnExportToExcel.TabIndex = 1;
            btnExportToExcel.Text = "Экспорт в Excel";
            btnExportToExcel.UseVisualStyleBackColor = false;
            btnExportToExcel.Click += btnExportToExcel_Click;
            // 
            // btnLeaveTournament
            // 
            btnLeaveTournament.BackColor = Color.Orange;
            btnLeaveTournament.Location = new Point(198, 17);
            btnLeaveTournament.Margin = new Padding(4, 3, 4, 3);
            btnLeaveTournament.Name = "btnLeaveTournament";
            btnLeaveTournament.Size = new Size(210, 29);
            btnLeaveTournament.TabIndex = 0;
            btnLeaveTournament.Text = "Покинуть турнир";
            btnLeaveTournament.UseVisualStyleBackColor = false;
            btnLeaveTournament.Click += btnLeaveTournament_Click;
            // 
            // dgvUserTournaments
            // 
            dgvUserTournaments.AllowUserToAddRows = false;
            dgvUserTournaments.AllowUserToDeleteRows = false;
            dgvUserTournaments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserTournaments.Dock = DockStyle.Fill;
            dgvUserTournaments.Location = new Point(0, 0);
            dgvUserTournaments.Margin = new Padding(4, 3, 4, 3);
            dgvUserTournaments.MultiSelect = false;
            dgvUserTournaments.Name = "dgvUserTournaments";
            dgvUserTournaments.ReadOnly = true;
            dgvUserTournaments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUserTournaments.Size = new Size(1015, 289);
            dgvUserTournaments.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnJoinTournament);
            groupBox4.Dock = DockStyle.Bottom;
            groupBox4.Location = new Point(0, 261);
            groupBox4.Margin = new Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 3, 4, 3);
            groupBox4.Size = new Size(1015, 58);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            // 
            // btnJoinTournament
            // 
            btnJoinTournament.BackColor = Color.GreenYellow;
            btnJoinTournament.Location = new Point(12, 17);
            btnJoinTournament.Margin = new Padding(4, 3, 4, 3);
            btnJoinTournament.Name = "btnJoinTournament";
            btnJoinTournament.Size = new Size(175, 29);
            btnJoinTournament.TabIndex = 0;
            btnJoinTournament.Text = "Записаться на турнир";
            btnJoinTournament.UseVisualStyleBackColor = false;
            btnJoinTournament.Click += btnJoinTournament_Click;
            // 
            // dgvAvailableTournaments
            // 
            dgvAvailableTournaments.AllowUserToAddRows = false;
            dgvAvailableTournaments.AllowUserToDeleteRows = false;
            dgvAvailableTournaments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailableTournaments.Dock = DockStyle.Fill;
            dgvAvailableTournaments.Location = new Point(0, 0);
            dgvAvailableTournaments.Margin = new Padding(4, 3, 4, 3);
            dgvAvailableTournaments.MultiSelect = false;
            dgvAvailableTournaments.Name = "dgvAvailableTournaments";
            dgvAvailableTournaments.ReadOnly = true;
            dgvAvailableTournaments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvailableTournaments.Size = new Size(1015, 319);
            dgvAvailableTournaments.TabIndex = 0;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 647);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Турнирная система - Личный кабинет";
            tabControl1.ResumeLayout(false);
            tabProfile.ResumeLayout(false);
            tabProfile.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabTournaments.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUserTournaments).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAvailableTournaments).EndInit();
            ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.TabPage tabTournaments;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProfileUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtProfileFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtProfileEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox txtConfirmNewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvUserTournaments;
        private System.Windows.Forms.DataGridView dgvAvailableTournaments;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLeaveTournament;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnJoinTournament;
        private System.Windows.Forms.Button btnViewParticipants;
        private System.Windows.Forms.Button btnExportToExcel;
    }
}