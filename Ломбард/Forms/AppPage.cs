using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ломбард.Forms
{
    public partial class AppPage : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Panel leftBorderBtnActivePanel;
        private Form currentChildForm;
        public static bool isAdmin;
        public static string idInfo;

        public delegate void OpenForm(Form childForm);
        public static AppPage apppage;

        public AppPage()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 45);
            this.ControlBox = false;
            this.DoubleBuffered = true;
            leftBorderBtnActivePanel = panelMenu;
            ActiveButton(ProfileButton, panelMenu);
            this.Size = new Size(1400, 800);
            apppage = this;
        }

        private void AppPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            guna2Transition1.Show(TovarPanel);
            TovarPanel.Visible = !TovarPanel.Visible;
        }
        private void ActiveButton(object senderBtn, Panel activePanel)
        {
            if (senderBtn != null)
            {
                DisableButton();

                leftBorderBtnActivePanel.Controls.Remove(leftBorderBtn);
                activePanel.Controls.Add(leftBorderBtn);
                leftBorderBtnActivePanel = activePanel;
                     
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(31, 40, 51);
                currentBtn.ForeColor = Color.Gold;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Gold;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = Color.Gold;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = Color.Gold;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(11, 12, 16);
                currentBtn.ForeColor = Color.Gold;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gold;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitleChildForm.Text = currentBtn.Text;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            OpenForm of = new OpenForm(OpenChildForm);
            ActiveButton(sender, TovarPanel);
            OpenChildForm(new ShowForm("Товары", of));
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            OpenForm of = new OpenForm(OpenChildForm);
            ActiveButton(sender, TovarPanel);
            OpenChildForm(new AddProduct(of));
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            OpenForm of = new OpenForm(OpenChildForm);
            ActiveButton(sender, panelMenu);
            OpenChildForm(new Profile(idInfo, of));
        }

        private void AppPage_Load(object sender, EventArgs e)
        {
            OpenForm of = new OpenForm(OpenChildForm);
            OpenChildForm(new Profile(idInfo, of));
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            guna2Transition1.Show(DealPanel);
            DealPanel.Visible = !DealPanel.Visible;
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            OpenForm of = new OpenForm(OpenChildForm);
            ActiveButton(sender, DealPanel);
            OpenChildForm(new AddDeal(of));
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            OpenForm of = new OpenForm(OpenChildForm);
            ActiveButton(sender, DealPanel);
            OpenChildForm(new ShowForm("Сделки", of));
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            guna2Transition1.Show(AdminPanel);
            AdminPanel.Visible = !AdminPanel.Visible;
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            OpenForm of = new OpenForm(OpenChildForm);
            ActiveButton(sender, AdminPanel);
            OpenChildForm(new ShowForm("Пользователи", of));
        }
    }
}
