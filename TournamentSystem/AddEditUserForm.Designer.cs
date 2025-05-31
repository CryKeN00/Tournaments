namespace TournamentSystem
{
    partial class AddEditUserForm
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
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblFullName = new Label();
            txtFullName = new TextBox();
            chkIsAdmin = new CheckBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(23, 23);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(109, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Имя пользователя";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(23, 46);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(349, 23);
            txtUsername.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(23, 81);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(23, 104);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(349, 23);
            txtEmail.TabIndex = 3;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(23, 138);
            lblFullName.Margin = new Padding(4, 0, 4, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(34, 15);
            lblFullName.TabIndex = 4;
            lblFullName.Text = "ФИО";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(23, 162);
            txtFullName.Margin = new Padding(4, 3, 4, 3);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(349, 23);
            txtFullName.TabIndex = 5;
            // 
            // chkIsAdmin
            // 
            chkIsAdmin.AutoSize = true;
            chkIsAdmin.Location = new Point(23, 196);
            chkIsAdmin.Margin = new Padding(4, 3, 4, 3);
            chkIsAdmin.Name = "chkIsAdmin";
            chkIsAdmin.Size = new Size(113, 19);
            chkIsAdmin.TabIndex = 6;
            chkIsAdmin.Text = "Администратор";
            chkIsAdmin.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Orange;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(23, 231);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(163, 35);
            btnSave.TabIndex = 7;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(210, 231);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(163, 35);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddEditUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 290);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(chkIsAdmin);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddEditUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();

        }

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.CheckBox chkIsAdmin;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}