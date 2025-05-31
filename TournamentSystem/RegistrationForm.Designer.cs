namespace TournamentSystem
{
    partial class RegistrationForm
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
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblFullName = new Label();
            txtFullName = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.Location = new Point(117, 23);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(137, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Регистрация";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(58, 69);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(109, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Имя пользователя";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(58, 92);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(326, 23);
            txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(58, 138);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(49, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Пароль";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(58, 162);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(326, 23);
            txtPassword.TabIndex = 4;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(58, 208);
            lblConfirmPassword.Margin = new Padding(4, 0, 4, 0);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(120, 15);
            lblConfirmPassword.TabIndex = 5;
            lblConfirmPassword.Text = "Подтвердите пароль";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(58, 231);
            txtConfirmPassword.Margin = new Padding(4, 3, 4, 3);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(326, 23);
            txtConfirmPassword.TabIndex = 6;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(58, 277);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(58, 300);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(326, 23);
            txtEmail.TabIndex = 8;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(58, 346);
            lblFullName.Margin = new Padding(4, 0, 4, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(34, 15);
            lblFullName.TabIndex = 9;
            lblFullName.Text = "ФИО";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(58, 369);
            txtFullName.Margin = new Padding(4, 3, 4, 3);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(326, 23);
            txtFullName.TabIndex = 10;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SteelBlue;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(58, 415);
            btnRegister.Margin = new Padding(4, 3, 4, 3);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(327, 35);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Зарегистрироваться";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1568064299_69651886_1317160088443769_3885362874935148544_o;
            ClientSize = new Size(448, 486);
            Controls.Add(btnRegister);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            Margin = new Padding(4, 3, 4, 3);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Турнирная система - Регистрация";
            ResumeLayout(false);
            PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button btnRegister;
    }
}