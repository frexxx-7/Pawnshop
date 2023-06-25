namespace Ломбард.Controls
{
    partial class UsersControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PostComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.avatarPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BorderColor = System.Drawing.Color.Gold;
            this.MainPanel.BorderRadius = 10;
            this.MainPanel.BorderThickness = 2;
            this.MainPanel.Controls.Add(this.PostComboBox);
            this.MainPanel.Controls.Add(this.IdLabel);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.LoginLabel);
            this.MainPanel.Controls.Add(this.avatarPicture);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(892, 254);
            this.MainPanel.TabIndex = 0;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.ForeColor = System.Drawing.Color.Gold;
            this.LoginLabel.Location = new System.Drawing.Point(241, 39);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(72, 26);
            this.LoginLabel.TabIndex = 2;
            this.LoginLabel.Text = "Логин";
            // 
            // IdLabel
            // 
            this.IdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdLabel.ForeColor = System.Drawing.Color.Gold;
            this.IdLabel.Location = new System.Drawing.Point(788, 224);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(36, 20);
            this.IdLabel.TabIndex = 4;
            this.IdLabel.Text = "456";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(751, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id:";
            // 
            // PostComboBox
            // 
            this.PostComboBox.BackColor = System.Drawing.Color.Transparent;
            this.PostComboBox.BorderColor = System.Drawing.Color.Gold;
            this.PostComboBox.BorderRadius = 10;
            this.PostComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PostComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PostComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.PostComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PostComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PostComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PostComboBox.ForeColor = System.Drawing.Color.Gold;
            this.PostComboBox.ItemHeight = 30;
            this.PostComboBox.Location = new System.Drawing.Point(246, 177);
            this.PostComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.PostComboBox.Name = "PostComboBox";
            this.PostComboBox.Size = new System.Drawing.Size(361, 36);
            this.PostComboBox.TabIndex = 6;
            this.PostComboBox.SelectedIndexChanged += new System.EventHandler(this.PostComboBox_SelectedIndexChanged);
            // 
            // avatarPicture
            // 
            this.avatarPicture.AutoRoundedCorners = true;
            this.avatarPicture.BackColor = System.Drawing.Color.Transparent;
            this.avatarPicture.BorderRadius = 91;
            this.avatarPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avatarPicture.Image = global::Ломбард.Properties.Resources.no_avatar;
            this.avatarPicture.ImageRotate = 0F;
            this.avatarPicture.Location = new System.Drawing.Point(22, 28);
            this.avatarPicture.Margin = new System.Windows.Forms.Padding(4);
            this.avatarPicture.Name = "avatarPicture";
            this.avatarPicture.Size = new System.Drawing.Size(185, 185);
            this.avatarPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarPicture.TabIndex = 1;
            this.avatarPicture.TabStop = false;
            // 
            // UsersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.MainPanel);
            this.Name = "UsersControl";
            this.Size = new System.Drawing.Size(892, 254);
            this.Load += new System.EventHandler(this.UsersControl_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel MainPanel;
        private Guna.UI2.WinForms.Guna2PictureBox avatarPicture;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox PostComboBox;
    }
}
