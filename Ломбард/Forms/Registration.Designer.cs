namespace Ломбард.Forms
{
    partial class Registration
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.backButton = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.BackToAutorization = new Guna.UI2.WinForms.Guna2Button();
            this.repeatPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.eyePicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eyePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = global::Ломбард.Properties.Resources.Золото;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Panel1.Controls.Add(this.eyePicture);
            this.guna2Panel1.Controls.Add(this.repeatPassword);
            this.guna2Panel1.Controls.Add(this.BackToAutorization);
            this.guna2Panel1.Controls.Add(this.errorLabel);
            this.guna2Panel1.Controls.Add(this.backButton);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.passwordInput);
            this.guna2Panel1.Controls.Add(this.loginInput);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(-3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1125, 719);
            this.guna2Panel1.TabIndex = 1;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(333, 346);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(45, 20);
            this.errorLabel.TabIndex = 14;
            this.errorLabel.Text = "error";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel.Visible = false;
            // 
            // backButton
            // 
            this.backButton.Animated = true;
            this.backButton.AutoRoundedCorners = true;
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BorderColor = System.Drawing.Color.Gold;
            this.backButton.BorderRadius = 18;
            this.backButton.BorderThickness = 2;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(198)))), ((int)(((byte)(199)))));
            this.backButton.Location = new System.Drawing.Point(384, 378);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(162, 39);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Регистрация";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(379, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Регистрация";
            // 
            // passwordInput
            // 
            this.passwordInput.Animated = true;
            this.passwordInput.AutoRoundedCorners = true;
            this.passwordInput.BackColor = System.Drawing.Color.Transparent;
            this.passwordInput.BorderColor = System.Drawing.Color.Gold;
            this.passwordInput.BorderRadius = 22;
            this.passwordInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordInput.DefaultText = "";
            this.passwordInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.passwordInput.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.passwordInput.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.passwordInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(198)))), ((int)(((byte)(199)))));
            this.passwordInput.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.passwordInput.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.passwordInput.Location = new System.Drawing.Point(323, 221);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.PlaceholderForeColor = System.Drawing.Color.Gold;
            this.passwordInput.PlaceholderText = "Пароль";
            this.passwordInput.SelectedText = "";
            this.passwordInput.Size = new System.Drawing.Size(300, 46);
            this.passwordInput.TabIndex = 3;
            // 
            // loginInput
            // 
            this.loginInput.Animated = true;
            this.loginInput.AutoRoundedCorners = true;
            this.loginInput.BackColor = System.Drawing.Color.Transparent;
            this.loginInput.BorderColor = System.Drawing.Color.Gold;
            this.loginInput.BorderRadius = 22;
            this.loginInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginInput.DefaultText = "";
            this.loginInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.loginInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.loginInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.loginInput.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.loginInput.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.loginInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(198)))), ((int)(((byte)(199)))));
            this.loginInput.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.loginInput.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.loginInput.Location = new System.Drawing.Point(323, 142);
            this.loginInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginInput.Name = "loginInput";
            this.loginInput.PasswordChar = '\0';
            this.loginInput.PlaceholderForeColor = System.Drawing.Color.Gold;
            this.loginInput.PlaceholderText = "Логин";
            this.loginInput.SelectedText = "";
            this.loginInput.Size = new System.Drawing.Size(300, 46);
            this.loginInput.TabIndex = 2;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Gold;
            this.guna2ControlBox1.Location = new System.Drawing.Point(886, 9);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // BackToAutorization
            // 
            this.BackToAutorization.Animated = true;
            this.BackToAutorization.AutoRoundedCorners = true;
            this.BackToAutorization.BackColor = System.Drawing.Color.Transparent;
            this.BackToAutorization.BorderColor = System.Drawing.Color.Gold;
            this.BackToAutorization.BorderRadius = 18;
            this.BackToAutorization.BorderThickness = 2;
            this.BackToAutorization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToAutorization.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackToAutorization.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackToAutorization.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackToAutorization.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackToAutorization.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackToAutorization.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.BackToAutorization.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BackToAutorization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(198)))), ((int)(((byte)(199)))));
            this.BackToAutorization.Location = new System.Drawing.Point(15, 22);
            this.BackToAutorization.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackToAutorization.Name = "BackToAutorization";
            this.BackToAutorization.Size = new System.Drawing.Size(116, 39);
            this.BackToAutorization.TabIndex = 15;
            this.BackToAutorization.Text = "Назад";
            this.BackToAutorization.Click += new System.EventHandler(this.BackToAutorization_Click);
            // 
            // repeatPassword
            // 
            this.repeatPassword.Animated = true;
            this.repeatPassword.AutoRoundedCorners = true;
            this.repeatPassword.BackColor = System.Drawing.Color.Transparent;
            this.repeatPassword.BorderColor = System.Drawing.Color.Gold;
            this.repeatPassword.BorderRadius = 22;
            this.repeatPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.repeatPassword.DefaultText = "";
            this.repeatPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.repeatPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.repeatPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.repeatPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.repeatPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.repeatPassword.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.repeatPassword.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.repeatPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.repeatPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(198)))), ((int)(((byte)(199)))));
            this.repeatPassword.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.repeatPassword.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.repeatPassword.Location = new System.Drawing.Point(323, 296);
            this.repeatPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.repeatPassword.Name = "repeatPassword";
            this.repeatPassword.PasswordChar = '*';
            this.repeatPassword.PlaceholderForeColor = System.Drawing.Color.Gold;
            this.repeatPassword.PlaceholderText = "Повторите пароль";
            this.repeatPassword.SelectedText = "";
            this.repeatPassword.Size = new System.Drawing.Size(300, 46);
            this.repeatPassword.TabIndex = 16;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 20;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 1D;
            this.guna2DragControl1.TargetControl = this.guna2Panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // eyePicture
            // 
            this.eyePicture.BackColor = System.Drawing.Color.Transparent;
            this.eyePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyePicture.Image = ((System.Drawing.Image)(resources.GetObject("eyePicture.Image")));
            this.eyePicture.ImageRotate = 0F;
            this.eyePicture.Location = new System.Drawing.Point(630, 231);
            this.eyePicture.Margin = new System.Windows.Forms.Padding(4);
            this.eyePicture.Name = "eyePicture";
            this.eyePicture.Size = new System.Drawing.Size(27, 25);
            this.eyePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eyePicture.TabIndex = 17;
            this.eyePicture.TabStop = false;
            this.eyePicture.Click += new System.EventHandler(this.eyePicture_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(940, 516);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registration_FormClosed);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eyePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label errorLabel;
        private Guna.UI2.WinForms.Guna2Button backButton;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox passwordInput;
        private Guna.UI2.WinForms.Guna2TextBox loginInput;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox repeatPassword;
        private Guna.UI2.WinForms.Guna2Button BackToAutorization;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2PictureBox eyePicture;
    }
}