using Guna.UI2.WinForms;
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
using Ломбард.Classes;

namespace Ломбард.Forms
{
    public partial class Profile : Form
    {
        private string idInfo;
        AppPage.OpenForm of;
        public Profile(string idInfo, AppPage.OpenForm of)
        {
            InitializeComponent();
            this.idInfo = idInfo;
            this.of = of;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            string queryInfo = $"SELECT login, image, dateRegistration, name, surname, patronymic FROM users WHERE id = '{idInfo}'";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                LoginLabel.Text = reader[0].ToString();
                DateRegistrationLabel.Text = reader[2].ToString();
                NameLabel.Text = $"{reader[3].ToString()} {reader[5].ToString()} {reader[4].ToString()}";

                string ifImage = "";
                if (ifImage != reader[1].ToString())
                {
                    System.Drawing.Image avatar = (Bitmap)((new ImageConverter()).ConvertFrom(reader[1]));
                    avatarPicture.Image = avatar;
                    avatarPicture.Invalidate();
                }
            }
            reader.Close();

            db.closeConnection();
            if (AppPage.isAdmin)
            {
                JobTitleLabel.Text = "Админ";
                JobTitleLabel.Visible = true;
            }
        }

        private void avatarPicture_Click(object sender, EventArgs e)
        {
            if (AppPage.idInfo == idInfo)
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand($"UPDATE users SET image = @image WHERE id = '{idInfo}'", db.getConnection());

                db.openConnection();

                OpenFileDialog open_dialog = new OpenFileDialog();
                open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                if (open_dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        command.Parameters.AddWithValue("@image", File.ReadAllBytes($"{open_dialog.FileName}"));
                        command.ExecuteNonQuery();

                        Bitmap image = new Bitmap(open_dialog.FileName);
                        avatarPicture.Image = image;
                        avatarPicture.Invalidate();
                    }
                    catch
                    {
                        MessageBox.Show("Выбранное вами изображение больше 16 МБ, выберите другое", "Ошибка изображения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                db.closeConnection();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            of(new EditProfileForm(idInfo, of));
        }
    }
}
