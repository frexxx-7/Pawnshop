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
using System.Windows.Input;
using System.Xml;
using Ломбард.Classes;
using Ломбард.Controls;

namespace Ломбард.Forms
{
    public partial class ShowForm : Form
    {
        private string whatShow;
        private AppPage.OpenForm of;
        public ShowForm(string whatShow, AppPage.OpenForm of)
        {
            InitializeComponent();
            this.whatShow = whatShow;
            this.of = of;
        }

        private void ShowPanel_Load(object sender, EventArgs e)
        {
            switch (whatShow)
            {
                case "Товары": GenerateDynamicTovarControls(null); break;
                case "Пользователи": GenerateDynamicUsersControls(null); AddPost.Visible = true; break;
                default:
                    break;
            }
        }
        private void GenerateDynamicTovarControls(string searchText)
        {
            ShowControlsPanel.Controls.Clear();
            DB db = new DB();
            string queryInfo = searchText!=null ?
                $"SELECT product.*, category.name as categoryName FROM product inner join category on product.category = category.id " +
                $"where concat (product.id, product.name, description) like '%" + searchText+ "%'"
                :
                $"SELECT product.*, category.name as categoryName FROM product inner join category on product.category = category.id";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            int panelNumber = 0;
            
            List<TovarControl> listItems = new List<TovarControl>();
            while (reader.Read())
            {

                Guna2Panel panel = new Guna2Panel
                {
                    Name = $"tovar+{panelNumber}",
                    Size = new Size(892, 207),
                    Location = new Point(30, 207 * panelNumber + 20),
                    Dock = DockStyle.Top,
                };
                listItems.Add(new TovarControl(Convert.ToInt32(reader["id"]), reader["name"].ToString(), reader["description"].ToString(), reader["categoryName"].ToString()));
                listItems[panelNumber].Dock = DockStyle.Top;
                panel.Controls.Add(listItems[panelNumber]);
                ShowControlsPanel.Controls.Add(panel);
                panelNumber++;

            }
            reader.Close();

            db.closeConnection();
        }
        private void GenerateDynamicUsersControls(string searchText)
        {
            ShowControlsPanel.Controls.Clear();
            DB db = new DB();
            string queryInfo = searchText != null ?
                $"SELECT id, login from users " +
                $"where concat (id, login) like '%" + searchText + "%'"
                :
                $"SELECT id, login from users";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            int panelNumber = 0;

            List<UsersControl> listItems = new List<UsersControl>();
            while (reader.Read())
            {

                Guna2Panel panel = new Guna2Panel
                {
                    Name = $"user+{panelNumber}",
                    Size = new Size(892, 207),
                    Location = new Point(30, 207 * panelNumber + 20),
                    Dock = DockStyle.Top,
                };
                listItems.Add(new UsersControl(reader["id"].ToString()));
                listItems[panelNumber].Dock = DockStyle.Top;
                panel.Controls.Add(listItems[panelNumber]);
                ShowControlsPanel.Controls.Add(panel);
                panelNumber++;

            }
            reader.Close();

            db.closeConnection();
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            switch (whatShow)
            {
                case "Товары": GenerateDynamicTovarControls(SearchTextBox.Text); break;
                case "Пользователи": GenerateDynamicUsersControls(SearchTextBox.Text); break;
                default:
                    break;
            }
        }

        private void AddPost_Click(object sender, EventArgs e)
        {
            new AddPost().Show();
        }
    }
}
