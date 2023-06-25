using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Ломбард.Classes;
using Ломбард.Forms;

namespace Ломбард.Controls
{
    public partial class UsersControl : UserControl
    {
        private string idInfo;
        public UsersControl(string idInfo)
        {
            InitializeComponent();
            this.idInfo = idInfo;
        }

        private void UsersControl_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            string queryInfoPostCbb = $"SELECT id, name FROM post";

            MySqlCommand mySqlCommandPostCbb = new MySqlCommand(queryInfoPostCbb, db.getConnection());

            db.openConnection();

            MySqlDataReader readerPostCbb = mySqlCommandPostCbb.ExecuteReader();
            while (readerPostCbb.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = $" {readerPostCbb["name"]}";
                item.Value = readerPostCbb[0];
                PostComboBox.Items.Add(item);
            }
            readerPostCbb.Close();

            db.closeConnection();

            string queryInfo = $"SELECT id, login, image, post FROM users WHERE id = '{idInfo}'";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                IdLabel.Text = reader[0].ToString();
                LoginLabel.Text = reader[1].ToString();

                string ifImage = "";
                if (ifImage != reader[2].ToString())
                {
                    System.Drawing.Image avatar = (Bitmap)((new ImageConverter()).ConvertFrom(reader[2]));
                    avatarPicture.Image = avatar;
                    avatarPicture.Invalidate();
                }
                for (int i = 0; i < PostComboBox.Items.Count; i++)
                {
                    if (reader[3].ToString() != "")
                    {
                        if (Convert.ToInt32((PostComboBox.Items[i] as ComboboxItem).Value) == Convert.ToInt32(reader[3]))
                        {
                            PostComboBox.SelectedIndex = i;
                        }
                    }
                }
            }
            reader.Close();

            db.closeConnection();
        }

        private void PostComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            string query = $"Update users set post = {(PostComboBox.SelectedItem as ComboboxItem).Value} where id = {idInfo}";
            MySqlCommand command = new MySqlCommand(query, db.getConnection());


            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
            }
            else
            {
                MessageBox.Show("Ошибка");
            }

            db.closeConnection();
        }
    }
}
