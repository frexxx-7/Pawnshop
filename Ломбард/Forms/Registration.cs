using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ломбард.Classes;

namespace Ломбард.Forms
{
    public partial class Registration : Form
    {
        bool registerPassword = false;
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackToAutorization_Click(object sender, EventArgs e)
        {
            new Autorization().Show();
            this.Hide();
        }
        private void ApplyExecuteResults()
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO users (login, password, dateRegistration) VALUES (@login, @pass, @dateRegistration)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginInput.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passwordInput.Text;
            command.Parameters.Add("@dateRegistration", MySqlDbType.String).Value = DateTime.Now.ToString("dd.MM.yyyy");

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                errorLabel.Text = "Аккаунт создан!";
                new Autorization().Show();
                this.Hide();
            }
            else
            {
                errorLabel.Text = "Ошибка созадния аккаунта";
                errorLabel.Visible = true;
            }

            db.closeConnection();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            string query = "SELECT * FROM users ORDER BY login";
            MySqlCommand mySqlCommand = new MySqlCommand(query, db.getConnection());

            db.openConnection();

            if (loginInput.Text == "" || passwordInput.Text == "" || repeatPassword.Text == "")
            {
                errorLabel.Text = "Вы не ввели данные!";
                errorLabel.Visible = true;
            }
            else
            {
                if (passwordInput.Text.Length >= 6)
                {
                    bool en = true;
                    bool symbol = false;
                    bool number = false;

                    for (int i = 0; i < passwordInput.Text.Length; i++)
                    {
                        if (passwordInput.Text[i] >= 'А' && passwordInput.Text[i] <= 'Я') en = false;
                        if (passwordInput.Text[i] >= '0' && passwordInput.Text[i] <= '9') number = true;
                        if (passwordInput.Text[i] == '_' || passwordInput.Text[i] == '-' || passwordInput.Text[i] == '!') symbol = true;
                    }
                    if (!en)
                    {
                        errorLabel.Text = "Доступна только английская раскладка";
                        errorLabel.Visible = true;
                    }
                    else if (!symbol)
                    {
                        errorLabel.Text = "Добавьте один из следующих символов: _, -, !";
                        errorLabel.Visible = true;
                    }
                    else if (!number)
                    {
                        errorLabel.Text = "Добавьте хотя бы одну цифру";
                        errorLabel.Visible = true;
                    }
                    if (en && symbol && number)
                    {
                        if (repeatPassword.Text == passwordInput.Text)
                        {
                            try
                            {
                                using (MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader())
                                {
                                    ApplyExecuteResults();
                                }
                            }
                            catch(Exception exe)
                            {
                                errorLabel.Text = "Логин занят";
                                errorLabel.Visible = true;
                                MessageBox.Show(exe.Message);
                            }
                        }
                        else
                        {
                            errorLabel.Text = "Пароли не совпадают";
                            errorLabel.Visible = true;
                        }
                    }

                }
                else
                {
                    errorLabel.Text = "Пароль слишком короткий, минимум 6 символов!";
                    errorLabel.Visible = true;
                }
            }
            db.closeConnection();

        }

        private void eyePicture_Click(object sender, EventArgs e)
        {
            if (!registerPassword)
            {
                eyePicture.Image = System.Drawing.Image.FromFile("eye2.png");
                passwordInput.PasswordChar = '\0';
                repeatPassword.PasswordChar = '\0';
                registerPassword = true;
            }
            else
            {
                eyePicture.Image = System.Drawing.Image.FromFile("eye.png");
                passwordInput.PasswordChar = '*';
                repeatPassword.PasswordChar = '*';
                registerPassword = false;
            }
        }
    }
}
