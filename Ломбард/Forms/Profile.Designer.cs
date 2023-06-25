
namespace Ломбард.Forms
{
    partial class Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.JobTitleLabel = new System.Windows.Forms.Label();
            this.EditButton = new Guna.UI2.WinForms.Guna2Button();
            this.InfoButton = new Guna.UI2.WinForms.Guna2Button();
            this.DateRegistrationLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.DealPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.DealLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.avatarPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.NameLabel);
            this.guna2Panel1.Controls.Add(this.JobTitleLabel);
            this.guna2Panel1.Controls.Add(this.EditButton);
            this.guna2Panel1.Controls.Add(this.InfoButton);
            this.guna2Panel1.Controls.Add(this.DateRegistrationLabel);
            this.guna2Panel1.Controls.Add(this.LoginLabel);
            this.guna2Panel1.Controls.Add(this.avatarPicture);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Gold;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1317, 213);
            this.guna2Panel1.TabIndex = 0;
            // 
            // JobTitleLabel
            // 
            this.JobTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.JobTitleLabel.AutoSize = true;
            this.JobTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JobTitleLabel.ForeColor = System.Drawing.Color.Gold;
            this.JobTitleLabel.Location = new System.Drawing.Point(1155, 15);
            this.JobTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JobTitleLabel.Name = "JobTitleLabel";
            this.JobTitleLabel.Size = new System.Drawing.Size(123, 25);
            this.JobTitleLabel.TabIndex = 18;
            this.JobTitleLabel.Text = "Должность";
            this.JobTitleLabel.Visible = false;
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.Animated = true;
            this.EditButton.BackColor = System.Drawing.Color.Transparent;
            this.EditButton.BorderColor = System.Drawing.Color.Gold;
            this.EditButton.BorderRadius = 10;
            this.EditButton.BorderThickness = 2;
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.EditButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.EditButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.EditButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(198)))), ((int)(((byte)(199)))));
            this.EditButton.Location = new System.Drawing.Point(872, 160);
            this.EditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(204, 39);
            this.EditButton.TabIndex = 17;
            this.EditButton.Text = "Редактировать";
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoButton.Animated = true;
            this.InfoButton.BackColor = System.Drawing.Color.Transparent;
            this.InfoButton.BorderColor = System.Drawing.Color.Gold;
            this.InfoButton.BorderRadius = 10;
            this.InfoButton.BorderThickness = 2;
            this.InfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.InfoButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.InfoButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.InfoButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.InfoButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.InfoButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.InfoButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.InfoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(198)))), ((int)(((byte)(199)))));
            this.InfoButton.Location = new System.Drawing.Point(1099, 160);
            this.InfoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(204, 39);
            this.InfoButton.TabIndex = 16;
            this.InfoButton.Text = "Информация";
            // 
            // DateRegistrationLabel
            // 
            this.DateRegistrationLabel.AutoSize = true;
            this.DateRegistrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateRegistrationLabel.ForeColor = System.Drawing.Color.Gold;
            this.DateRegistrationLabel.Location = new System.Drawing.Point(265, 130);
            this.DateRegistrationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateRegistrationLabel.Name = "DateRegistrationLabel";
            this.DateRegistrationLabel.Size = new System.Drawing.Size(132, 18);
            this.DateRegistrationLabel.TabIndex = 2;
            this.DateRegistrationLabel.Text = "Дата регистрации";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.ForeColor = System.Drawing.Color.Gold;
            this.LoginLabel.Location = new System.Drawing.Point(263, 47);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(72, 26);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Логин";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.Controls.Add(this.DealPanel);
            this.guna2Panel2.Controls.Add(this.DealLabel);
            this.guna2Panel2.Location = new System.Drawing.Point(16, 244);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1284, 455);
            this.guna2Panel2.TabIndex = 1;
            // 
            // DealPanel
            // 
            this.DealPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DealPanel.BorderColor = System.Drawing.Color.Gold;
            this.DealPanel.BorderRadius = 10;
            this.DealPanel.BorderThickness = 2;
            this.DealPanel.Location = new System.Drawing.Point(21, 63);
            this.DealPanel.Margin = new System.Windows.Forms.Padding(4);
            this.DealPanel.Name = "DealPanel";
            this.DealPanel.Size = new System.Drawing.Size(1239, 368);
            this.DealPanel.TabIndex = 1;
            // 
            // DealLabel
            // 
            this.DealLabel.AutoSize = true;
            this.DealLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DealLabel.ForeColor = System.Drawing.Color.Gold;
            this.DealLabel.Location = new System.Drawing.Point(16, 16);
            this.DealLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DealLabel.Name = "DealLabel";
            this.DealLabel.Size = new System.Drawing.Size(87, 25);
            this.DealLabel.TabIndex = 0;
            this.DealLabel.Text = "Сделки:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.Color.Gold;
            this.NameLabel.Location = new System.Drawing.Point(263, 88);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(267, 26);
            this.NameLabel.TabIndex = 19;
            this.NameLabel.Text = "Имя, отчество, фамилия";
            // 
            // avatarPicture
            // 
            this.avatarPicture.AutoRoundedCorners = true;
            this.avatarPicture.BackColor = System.Drawing.Color.Transparent;
            this.avatarPicture.BorderRadius = 91;
            this.avatarPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avatarPicture.Image = global::Ломбард.Properties.Resources.no_avatar;
            this.avatarPicture.ImageRotate = 0F;
            this.avatarPicture.Location = new System.Drawing.Point(37, 15);
            this.avatarPicture.Margin = new System.Windows.Forms.Padding(4);
            this.avatarPicture.Name = "avatarPicture";
            this.avatarPicture.Size = new System.Drawing.Size(185, 185);
            this.avatarPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarPicture.TabIndex = 0;
            this.avatarPicture.TabStop = false;
            this.avatarPicture.Click += new System.EventHandler(this.avatarPicture_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1317, 710);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label DateRegistrationLabel;
        private System.Windows.Forms.Label LoginLabel;
        private Guna.UI2.WinForms.Guna2PictureBox avatarPicture;
        private Guna.UI2.WinForms.Guna2Button EditButton;
        private Guna.UI2.WinForms.Guna2Button InfoButton;
        private System.Windows.Forms.Label JobTitleLabel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel DealPanel;
        private System.Windows.Forms.Label DealLabel;
        private System.Windows.Forms.Label NameLabel;
    }
}