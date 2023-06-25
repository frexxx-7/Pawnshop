using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Ломбард.Classes;

namespace Ломбард.Forms
{
    public partial class EditProfileForm : Form
    {
        private string idInfo;
        private AppPage.OpenForm of;
        public EditProfileForm(string idInfo, AppPage.OpenForm of)
        {
            InitializeComponent();
            this.idInfo = idInfo;
            this.of = of;
            DateBirthDayDateTimePicker.Value = DateTime.Now;
        }

        private void PassportButton_Click(object sender, EventArgs e)
        {
            if (AppPage.idInfo == idInfo)
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand($"UPDATE users SET passport = @passport WHERE id = '{idInfo}'", db.getConnection());

                db.openConnection();

                OpenFileDialog open_dialog = new OpenFileDialog();
                open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                if (open_dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        command.Parameters.AddWithValue("@passport", File.ReadAllBytes($"{open_dialog.FileName}"));
                        command.ExecuteNonQuery();

                        Bitmap image = new Bitmap(open_dialog.FileName);
                        passportPictureBox.Image = image;
                        passportPictureBox.Visible = true;
                        passportPictureBox.Invalidate();
                    }
                    catch
                    {
                        MessageBox.Show("Выбранное вами изображение больше 16 МБ, выберите другое", "Ошибка изображения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                db.closeConnection();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            string query = "Update users set ";
            if (LoginLabel.Text.Length!=0)
            {
                query += $"login='{LoginTextBox.Text}', ";
            }
            if (PasswordTextBox.Text.Length!=0)
            {
                query += $"password='{PasswordTextBox.Text}', ";
            }
            if(NameTextBox.Text.Length!=0)
            {
                query += $"name='{NameTextBox.Text}', ";
            }
            if (SurnameTextBox.Text.Length!=0)
            {
                query += $"surname='{SurnameTextBox.Text}', ";
            }
            if (PatronymicTextBox.Text.Length!=0)
            {
                query += $"patronymic='{PatronymicTextBox.Text}', ";
            }
            if (DateBirthDayDateTimePicker.Value.Date!= DateTime.UtcNow.Date)
            {
                query += $"dateBirthday='{DateBirthDayDateTimePicker.Value.ToString("dd.MM.yyyy")}', ";
            }
            if (NumberPhoneTextBox.Text.Length != 0)
            {
                query += $"numberPhone='{NumberPhoneTextBox.Text}', ";
            }
            if(AddressComboBox.SelectedIndex!= -1)
            {
                query += $"address='{(AddressComboBox.SelectedItem as ComboboxItem).Value}', ";
            }
            if (query != "Update users set ")
            {
                query = query.Remove(query.Length - 2);
                query += " ";
            }
            query += $"Where id={idInfo}";
            MySqlCommand command = new MySqlCommand(query, db.getConnection());


            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                of(new Profile(idInfo, of));
            }
            else
            {
                MessageBox.Show("Ошибка");
            }

            db.closeConnection();
        }

        private void EditProfileForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            string queryInfoAddressCbb = $"SELECT id, country, area, region, city, street, house FROM address";

            MySqlCommand mySqlCommandAddressCbb = new MySqlCommand(queryInfoAddressCbb, db.getConnection());

            db.openConnection();

            MySqlDataReader readerAddressCbb = mySqlCommandAddressCbb.ExecuteReader();
            while (readerAddressCbb.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = $" {readerAddressCbb[1]} {readerAddressCbb[2]} {readerAddressCbb[3]} {readerAddressCbb[4]} {readerAddressCbb[5]} {readerAddressCbb[6]}";
                item.Value = readerAddressCbb[0];
                AddressComboBox.Items.Add(item);
            }
            readerAddressCbb.Close();

            db.closeConnection();

            string queryInfo = $"SELECT login, name, surname, patronymic, numberPhone, dateBirthday, patronymic, password, address  FROM users WHERE id = '{idInfo}'";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                LoginTextBox.Text = reader[0].ToString();
                NameTextBox.Text = reader[1].ToString();
                SurnameTextBox.Text = reader[2].ToString();
                PatronymicTextBox.Text = reader[3].ToString();
                NumberPhoneTextBox.Text = reader[4].ToString();
                if (reader[5].ToString()!="")
                    DateBirthDayDateTimePicker.Value = DateTime.Parse(reader[5].ToString());
                PasswordTextBox.Text = reader[6].ToString();
                for (int i = 0; i < AddressComboBox.Items.Count; i++)
                {
                    if (reader[8].ToString() != "")
                    {
                        if (Convert.ToInt32((AddressComboBox.Items[i] as ComboboxItem).Value) == Convert.ToInt32(reader[8]))
                        {
                            AddressComboBox.SelectedIndex = i;
                        }
                    }
                }
            }
            reader.Close();

            db.closeConnection();

           
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            of(new AddAddress(of, idInfo));
        }
    }

}
