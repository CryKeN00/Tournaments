namespace TournamentSystem
{
    partial class ParticipantsForm
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
            dgvParticipants = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvParticipants).BeginInit();
            SuspendLayout();
            // 
            // dgvParticipants
            // 
            dgvParticipants.AllowUserToAddRows = false;
            dgvParticipants.AllowUserToDeleteRows = false;
            dgvParticipants.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvParticipants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParticipants.Location = new Point(14, 14);
            dgvParticipants.Margin = new Padding(4, 3, 4, 3);
            dgvParticipants.Name = "dgvParticipants";
            dgvParticipants.ReadOnly = true;
            dgvParticipants.Size = new Size(653, 346);
            dgvParticipants.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.BackColor = Color.Orange;
            btnClose.Location = new Point(562, 375);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(105, 29);
            btnClose.TabIndex = 1;
            btnClose.Text = "Закрыть";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ParticipantsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.maxresdefault__1_;
            ClientSize = new Size(681, 417);
            Controls.Add(btnClose);
            Controls.Add(dgvParticipants);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ParticipantsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ParticipantsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvParticipants).EndInit();
            ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dgvParticipants;
        private System.Windows.Forms.Button btnClose;
    }
}