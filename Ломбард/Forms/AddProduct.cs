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
    public partial class AddProduct : Form
    {
        private AppPage.OpenForm of;
        public AddProduct(AppPage.OpenForm of)
        {
            InitializeComponent();
            this.of = of;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new AddCategory().Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO product (name, description, category) VALUES (@name, @description, @category)", db.getConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NameTextBox.Text;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = DescriptionTextBox.Text;
            command.Parameters.Add("@category", MySqlDbType.Int32).Value = int.Parse(CategoryComboBox.SelectedItem.ToString()[0].ToString());
            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                of(new ShowForm("Товары", of));
            }
            else
            {
                MessageBox.Show("Ошибка");
            }

            db.closeConnection();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            string queryInfoCbb = $"SELECT id, name FROM category";
            MySqlCommand mySqlCommandCbb = new MySqlCommand(queryInfoCbb, db.getConnection());
            db.openConnection();

            MySqlDataReader readerCbb = mySqlCommandCbb.ExecuteReader();
            while (readerCbb.Read())
            {
                CategoryComboBox.Items.Add($"{readerCbb[0]} {readerCbb[1]}");
            }
            readerCbb.Close();


            db.closeConnection();
        }
    }
}
