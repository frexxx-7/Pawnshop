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
    public partial class AddPost : Form
    {
        public AddPost()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO post (name, salary) VALUES (@name, @salary)", db.getConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NameTextBox.Text;
            command.Parameters.Add("@salary", MySqlDbType.VarChar).Value = SalaryTextBox.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка");
            }

            db.closeConnection();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
