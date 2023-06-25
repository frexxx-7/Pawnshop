using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ломбард.Classes;
using Ломбард.Forms;

namespace Ломбард
{
    public partial class Autorization : Form
    {
        bool password = false;

        public Autorization()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            string loginUser = LoginTextBox.Text;
            string passUser = PasswordTextBox.Text;

            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login = @uL AND password = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                string queryAccount = $"SELECT id FROM users WHERE login = '{loginUser}'";
                MySqlCommand mySqlCommand = new MySqlCommand(queryAccount, db.getConnection());
                AppPage apppage = new AppPage();

                db.openConnection();

                AppPage.idInfo = mySqlCommand.ExecuteScalar().ToString();

                db.closeConnection();

                errorText.Text = "Добро пожаловать ";
                errorText.Visible = true;
                AppPage.isAdmin = loginUser == "Admin";

                this.Hide();
                apppage.Show();
            }
            else
            {
                errorText.Text = "Неправильный логин или пароль";
                errorText.Visible = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Registration().Show();
            this.Hide();
        }

        private void eyePasswordAuth_Click(object sender, EventArgs e)
        {

            if (!password)
            {
                eyePasswordAuth.Image = System.Drawing.Image.FromFile("eye2.png");
                PasswordTextBox.PasswordChar = '\0';
                password = true;
            }
            else
            {
                eyePasswordAuth.Image = System.Drawing.Image.FromFile("eye.png");
                PasswordTextBox.PasswordChar = '*';
                password = false;
            }
        }

        private void guna2Panel1_FontChanged(object sender, EventArgs e)
        {

        }

        private void Autorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
