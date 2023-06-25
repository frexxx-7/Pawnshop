namespace Ломбард.Forms
{
    partial class ShowForm
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
            this.ShowControlsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.SearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddPost = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // ShowControlsPanel
            // 
            this.ShowControlsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowControlsPanel.AutoScroll = true;
            this.ShowControlsPanel.Location = new System.Drawing.Point(12, 85);
            this.ShowControlsPanel.Name = "ShowControlsPanel";
            this.ShowControlsPanel.Size = new System.Drawing.Size(1156, 565);
            this.ShowControlsPanel.TabIndex = 0;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Animated = true;
            this.SearchTextBox.BackColor = System.Drawing.Color.Transparent;
            this.SearchTextBox.BorderColor = System.Drawing.Color.Gold;
            this.SearchTextBox.BorderRadius = 10;
            this.SearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextBox.DefaultText = "";
            this.SearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.SearchTextBox.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.SearchTextBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(198)))), ((int)(((byte)(199)))));
            this.SearchTextBox.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.SearchTextBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.SearchTextBox.Location = new System.Drawing.Point(795, 26);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PasswordChar = '\0';
            this.SearchTextBox.PlaceholderForeColor = System.Drawing.Color.Gold;
            this.SearchTextBox.PlaceholderText = "Поиск";
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.Size = new System.Drawing.Size(337, 33);
            this.SearchTextBox.TabIndex = 38;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            // 
            // AddPost
            // 
            this.AddPost.Animated = true;
            this.AddPost.BackColor = System.Drawing.Color.Transparent;
            this.AddPost.BorderColor = System.Drawing.Color.Gold;
            this.AddPost.BorderRadius = 10;
            this.AddPost.BorderThickness = 2;
            this.AddPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPost.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddPost.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddPost.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddPost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddPost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddPost.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.AddPost.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(198)))), ((int)(((byte)(199)))));
            this.AddPost.Location = new System.Drawing.Point(12, 20);
            this.AddPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddPost.Name = "AddPost";
            this.AddPost.Size = new System.Drawing.Size(326, 39);
            this.AddPost.TabIndex = 39;
            this.AddPost.Text = "Добавить должность";
            this.AddPost.Visible = false;
            this.AddPost.Click += new System.EventHandler(this.AddPost_Click);
            // 
            // ShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1180, 662);
            this.Controls.Add(this.AddPost);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.ShowControlsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowForm";
            this.Text = "ShowPanel";
            this.Load += new System.EventHandler(this.ShowPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel ShowControlsPanel;
        private Guna.UI2.WinForms.Guna2TextBox SearchTextBox;
        private Guna.UI2.WinForms.Guna2Button AddPost;
    }
}