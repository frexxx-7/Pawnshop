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
    public partial class AddAddress : Form
    {
        private AppPage.OpenForm of;
        private string idInfo;
        public AddAddress(AppPage.OpenForm of, string idInfo)
        {
            InitializeComponent();
            this.of = of;
            this.idInfo = idInfo;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO address (country, area, region, city, street, house) VALUES (@country, @area, @region, @city, @street, @house)", db.getConnection());

            command.Parameters.Add("@country", MySqlDbType.VarChar).Value = CountryTextBox.Text;
            command.Parameters.Add("@area", MySqlDbType.VarChar).Value = AreaTextBox.Text;
            command.Parameters.Add("@region", MySqlDbType.VarChar).Value = RegionTextBox.Text;
            command.Parameters.Add("@city", MySqlDbType.VarChar).Value = CityTextBox.Text;
            command.Parameters.Add("@street", MySqlDbType.VarChar).Value = StreetTextBox.Text;
            command.Parameters.Add("@house", MySqlDbType.Int32).Value = HouseTextBox.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                of(new EditProfileForm(idInfo, of));  
            }
            else
            {
                MessageBox.Show("Ошибка");
            }

            db.closeConnection();
        }
    }
}
