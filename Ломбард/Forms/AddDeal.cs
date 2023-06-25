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
    public partial class AddDeal : Form
    {
        private AppPage.OpenForm of;
        private int quantityProduct;
        private string idDeal;
        public AddDeal(AppPage.OpenForm of)
        {
            InitializeComponent();
            this.of = of;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO deal (datetime, user, employee) VALUES (@datetime, @user, @employee)", db.getConnection());
            MySqlCommand commandGetLastID = new MySqlCommand($"SELECT id FROM deal WHERE (id = LAST_INSERT_ID())", db.getConnection());
            command.Parameters.Add("@datetime", MySqlDbType.VarChar).Value = DateTime.Now.ToString("dd.MM.yyyy");
            command.Parameters.Add("@user", MySqlDbType.Int32).Value = (UserComboBox.SelectedItem as ComboboxItem).Value;
            command.Parameters.Add("@employee", MySqlDbType.Int32).Value = (AppraiserComboBox.SelectedItem as ComboboxItem).Value;

            db.openConnection();

            try
            {
                command.ExecuteNonQuery(); 
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
            MySqlDataReader reader1 = commandGetLastID.ExecuteReader();
            while (reader1.Read())
            {
                idDeal = reader1[0].ToString();
            }
            reader1.Close();
            db.closeConnection();

            string query = "Insert into productindeal (idProduct, price, quantity) values ";
            for (int i = 0; i < DataGridProduct.RowCount-1; i++)
            {
                query += $"({DataGridProduct.Rows[i].Cells[3].Value}, {DataGridProduct.Rows[i].Cells[1].Value}, {DataGridProduct.Rows[i].Cells[2].Value}), ";
            }
            query = query.Remove(query.Length - 2);
            MessageBox.Show(query);
            MySqlCommand command2 = new MySqlCommand(query, db.getConnection());
            db.openConnection();
            try
            {
                command2.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
            db.closeConnection();
        }

        private void AddDeal_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            string queryInfoCUserCbb = $"SELECT id, name, surname, patronymic FROM users";
            string queryInfoAppraiserCbb = $"SELECT id, name, surname, patronymic FROM users";
            string queryInfoProductCbb = $"SELECT id, name FROM product";

            MySqlCommand mySqlCommandUserCbb = new MySqlCommand(queryInfoCUserCbb, db.getConnection());
            MySqlCommand mySqlCommandAppraiserCbb = new MySqlCommand(queryInfoAppraiserCbb, db.getConnection());
            MySqlCommand mySqlCommandProductCbb = new MySqlCommand(queryInfoProductCbb, db.getConnection());

            db.openConnection();

            MySqlDataReader readerUserCbb = mySqlCommandUserCbb.ExecuteReader();
            while (readerUserCbb.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = $" {readerUserCbb[1]} {readerUserCbb[3]} {readerUserCbb[2]}";
                item.Value = readerUserCbb[0];
                UserComboBox.Items.Add(item);
            }
            readerUserCbb.Close();


            MySqlDataReader readerAppraiserCbb = mySqlCommandAppraiserCbb.ExecuteReader();
            while (readerAppraiserCbb.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = $" {readerAppraiserCbb[1]} {readerAppraiserCbb[3]} {readerAppraiserCbb[2]}";
                item.Value = readerAppraiserCbb[0];
                AppraiserComboBox.Items.Add(item);
            }
            readerAppraiserCbb.Close();


            MySqlDataReader readerProductCbb = mySqlCommandProductCbb.ExecuteReader();
            while (readerProductCbb.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = $" {readerProductCbb[1]}";
                item.Value = readerProductCbb[0];
                ProductComboBox.Items.Add(item);
            }
            readerProductCbb.Close();

            db.closeConnection();
        }
        
        private void AddButton_Click_1(object sender, EventArgs e)
        {
            DataGridProduct.Rows.Add();
            DataGridProduct.Rows[quantityProduct].Cells[0].Value = (ProductComboBox.SelectedItem as ComboboxItem).Text;
            DataGridProduct.Rows[quantityProduct].Cells[1].Value = PriceTextBox.Text;
            DataGridProduct.Rows[quantityProduct].Cells[2].Value = QuantityTextBox.Text;
            DataGridProduct.Rows[quantityProduct].Cells[3].Value = (ProductComboBox.SelectedItem as ComboboxItem).Value;
            ProductComboBox.SelectedIndex = -1;
            quantityProduct++;
        }
    }
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
