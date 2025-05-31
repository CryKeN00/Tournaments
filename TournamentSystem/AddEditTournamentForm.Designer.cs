namespace TournamentSystem
{
    partial class AddEditTournamentForm
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
            lblName = new Label();
            txtName = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblStartDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblEndDate = new Label();
            dtpEndDate = new DateTimePicker();
            lblMaxParticipants = new Label();
            numMaxParticipants = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numMaxParticipants).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(23, 23);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Название";
            // 
            // txtName
            // 
            txtName.Location = new Point(23, 46);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(349, 23);
            txtName.TabIndex = 1;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(23, 81);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(62, 15);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Описание";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(23, 104);
            txtDescription.Margin = new Padding(4, 3, 4, 3);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(349, 69);
            txtDescription.TabIndex = 3;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(23, 185);
            lblStartDate.Margin = new Padding(4, 0, 4, 0);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(74, 15);
            lblStartDate.TabIndex = 4;
            lblStartDate.Text = "Дата начала";
            // 
            // dtpStartDate
            // 
            dtpStartDate.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(23, 208);
            dtpStartDate.Margin = new Padding(4, 3, 4, 3);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(163, 23);
            dtpStartDate.TabIndex = 5;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(210, 185);
            lblEndDate.Margin = new Padding(4, 0, 4, 0);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(95, 15);
            lblEndDate.TabIndex = 6;
            lblEndDate.Text = "Дата окончания";
            // 
            // dtpEndDate
            // 
            dtpEndDate.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.Location = new Point(210, 208);
            dtpEndDate.Margin = new Padding(4, 3, 4, 3);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(163, 23);
            dtpEndDate.TabIndex = 7;
            // 
            // lblMaxParticipants
            // 
            lblMaxParticipants.AutoSize = true;
            lblMaxParticipants.Location = new Point(23, 242);
            lblMaxParticipants.Margin = new Padding(4, 0, 4, 0);
            lblMaxParticipants.Name = "lblMaxParticipants";
            lblMaxParticipants.Size = new Size(255, 15);
            lblMaxParticipants.TabIndex = 8;
            lblMaxParticipants.Text = "Максимум участников (0 - без ограничений)";
            // 
            // numMaxParticipants
            // 
            numMaxParticipants.Location = new Point(23, 265);
            numMaxParticipants.Margin = new Padding(4, 3, 4, 3);
            numMaxParticipants.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numMaxParticipants.Name = "numMaxParticipants";
            numMaxParticipants.Size = new Size(140, 23);
            numMaxParticipants.TabIndex = 9;
            numMaxParticipants.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Orange;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(23, 312);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(163, 35);
            btnSave.TabIndex = 10;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(210, 312);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(163, 35);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddEditTournamentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 370);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(numMaxParticipants);
            Controls.Add(lblMaxParticipants);
            Controls.Add(dtpEndDate);
            Controls.Add(lblEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(lblStartDate);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtName);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddEditTournamentForm";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)numMaxParticipants).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblMaxParticipants;
        private System.Windows.Forms.NumericUpDown numMaxParticipants;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}